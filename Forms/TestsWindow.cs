using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScheduleBuilder
{
    public partial class TestWindow : Form
    {
        private List<Course> Courses { get; set; }

        public TestWindow(List<Course> courses)
        {
            InitializeComponent();
            this.Courses = courses;
        }

        private void TestWindow_Load(object sender, EventArgs e)
        {
            List<Tuple<string, string, DateTime>> tests = new List<Tuple<string, string, DateTime>>();
            foreach (var course in Courses)
            {
                tests.AddRange(course.Tests);
            }
            tests.Sort(new TestComparer());


            this.testsTable.RowStyles.Clear();
            this.testsTable.RowCount = tests.Count + 1;
            for (int i = 0; i < this.testsTable.RowCount; i++)
            {
                this.testsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            }

            Font font = new Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            Color thisColor = Color.Black;
            Color nextColor = Color.Black;

            for (int i = 1; i <= tests.Count; i++)
            {
                if (i != tests.Count)
                {
                    if (tests.ElementAt(i).Item3.Date.Subtract(tests.ElementAt(i - 1).Item3.Date).TotalDays < 2)
                    {
                        thisColor = Color.Red;
                        nextColor = Color.Red;
                    }
                    else
                    {
                        nextColor = Color.Black;
                    }
                }

                Label label1 = new Label();
                Label label2 = new Label();
                Label label3 = new Label();
                Label label4 = new Label();

                label1.Font = font;
                label1.ForeColor = thisColor;
                label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                label1.Dock = DockStyle.Fill;
                label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label1.Text = tests.ElementAt(i - 1).Item1;
                this.testsTable.Controls.Add(label1, 3, i);

                label2.Font = font;
                label2.ForeColor = thisColor;
                label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                label2.Dock = DockStyle.Fill;
                label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label2.Text = tests.ElementAt(i - 1).Item2;
                this.testsTable.Controls.Add(label2, 2, i);

                label3.Font = font;
                label3.ForeColor = thisColor;
                label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                label3.Dock = DockStyle.Fill;
                label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label3.Text = tests.ElementAt(i - 1).Item3.ToShortDateString();
                this.testsTable.Controls.Add(label3, 1, i);

                label4.Font = font;
                label4.ForeColor = thisColor;
                label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
                label4.Dock = DockStyle.Fill;
                label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label4.Text = tests.ElementAt(i - 1).Item3.ToShortTimeString(); ;
                this.testsTable.Controls.Add(label4, 0, i);

                thisColor = nextColor;
            }
        }
    }
}
