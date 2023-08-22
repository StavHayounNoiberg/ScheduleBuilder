using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ScheduleBuilder
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            Year_box.Value = DateTime.Now.Year;

            if (File.Exists("credentials.dat"))
            {
                IOFunctions.ImportLoginData(out string username, out string password);
                UsernameBox.Text = username;
                PasswordBox.Text = password;
                Remember_login.Checked = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                LoadSchedule_Click(null, EventArgs.Empty);
                Visible = false;
                ShowInTaskbar = false;
                Opacity = 0;

                base.OnLoad(e);
            }
        }

        private void CreateNew_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = false;
            CredentialsPanel.Visible = true;
            CredentialsPanel.BringToFront();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            StartPanel.Visible = true;
            CredentialsPanel.Visible = false;
            StartPanel.BringToFront();
            UsernameBox.Clear();
            PasswordBox.Clear();
            SemesterBox.SelectedIndex = -1;
            CourseBox.Clear();
            CoursesView.Clear();
        }

        private void AddCourseButton_Click(object sender, EventArgs e)
        {
            if (CourseBox.MaskFull && CoursesView.Items.ContainsKey(CourseBox.Text) == false)
            {
                var item = new ListViewItem(CourseBox.Text)
                {
                    Name = CourseBox.Text
                };
                CoursesView.Items.Add(item);
                CoursesView.View = System.Windows.Forms.View.List;
            }
            CourseBox.Text = string.Empty;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UsernameBox.Text))
                    throw (new Exception("Please enter a username"));
                if (string.IsNullOrWhiteSpace(PasswordBox.Text))
                    throw (new Exception("Please enter a password"));
                if (string.IsNullOrWhiteSpace(SemesterBox.Text))
                    throw (new Exception("Please choose a semester"));
                if (CoursesView.Items.Count == 0)
                    throw (new Exception("Please enter at least one course"));
                if (Remember_login.Checked)
                {
                    IOFunctions.ExportLoginData(UsernameBox.Text, PasswordBox.Text);
                }
                else if (File.Exists("credentials.dat"))
                    File.Delete("credentials.dat");

                List<string> list = CoursesView.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
                LoginDataStruct values = new LoginDataStruct(UsernameBox.Text, PasswordBox.Text, Year_box.Value.ToString(), SemesterBox.Text, list);
                Form dataBuilder = new DataBuilding
                {
                    Data = values
                };

                this.Hide();

                dataBuilder.ShowDialog();
                if (dataBuilder.DialogResult == DialogResult.Cancel || dataBuilder.DialogResult == DialogResult.Retry)
                {
                    this.Show();
                }
                else if (dataBuilder.DialogResult != DialogResult.OK)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadSchedule_Click(object sender, EventArgs e)
        {
            List<Schedule> allOptions;
            string scheduleFile;

            if (sender == null)
            {
                scheduleFile = Environment.GetCommandLineArgs()[1];
            }
            else
            {
                OpenFileDialog loadFile = new OpenFileDialog()
                {
                    Title = "Load Schedules File...",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "Schedule Builder File (*.sbf)|*.sbf",
                };

                if (loadFile.ShowDialog() == DialogResult.OK)
                {
                    scheduleFile = loadFile.FileName;
                    loadFile.Dispose();
                }
                else
                {
                    loadFile.Dispose();
                    return;
                }
            }

            allOptions = IOFunctions.ReadSchedulesFile(scheduleFile, out List<Course> allCourses);

            if (allOptions == null)
            {
                MessageBox.Show("You can load only .sbf files created with ScheduleBuilder", "Wrong File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            Form view = new ViewSchedule(allOptions, allCourses);
            view.Show();
        }

        private void CoursesView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CoursesView.SelectedIndices.Count > 0)
            {
                CoursesView.Items.Remove(CoursesView.SelectedItems[0]);
                CoursesView.Refresh();
            }
        }
    }
}
