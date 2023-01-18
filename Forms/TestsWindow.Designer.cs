namespace ScheduleBuilder
{
    partial class TestWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestWindow));
            this.testsTable = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.kindLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.testsTable.SuspendLayout();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // testsTable
            // 
            this.testsTable.AutoSize = true;
            this.testsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testsTable.ColumnCount = 4;
            this.testsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.testsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.testsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.testsTable.Controls.Add(this.timeLabel, 0, 0);
            this.testsTable.Controls.Add(this.dateLabel, 1, 0);
            this.testsTable.Controls.Add(this.kindLabel, 2, 0);
            this.testsTable.Controls.Add(this.nameLabel, 3, 0);
            this.testsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testsTable.Location = new System.Drawing.Point(0, 0);
            this.testsTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testsTable.Name = "testsTable";
            this.testsTable.RowCount = 2;
            this.testsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.testsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.testsTable.Size = new System.Drawing.Size(1063, 524);
            this.testsTable.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeLabel.Location = new System.Drawing.Point(4, 0);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(257, 25);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "שעה";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateLabel.Location = new System.Drawing.Point(269, 0);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(257, 25);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "תאריך";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kindLabel
            // 
            this.kindLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kindLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kindLabel.Location = new System.Drawing.Point(534, 0);
            this.kindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kindLabel.Name = "kindLabel";
            this.kindLabel.Size = new System.Drawing.Size(151, 25);
            this.kindLabel.TabIndex = 1;
            this.kindLabel.Text = "מועד";
            this.kindLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel.Location = new System.Drawing.Point(693, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(366, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "קורס";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backPanel
            // 
            this.backPanel.AutoSize = true;
            this.backPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backPanel.Controls.Add(this.testsTable);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1063, 524);
            this.backPanel.TabIndex = 2;
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1063, 524);
            this.Controls.Add(this.backPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "TestWindow";
            this.Text = "Schedule Tests";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TestWindow_Load);
            this.testsTable.ResumeLayout(false);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel testsTable;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label kindLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}