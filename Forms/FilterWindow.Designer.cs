namespace ScheduleBuilder
{
    partial class FilterWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterWindow));
            this.filtersTable = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newFilterButton = new System.Windows.Forms.ToolStripButton();
            this.deleteFilterButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.applyFilters = new System.Windows.Forms.ToolStripButton();
            this.backPanel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersTable
            // 
            this.filtersTable.ColumnCount = 4;
            this.filtersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.filtersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.filtersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.filtersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.filtersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersTable.Location = new System.Drawing.Point(0, 0);
            this.filtersTable.Name = "filtersTable";
            this.filtersTable.RowCount = 10;
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filtersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.filtersTable.Size = new System.Drawing.Size(1260, 404);
            this.filtersTable.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFilterButton,
            this.deleteFilterButton,
            this.toolStripSeparator1,
            this.applyFilters});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1260, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // newFilterButton
            // 
            this.newFilterButton.Image = global::ScheduleBuilder.Properties.Resources.add_icon;
            this.newFilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFilterButton.Name = "newFilterButton";
            this.newFilterButton.Size = new System.Drawing.Size(82, 24);
            this.newFilterButton.Text = "Add Filter";
            this.newFilterButton.ToolTipText = "Add Filter";
            this.newFilterButton.Click += new System.EventHandler(this.NewFilterButton_Click);
            // 
            // deleteFilterButton
            // 
            this.deleteFilterButton.Image = global::ScheduleBuilder.Properties.Resources.cancel_icon;
            this.deleteFilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteFilterButton.Name = "deleteFilterButton";
            this.deleteFilterButton.Size = new System.Drawing.Size(117, 24);
            this.deleteFilterButton.Text = "Delete Last Filter";
            this.deleteFilterButton.ToolTipText = "Add Filter";
            this.deleteFilterButton.Click += new System.EventHandler(this.DeleteFilterButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // applyFilters
            // 
            this.applyFilters.Image = global::ScheduleBuilder.Properties.Resources.apply_icon;
            this.applyFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applyFilters.Name = "applyFilters";
            this.applyFilters.Size = new System.Drawing.Size(96, 24);
            this.applyFilters.Text = "Apply Filters";
            this.applyFilters.Click += new System.EventHandler(this.ApplyFilters_Click);
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.filtersTable);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 27);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1260, 404);
            this.backPanel.TabIndex = 2;
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 431);
            this.ControlBox = false;
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilterWindow";
            this.Text = "Add Filters";
            this.TopMost = true;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel filtersTable;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.ToolStripButton newFilterButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton applyFilters;
        private System.Windows.Forms.ToolStripButton deleteFilterButton;
    }
}