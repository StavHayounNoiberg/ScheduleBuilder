using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScheduleBuilder
{
    public partial class ViewSchedule : Form
    {
        public List<Course> AllCourses { get; set; }
        public List<Schedule> AllOptions { get; set; }
        public List<Schedule> FilteredOptions { get; set; }
        private int CurrentSchedule { get; set; }
        private string CurrentSchedule_text { get; set; }
        private readonly Color[] colors = { Color.LightBlue, Color.LightGreen, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightPink, Color.Thistle, Color.Wheat, Color.LightCoral, Color.LightSeaGreen, Color.LightSteelBlue, Color.SandyBrown, Color.Snow };
        private int UsedColor { get; set; }
        private Dictionary<string, Color> ColorPalette { get; set; }
        private int FontSize { get; set; }

        Form FilterWindow { get; set; }

        public ViewSchedule(List<Schedule> schedules, List<Course> courses)
        {
            if (schedules.Count == 0)
            {
                MessageBox.Show("No schedules found for this courses combination. Change courses or semester and try again.", "No Schedules Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            InitializeComponent();
            AllCourses = courses;
            AllOptions = schedules;
            FilteredOptions = schedules;
            CurrentSchedule = 0;
            CurrentSchedule_text = "1";
            SetDoubleBuffered(this.BackPanel);
            SetDoubleBuffered(this.baseTable);
            SetDoubleBuffered(this.daysTable);
            SetDoubleBuffered(this.hoursTable);
            SetDoubleBuffered(this.scheduleTable);
            ColorPalette = new Dictionary<string, Color>();
            UsedColor = 0;
            FontSize = 8;
            SetPalette(AllOptions.ElementAt(0));

            FilterWindow = new FilterWindow(this);
        }

        public void SetFilteredOptions(List<Schedule> filtered)
        {
            if (filtered.Count > 0)
            {
                FilteredOptions = filtered;
                ChangeSchedule(0);
            }
            else
                MessageBox.Show("No schedules were found with the given filters. Remove or change filters and try again", "No Schedules Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SetPalette(Schedule schedule)
        {
            foreach (var course in schedule.CoursesInSchedule)
            {
                if (ColorPalette.ContainsKey(course.CourseName) == false)
                    ColorPalette.Add(course.CourseName, colors[UsedColor++]);
                if (UsedColor == colors.Length)
                    UsedColor = 0;
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog loadFile = new SaveFileDialog()
            {
                Title = "Save All Schedules To File...",
                CheckPathExists = true,
                Filter = "Schedule Builder File (*.sbf)|*.sbf",
                OverwritePrompt = true
            };

            if (loadFile.ShowDialog() == DialogResult.OK)
                IOFunctions.ExportOptions(AllOptions, AllCourses, loadFile.FileName);
            loadFile.Dispose();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, rect);
            Clipboard.SetImage((Image)bitmap);
        }

        private void FilterToolStripButton_Click(object sender, EventArgs e)
        {
            FilterWindow.Show();
            FilterWindow.BringToFront();
        }

        private void TestsToolStripButton_Click(object sender, EventArgs e)
        {
            TestWindow testWindow = new TestWindow(AllCourses);
            testWindow.Show();
        }

        private void PrevSchedule_Click(object sender, EventArgs e)
        {
            ChangeSchedule(CurrentSchedule - 1);
        }

        private void NextSchedule_Click(object sender, EventArgs e)
        {
            ChangeSchedule(CurrentSchedule + 1);
        }

        private void CurrentSchedule_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var res = Int32.TryParse(currentSchedule_box.Text, out var input);
                if (res)
                    ChangeSchedule(input - 1);
            }
        }

        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(fontSizeComboBox.Text, out int size);
            if (size >= 8)
                FontSize = size;
            scheduleTable.Refresh();
        }

        private void ChangeSchedule(int nextSchedule)
        {
            if (nextSchedule >= FilteredOptions.Count || nextSchedule < 0)
                return;
            CurrentSchedule_text = (nextSchedule + 1).ToString();
            CurrentSchedule = nextSchedule;
            scheduleTable.Refresh();
        }

        private void ScheduleTable_Paint(object sender, PaintEventArgs e)
        {
            currentSchedule_box.Text = CurrentSchedule_text;
            scheduleNumber_label.Text = string.Format("Schedule {0} of {1}", CurrentSchedule_text, FilteredOptions.Count);

            Font font = new Font("Calibri", FontSize);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Near
            };

            int height = scheduleTable.GetRowHeights()[0];
            int width = scheduleTable.GetColumnWidths()[0];
            double ratio = (double)height / (double)60;

            foreach (var instance in FilteredOptions.ElementAt(CurrentSchedule).CoursesInSchedule)
            {
                string suffix = "";
                if (instance.Class != ClassType.Lecture)
                {
                    suffix = "(תרגול) ";
                }

                foreach (var time in instance.Times)
                {
                    int x = scheduleTable.Right - ((int)(time.Day) + 1) * width;
                    int y = scheduleTable.Top + (time.StartTime.Hours - 9) * height;
                    int z = (int)Math.Round((time.EndTime.TotalMinutes - time.StartTime.TotalMinutes) * ratio);
                    string txt = string.Concat(instance.CourseName, suffix, instance.GroupID, "\n", instance.Lecturer, "\n", time.Location, "\n", time.StartTime.ToString(@"hh\:mm"), "-", time.EndTime.ToString(@"hh\:mm"));
                    ColorPalette.TryGetValue(instance.CourseName, out Color color);
                    SolidBrush brush = new SolidBrush(color);
                    Rectangle rectangle = new Rectangle(x, y, (int)(width * 0.98), z);
                    e.Graphics.FillRectangle(brush, rectangle);
                    e.Graphics.DrawString(txt, font, Brushes.Black, rectangle, stringFormat);
                    brush.Dispose();
                }
            }
            stringFormat.Dispose();
            font.Dispose();
        }

        private void ViewSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Application.Exit();
        }

        #region .. Double Buffered function ..
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }
        #endregion

        #region .. code for Flucuring ..
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
    }
}
