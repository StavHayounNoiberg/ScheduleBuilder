using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ScheduleBuilder
{
    public partial class DataBuilding : Form
    {
        public LoginDataStruct Data { get; set; }

        public DataBuilding()
        {
            InitializeComponent();
        }

        private void DataBuilding_Shown(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            #region Initiate
            List<Course> Courses = new List<Course>();
            foreach (var course in Data.Courses)
            {
                Courses.Add(new Course(Int32.Parse(course), string.Empty));
            }
            backgroundWorker.ReportProgress(5);
            #endregion
            #region Login
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            IWebDriver driver = null;
            try
            {
                driver = BuildScheduleFunctions.AfekaLogin(Data.Username, Data.Password);
            }
            catch
            {
                e.Result = "Cannot login to AfekaNet. Make sure you installed Chrome browser version 109.0.5414.74 or above. Check your internet connection and credentials and try again.";
            }
            if (e.Result != null)
                return;
            backgroundWorker.ReportProgress(20);
            #endregion
            #region Get Courses Info
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            try
            {
                BuildScheduleFunctions.GetAllData(ref driver, ref Courses, Data.Year, Data.Semester);
            }
            catch (Exception ex)
            {
                if (ex.Message != string.Empty)
                {
                    e.Result = string.Concat("The course: ", ex.Message, " is not available in the current semester selection.\nTry different course or semester.");
                }
                else
                {
                    e.Result = "Cannot get data from AfekaNet. Check your internet connection and try again.\nIt is possible that AfekaNet layout has changed.";
                }
                return;
            }
            backgroundWorker.ReportProgress(65);
            #endregion
            #region Analyze Data
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            Courses.Sort(new CourseComparer());
            List<Schedule> options = Schedule.FindAllOptions(ref Courses);
            if (options.Count == 0)
            {
                e.Result = "No schedules were found. Change the courses combination or the semester and try again.";
                return;
            }
            backgroundWorker.ReportProgress(100);
            e.Result = new Tuple<List<Schedule>, List<Course>>(options, Courses);
            #endregion
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Data_progressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                BuildScheduleFunctions.KillChrome();
            }
            catch { }
            finally
            {
                if (e.Error != null)
                {
                    MessageBox.Show(string.Concat("Unexpected Error: ", e.Error.Message), "Unhandeled Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
                else if (e.Cancelled)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                else if (e.Result is string result)
                {
                    MessageBox.Show(result, "Schedule Building Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = DialogResult.Retry;
                }
                else if (e.Result is Tuple<List<Schedule>, List<Course>> res)
                {
                    Form view = new ViewSchedule(res.Item1, res.Item2);
                    view.Show();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new Exception("not good");
                }
                this.Close();
            }
        }

        private void CancelDataButton_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }
    }
}
