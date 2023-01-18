using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ScheduleBuilder
{
    public partial class FilterWindow : Form
    {
        private ViewSchedule FormOwner { get; set; }
        private List<Schedule> FilteredOptions { get; set; }
        private int RulesCount { get; set; }
        private int MaxRules { get; set; }

        public FilterWindow(ViewSchedule sender)
        {
            InitializeComponent();
            FormOwner = sender;
            MaxRules = 10;
            RulesCount = 0;
        }

        private void NewFilterButton_Click(object sender, EventArgs e)
        {
            if (RulesCount < MaxRules)
            {
                filtersTable.Controls.Add(new CheckBox(), 0, RulesCount);
                CheckBox checkbox = filtersTable.GetControlFromPosition(0, RulesCount) as CheckBox;
                checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                checkbox.AutoSize = true;
                checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                checkbox.Checked = true;

                filtersTable.Controls.Add(new ComboBox(), 1, RulesCount);
                ComboBox filter1 = filtersTable.GetControlFromPosition(1, RulesCount) as ComboBox;
                filter1.Dock = System.Windows.Forms.DockStyle.Fill;
                filter1.FormattingEnabled = true;
                filter1.Items.AddRange(new object[] {
                    "Start Time",
                    "End Time",
                    "Lecturer",
                    "Group Number"});
                filter1.Text = "Choose Filter";
                filter1.SelectedIndexChanged += new System.EventHandler(this.FilterBox1_SelectedIndexChanged);

                filtersTable.Controls.Add(new ComboBox(), 2, RulesCount);
                ComboBox filter2 = filtersTable.GetControlFromPosition(2, RulesCount) as ComboBox;
                filter2.Dock = System.Windows.Forms.DockStyle.Fill;
                filter2.FormattingEnabled = true;

                RulesCount++;
            }
        }

        private void FilterBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = filtersTable.GetPositionFromControl((Control)sender).Row;
            ComboBox filter2 = filtersTable.GetControlFromPosition(2, index) as ComboBox;

            if (filtersTable.GetControlFromPosition(3, index) != null)
                filtersTable.Controls.Remove(filtersTable.GetControlFromPosition(3, index));

            switch (((ComboBox)sender).Text)
            {
                case "Start Time":
                    ComboBox filter3_1 = new ComboBox
                    {
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        FormattingEnabled = true
                    };
                    filtersTable.Controls.Add(filter3_1, 3, index);
                    filter2.Items.Clear();
                    filter2.Items.AddRange(new object[] { "on Sunday", "on Monday", "on Tuesday", "on Wednesday", "on Thursday", "on Friday" });
                    filter2.Text = "Choose Day";
                    filter3_1.Items.AddRange(new object[] { "Day Off", "after 09:00", "after 10:00", "after 11:00", "after 12:00", "after 13:00", "after 14:00", "after 15:00", "after 16:00", "after 17:00", "after 18:00", "after 19:00", "after 20:00", "after 21:00", "after 22:00" });
                    filter3_1.Text = "Choose Time";
                    break;
                case "End Time":
                    ComboBox filter3_2 = new ComboBox
                    {
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        FormattingEnabled = true
                    };
                    filtersTable.Controls.Add(filter3_2, 3, index);
                    filter2.Items.Clear();
                    filter2.Items.AddRange(new object[] { "on Sunday", "on Monday", "on Tuesday", "on Wednesday", "on Thursday", "on Friday" });
                    filter2.Text = "Choose Day";
                    filter3_2.Items.AddRange(new object[] { "Day Off", "before 09:00", "before 10:00", "before 11:00", "before 12:00", "before 13:00", "before 14:00", "before 15:00", "before 16:00", "before 17:00", "before 18:00", "before 19:00", "before 20:00", "before 21:00", "before 22:00" });
                    filter3_2.Text = "Choose Time";
                    break;
                case "Lecturer":
                    ComboBox filter3_3 = new ComboBox
                    {
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        FormattingEnabled = true
                    };
                    filtersTable.Controls.Add(filter3_3, 3, index);
                    filter2.Items.Clear();
                    //filter2.Items.AddRange(FormOwner.AllCourses.Select(x => x.Name).ToArray());
                    //filter2.Text = "In Course";
                    filter2.Items.AddRange(new object[] { "included in schedule", "not included in schedule" });
                    filter2.Text = "Specify Filter";
                    foreach (var course in FormOwner.AllCourses)
                    {
                        filter3_3.Items.AddRange(course.Lecturers.ToArray());
                    }
                    filter3_3.Text = "Choose Lecturer";
                    break;
                case "Group Number":
                    filter2.Items.Clear();
                    filter2.Items.AddRange(new object[] { "included in schedule", "not included in schedule" });
                    filter2.Text = "Specify Filter";
                    TextBox box = new TextBox
                    {
                        Size = filter2.Size
                    };
                    filtersTable.Controls.Add(box, 3, index);
                    box.BringToFront();
                    break;
                default:
                    break;
            }
        }

        private void DeleteFilterButton_Click(object sender, EventArgs e)
        {
            if (RulesCount > 0)
            {
                for (int i = 0; i < filtersTable.ColumnCount; i++)
                {
                    filtersTable.Controls.Remove(filtersTable.GetControlFromPosition(i, RulesCount - 1));
                }
                RulesCount--;
            }
        }

        private void ApplyFilters_Click(object sender, EventArgs e)
        {
            var filters = new List<Func<Schedule, bool>>();
            try
            {
                for (int i = 0; i < RulesCount; i++)
                {
                    CheckBox checkbox = filtersTable.GetControlFromPosition(0, i) as CheckBox;
                    ComboBox filter1 = filtersTable.GetControlFromPosition(1, i) as ComboBox;

                    if (checkbox.Checked)
                    {
                        if (filter1.Text.Contains("Time"))
                        {
                            var index1 = ((ComboBox)filtersTable.GetControlFromPosition(2, i)).SelectedIndex;
                            var index2 = ((ComboBox)filtersTable.GetControlFromPosition(3, i)).SelectedIndex;
                            if (index1 == -1 || index2 == -1)
                            {
                                filters.Clear();
                                break;

                            }

                            if (filter1.Text == "Start Time")
                            {
                                if (index2 > 0)
                                    filters.Add(option => option.StartTimes[index1] >= TimeSpan.FromHours(index2 + 8));
                                else
                                    filters.Add(option => option.StartTimes[index1] >= TimeSpan.FromHours(23));
                            }
                            else if (filter1.Text == "End Time")
                            {
                                filters.Add(option => option.EndTimes[index1] <= TimeSpan.FromHours(index2 + 8));
                            }
                        }
                        else if (filter1.Text == "Lecturer")
                        {
                            string lecturer = ((ComboBox)filtersTable.GetControlFromPosition(3, i)).Text;
                            if (((ComboBox)filtersTable.GetControlFromPosition(2, i)).Text == "included in schedule")
                            {
                                filters.Add(option => option.CoursesInSchedule.Any(courseGroup => courseGroup.Lecturer == lecturer));
                            }
                            else
                            {
                                filters.Add(option => option.CoursesInSchedule.All(courseGroup => courseGroup.Lecturer != lecturer));
                            }
                        }
                        else if (filter1.Text == "Group Number")
                        {
                            string group = ((TextBox)filtersTable.GetControlFromPosition(3, i)).Text;
                            if (((ComboBox)filtersTable.GetControlFromPosition(2, i)).Text == "included in schedule")
                            {
                                filters.Add(option => option.CoursesInSchedule.Any(courseGroup => courseGroup.GroupID == group));
                            }
                            else
                            {
                                filters.Add(option => option.CoursesInSchedule.All(courseGroup => courseGroup.GroupID != group));
                            }
                        }
                    }
                }
            }
            catch
            {
                filters.Clear();
            }

            FilteredOptions = FormOwner.AllOptions;
            foreach (var filter in filters)
            {
                var thisFilter = filter;
                FilteredOptions = FilteredOptions.Where(thisFilter).ToList();
            }
            FormOwner.SetFilteredOptions(FilteredOptions);
            this.Hide();
        }
    }
}
