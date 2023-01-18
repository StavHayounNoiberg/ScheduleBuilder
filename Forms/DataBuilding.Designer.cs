namespace ScheduleBuilder
{
    partial class DataBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBuilding));
            this.Data_progressBar = new System.Windows.Forms.ProgressBar();
            this.DataWindow_label = new System.Windows.Forms.Label();
            this.CancelDataButton = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Data_progressBar
            // 
            this.Data_progressBar.Location = new System.Drawing.Point(69, 57);
            this.Data_progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.Data_progressBar.Name = "Data_progressBar";
            this.Data_progressBar.Size = new System.Drawing.Size(146, 19);
            this.Data_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Data_progressBar.TabIndex = 0;
            // 
            // DataWindow_label
            // 
            this.DataWindow_label.AutoSize = true;
            this.DataWindow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DataWindow_label.Location = new System.Drawing.Point(81, 24);
            this.DataWindow_label.Name = "DataWindow_label";
            this.DataWindow_label.Size = new System.Drawing.Size(132, 16);
            this.DataWindow_label.TabIndex = 4;
            this.DataWindow_label.Text = "Building Schedules...";
            // 
            // CancelDataButton
            // 
            this.CancelDataButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CancelDataButton.Location = new System.Drawing.Point(108, 91);
            this.CancelDataButton.Name = "CancelDataButton";
            this.CancelDataButton.Size = new System.Drawing.Size(69, 23);
            this.CancelDataButton.TabIndex = 13;
            this.CancelDataButton.Text = "Cancel";
            this.CancelDataButton.UseVisualStyleBackColor = true;
            this.CancelDataButton.Click += new System.EventHandler(this.CancelDataButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // DataBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CancelButton = this.CancelDataButton;
            this.ClientSize = new System.Drawing.Size(286, 124);
            this.ControlBox = false;
            this.Controls.Add(this.CancelDataButton);
            this.Controls.Add(this.DataWindow_label);
            this.Controls.Add(this.Data_progressBar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DataBuilding";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulidng Schedules...";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.DataBuilding_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Data_progressBar;
        private System.Windows.Forms.Label DataWindow_label;
        private System.Windows.Forms.Button CancelDataButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}