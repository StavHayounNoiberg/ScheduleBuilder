namespace ScheduleBuilder
{
    partial class StartWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.CreateNew = new System.Windows.Forms.Button();
            this.LoadSchedule = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.CredentialsPanel = new System.Windows.Forms.Panel();
            this.Remember_login = new System.Windows.Forms.CheckBox();
            this.Year_box = new System.Windows.Forms.NumericUpDown();
            this.Year_label = new System.Windows.Forms.Label();
            this.CoursesList_Label = new System.Windows.Forms.Label();
            this.CourseBox = new System.Windows.Forms.MaskedTextBox();
            this.CancelCredentialsButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.Courses_label = new System.Windows.Forms.Label();
            this.CoursesView = new System.Windows.Forms.ListView();
            this.Semester_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.SemesterBox = new System.Windows.Forms.ComboBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.logoTitle = new System.Windows.Forms.Label();
            this.logoSubtitle = new System.Windows.Forms.Label();
            this.StartPanel.SuspendLayout();
            this.CredentialsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateNew
            // 
            this.CreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateNew.AutoSize = true;
            this.CreateNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateNew.Location = new System.Drawing.Point(10, 333);
            this.CreateNew.Name = "CreateNew";
            this.CreateNew.Size = new System.Drawing.Size(139, 27);
            this.CreateNew.TabIndex = 1;
            this.CreateNew.Text = "Build new schedule";
            this.CreateNew.UseVisualStyleBackColor = true;
            this.CreateNew.Click += new System.EventHandler(this.CreateNew_Click);
            // 
            // LoadSchedule
            // 
            this.LoadSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSchedule.AutoSize = true;
            this.LoadSchedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LoadSchedule.Location = new System.Drawing.Point(461, 333);
            this.LoadSchedule.Name = "LoadSchedule";
            this.LoadSchedule.Size = new System.Drawing.Size(116, 27);
            this.LoadSchedule.TabIndex = 0;
            this.LoadSchedule.Text = "Load from file...";
            this.LoadSchedule.UseVisualStyleBackColor = true;
            this.LoadSchedule.Click += new System.EventHandler(this.LoadSchedule_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.logoSubtitle);
            this.StartPanel.Controls.Add(this.logoTitle);
            this.StartPanel.Controls.Add(this.pictureLogo);
            this.StartPanel.Controls.Add(this.LoadSchedule);
            this.StartPanel.Controls.Add(this.CreateNew);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartPanel.Location = new System.Drawing.Point(0, 0);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(586, 368);
            this.StartPanel.TabIndex = 2;
            // 
            // CredentialsPanel
            // 
            this.CredentialsPanel.AutoSize = true;
            this.CredentialsPanel.Controls.Add(this.Remember_login);
            this.CredentialsPanel.Controls.Add(this.Year_box);
            this.CredentialsPanel.Controls.Add(this.Year_label);
            this.CredentialsPanel.Controls.Add(this.CoursesList_Label);
            this.CredentialsPanel.Controls.Add(this.CourseBox);
            this.CredentialsPanel.Controls.Add(this.CancelCredentialsButton);
            this.CredentialsPanel.Controls.Add(this.SubmitButton);
            this.CredentialsPanel.Controls.Add(this.AddCourseButton);
            this.CredentialsPanel.Controls.Add(this.Courses_label);
            this.CredentialsPanel.Controls.Add(this.CoursesView);
            this.CredentialsPanel.Controls.Add(this.Semester_label);
            this.CredentialsPanel.Controls.Add(this.Password_label);
            this.CredentialsPanel.Controls.Add(this.Email_label);
            this.CredentialsPanel.Controls.Add(this.Username_label);
            this.CredentialsPanel.Controls.Add(this.SemesterBox);
            this.CredentialsPanel.Controls.Add(this.PasswordBox);
            this.CredentialsPanel.Controls.Add(this.UsernameBox);
            this.CredentialsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CredentialsPanel.Location = new System.Drawing.Point(0, 0);
            this.CredentialsPanel.Name = "CredentialsPanel";
            this.CredentialsPanel.Size = new System.Drawing.Size(586, 368);
            this.CredentialsPanel.TabIndex = 2;
            this.CredentialsPanel.Visible = false;
            // 
            // Remember_login
            // 
            this.Remember_login.AutoSize = true;
            this.Remember_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Remember_login.Location = new System.Drawing.Point(33, 67);
            this.Remember_login.Name = "Remember_login";
            this.Remember_login.Size = new System.Drawing.Size(217, 20);
            this.Remember_login.TabIndex = 2;
            this.Remember_login.Text = "Remember my login credentials";
            this.Remember_login.UseVisualStyleBackColor = true;
            // 
            // Year_box
            // 
            this.Year_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Year_box.Location = new System.Drawing.Point(148, 96);
            this.Year_box.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.Year_box.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.Year_box.Name = "Year_box";
            this.Year_box.Size = new System.Drawing.Size(120, 22);
            this.Year_box.TabIndex = 3;
            this.Year_box.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Year_label.Location = new System.Drawing.Point(30, 99);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(40, 16);
            this.Year_label.TabIndex = 16;
            this.Year_label.Text = "Year:";
            // 
            // CoursesList_Label
            // 
            this.CoursesList_Label.AutoSize = true;
            this.CoursesList_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CoursesList_Label.Location = new System.Drawing.Point(30, 180);
            this.CoursesList_Label.Name = "CoursesList_Label";
            this.CoursesList_Label.Size = new System.Drawing.Size(84, 16);
            this.CoursesList_Label.TabIndex = 14;
            this.CoursesList_Label.Text = "Courses List:";
            // 
            // CourseBox
            // 
            this.CourseBox.AllowPromptAsInput = false;
            this.CourseBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.CourseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CourseBox.HidePromptOnLeave = true;
            this.CourseBox.Location = new System.Drawing.Point(148, 154);
            this.CourseBox.Mask = "00000";
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.PromptChar = '#';
            this.CourseBox.RejectInputOnFirstFailure = true;
            this.CourseBox.ResetOnPrompt = false;
            this.CourseBox.Size = new System.Drawing.Size(174, 22);
            this.CourseBox.TabIndex = 5;
            this.CourseBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.CourseBox.ValidatingType = typeof(int);
            // 
            // CancelCredentialsButton
            // 
            this.CancelCredentialsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCredentialsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CancelCredentialsButton.Location = new System.Drawing.Point(488, 335);
            this.CancelCredentialsButton.Name = "CancelCredentialsButton";
            this.CancelCredentialsButton.Size = new System.Drawing.Size(69, 23);
            this.CancelCredentialsButton.TabIndex = 8;
            this.CancelCredentialsButton.Text = "Cancel";
            this.CancelCredentialsButton.UseVisualStyleBackColor = true;
            this.CancelCredentialsButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubmitButton.Location = new System.Drawing.Point(28, 335);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(69, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddCourseButton.Location = new System.Drawing.Point(327, 154);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(69, 23);
            this.AddCourseButton.TabIndex = 6;
            this.AddCourseButton.Text = "Add";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // Courses_label
            // 
            this.Courses_label.AutoSize = true;
            this.Courses_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Courses_label.Location = new System.Drawing.Point(30, 157);
            this.Courses_label.Name = "Courses_label";
            this.Courses_label.Size = new System.Drawing.Size(61, 16);
            this.Courses_label.TabIndex = 9;
            this.Courses_label.Text = "Courses:";
            // 
            // CoursesView
            // 
            this.CoursesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CoursesView.HideSelection = false;
            this.CoursesView.Location = new System.Drawing.Point(28, 201);
            this.CoursesView.Name = "CoursesView";
            this.CoursesView.ShowItemToolTips = true;
            this.CoursesView.Size = new System.Drawing.Size(530, 125);
            this.CoursesView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CoursesView.TabIndex = 7;
            this.CoursesView.UseCompatibleStateImageBehavior = false;
            this.CoursesView.View = System.Windows.Forms.View.List;
            this.CoursesView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CoursesView_MouseDoubleClick);
            // 
            // Semester_label
            // 
            this.Semester_label.AutoSize = true;
            this.Semester_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Semester_label.Location = new System.Drawing.Point(30, 127);
            this.Semester_label.Name = "Semester_label";
            this.Semester_label.Size = new System.Drawing.Size(69, 16);
            this.Semester_label.TabIndex = 6;
            this.Semester_label.Text = "Semester:";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password_label.Location = new System.Drawing.Point(30, 39);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(71, 16);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Password:";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Email_label.Location = new System.Drawing.Point(290, 11);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(93, 16);
            this.Email_label.TabIndex = 4;
            this.Email_label.Text = "@s.afeka.ac.il";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Username_label.Location = new System.Drawing.Point(30, 11);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(112, 16);
            this.Username_label.TabIndex = 3;
            this.Username_label.Text = "Afeka Username:";
            // 
            // SemesterBox
            // 
            this.SemesterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SemesterBox.FormattingEnabled = true;
            this.SemesterBox.Items.AddRange(new object[] {
            "1",
            "2",
            "Summer"});
            this.SemesterBox.Location = new System.Drawing.Point(148, 124);
            this.SemesterBox.Name = "SemesterBox";
            this.SemesterBox.Size = new System.Drawing.Size(134, 24);
            this.SemesterBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PasswordBox.Location = new System.Drawing.Point(148, 36);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(249, 22);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UsernameBox.Location = new System.Drawing.Point(148, 8);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(141, 22);
            this.UsernameBox.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::ScheduleBuilder.Properties.Resources.icon_512;
            this.pictureLogo.Location = new System.Drawing.Point(107, 100);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(128, 119);
            this.pictureLogo.TabIndex = 2;
            this.pictureLogo.TabStop = false;
            // 
            // logoTitle
            // 
            this.logoTitle.AutoSize = true;
            this.logoTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(105)))));
            this.logoTitle.Location = new System.Drawing.Point(241, 138);
            this.logoTitle.Name = "logoTitle";
            this.logoTitle.Size = new System.Drawing.Size(238, 39);
            this.logoTitle.TabIndex = 3;
            this.logoTitle.Text = "Schedule Builder";
            // 
            // logoSubtitle
            // 
            this.logoSubtitle.AutoSize = true;
            this.logoSubtitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoSubtitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(162)))), ((int)(((byte)(141)))));
            this.logoSubtitle.Location = new System.Drawing.Point(245, 177);
            this.logoSubtitle.Name = "logoSubtitle";
            this.logoSubtitle.Size = new System.Drawing.Size(231, 23);
            this.logoSubtitle.TabIndex = 4;
            this.logoSubtitle.Text = "Building Schedule Made Easy";
            // 
            // StartWindow
            // 
            this.AcceptButton = this.AddCourseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.CredentialsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Builder";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.CredentialsPanel.ResumeLayout(false);
            this.CredentialsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateNew;
        private System.Windows.Forms.Button LoadSchedule;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Panel CredentialsPanel;
        private System.Windows.Forms.ListView CoursesView;
        private System.Windows.Forms.Label Semester_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.ComboBox SemesterBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Courses_label;
        private System.Windows.Forms.Button CancelCredentialsButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button AddCourseButton;
        private System.Windows.Forms.MaskedTextBox CourseBox;
        private System.Windows.Forms.Label CoursesList_Label;
        private System.Windows.Forms.CheckBox Remember_login;
        private System.Windows.Forms.NumericUpDown Year_box;
        private System.Windows.Forms.Label Year_label;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label logoSubtitle;
        private System.Windows.Forms.Label logoTitle;
    }
}

