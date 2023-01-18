namespace ScheduleBuilder
{
    partial class ViewSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSchedule));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prevSchedule = new System.Windows.Forms.ToolStripButton();
            this.currentSchedule_box = new System.Windows.Forms.ToolStripTextBox();
            this.nextSchedule = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextSizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.testsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.baseTable = new System.Windows.Forms.TableLayoutPanel();
            this.hoursTable = new System.Windows.Forms.TableLayoutPanel();
            this.hour_label8 = new System.Windows.Forms.Label();
            this.hour_label9 = new System.Windows.Forms.Label();
            this.hour_label10 = new System.Windows.Forms.Label();
            this.hour_label11 = new System.Windows.Forms.Label();
            this.hour_label12 = new System.Windows.Forms.Label();
            this.hour_label13 = new System.Windows.Forms.Label();
            this.hour_label14 = new System.Windows.Forms.Label();
            this.hour_label15 = new System.Windows.Forms.Label();
            this.hour_label16 = new System.Windows.Forms.Label();
            this.hour_label17 = new System.Windows.Forms.Label();
            this.hour_label18 = new System.Windows.Forms.Label();
            this.hour_label19 = new System.Windows.Forms.Label();
            this.hour_label20 = new System.Windows.Forms.Label();
            this.hour_label21 = new System.Windows.Forms.Label();
            this.hour_label22 = new System.Windows.Forms.Label();
            this.daysTable = new System.Windows.Forms.TableLayoutPanel();
            this.sunday_label = new System.Windows.Forms.Label();
            this.monday_label = new System.Windows.Forms.Label();
            this.tuesday_label = new System.Windows.Forms.Label();
            this.wednesday_label = new System.Windows.Forms.Label();
            this.thursday_label = new System.Windows.Forms.Label();
            this.friday_label = new System.Windows.Forms.Label();
            this.scheduleTable = new System.Windows.Forms.TableLayoutPanel();
            this.cornerPanel = new System.Windows.Forms.Panel();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.scheduleNumber_label = new System.Windows.Forms.Label();
            this.ToolStrip.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.baseTable.SuspendLayout();
            this.hoursTable.SuspendLayout();
            this.daysTable.SuspendLayout();
            this.cornerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.copyToolStripButton,
            this.toolStripSeparator1,
            this.filterToolStripButton,
            this.toolStripSeparator2,
            this.prevSchedule,
            this.currentSchedule_box,
            this.nextSchedule,
            this.toolStripSeparator4,
            this.toolStripTextSizeLabel,
            this.fontSizeComboBox,
            this.toolStripSeparator3,
            this.testsToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1184, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.saveToolStripButton.Text = "Save All";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(158, 22);
            this.copyToolStripButton.Text = "Copy Schedule As Image";
            this.copyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // filterToolStripButton
            // 
            this.filterToolStripButton.Image = global::ScheduleBuilder.Properties.Resources.filter_icon;
            this.filterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripButton.Name = "filterToolStripButton";
            this.filterToolStripButton.Size = new System.Drawing.Size(93, 22);
            this.filterToolStripButton.Text = "Filter Results";
            this.filterToolStripButton.Click += new System.EventHandler(this.FilterToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // prevSchedule
            // 
            this.prevSchedule.Image = global::ScheduleBuilder.Properties.Resources.previous_icon;
            this.prevSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prevSchedule.Name = "prevSchedule";
            this.prevSchedule.Size = new System.Drawing.Size(123, 22);
            this.prevSchedule.Text = "Previous Schedule";
            this.prevSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.prevSchedule.Click += new System.EventHandler(this.PrevSchedule_Click);
            // 
            // currentSchedule_box
            // 
            this.currentSchedule_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.currentSchedule_box.Name = "currentSchedule_box";
            this.currentSchedule_box.Size = new System.Drawing.Size(100, 25);
            this.currentSchedule_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CurrentSchedule_box_KeyDown);
            // 
            // nextSchedule
            // 
            this.nextSchedule.Image = global::ScheduleBuilder.Properties.Resources.next_icon;
            this.nextSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextSchedule.Name = "nextSchedule";
            this.nextSchedule.Size = new System.Drawing.Size(103, 22);
            this.nextSchedule.Text = "Next Schedule";
            this.nextSchedule.Click += new System.EventHandler(this.NextSchedule_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextSizeLabel
            // 
            this.toolStripTextSizeLabel.Name = "toolStripTextSizeLabel";
            this.toolStripTextSizeLabel.Size = new System.Drawing.Size(54, 22);
            this.toolStripTextSizeLabel.Text = "Text Size:";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(121, 25);
            this.fontSizeComboBox.Text = "Choose Size";
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.FontSizeComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // testsToolStripButton
            // 
            this.testsToolStripButton.Image = global::ScheduleBuilder.Properties.Resources.calendar_icon;
            this.testsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.testsToolStripButton.Name = "testsToolStripButton";
            this.testsToolStripButton.Size = new System.Drawing.Size(103, 22);
            this.testsToolStripButton.Text = "Schedule Tests";
            this.testsToolStripButton.Click += new System.EventHandler(this.TestsToolStripButton_Click);
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.baseTable);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 25);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1184, 536);
            this.BackPanel.TabIndex = 1;
            // 
            // baseTable
            // 
            this.baseTable.ColumnCount = 2;
            this.baseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28632F));
            this.baseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.71368F));
            this.baseTable.Controls.Add(this.hoursTable, 0, 1);
            this.baseTable.Controls.Add(this.daysTable, 1, 0);
            this.baseTable.Controls.Add(this.scheduleTable, 1, 1);
            this.baseTable.Controls.Add(this.cornerPanel, 0, 0);
            this.baseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.baseTable.Location = new System.Drawing.Point(0, 0);
            this.baseTable.Name = "baseTable";
            this.baseTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.baseTable.RowCount = 2;
            this.baseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.baseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.75F));
            this.baseTable.Size = new System.Drawing.Size(1184, 536);
            this.baseTable.TabIndex = 0;
            // 
            // hoursTable
            // 
            this.hoursTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.hoursTable.ColumnCount = 1;
            this.hoursTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hoursTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.hoursTable.Controls.Add(this.hour_label8, 0, 0);
            this.hoursTable.Controls.Add(this.hour_label9, 0, 1);
            this.hoursTable.Controls.Add(this.hour_label10, 0, 2);
            this.hoursTable.Controls.Add(this.hour_label11, 0, 3);
            this.hoursTable.Controls.Add(this.hour_label12, 0, 4);
            this.hoursTable.Controls.Add(this.hour_label13, 0, 5);
            this.hoursTable.Controls.Add(this.hour_label14, 0, 6);
            this.hoursTable.Controls.Add(this.hour_label15, 0, 7);
            this.hoursTable.Controls.Add(this.hour_label16, 0, 8);
            this.hoursTable.Controls.Add(this.hour_label17, 0, 9);
            this.hoursTable.Controls.Add(this.hour_label18, 0, 10);
            this.hoursTable.Controls.Add(this.hour_label19, 0, 11);
            this.hoursTable.Controls.Add(this.hour_label20, 0, 12);
            this.hoursTable.Controls.Add(this.hour_label21, 0, 13);
            this.hoursTable.Controls.Add(this.hour_label22, 0, 14);
            this.hoursTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.hoursTable.Location = new System.Drawing.Point(1018, 36);
            this.hoursTable.Name = "hoursTable";
            this.hoursTable.RowCount = 15;
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.hoursTable.Size = new System.Drawing.Size(163, 497);
            this.hoursTable.TabIndex = 0;
            // 
            // hour_label8
            // 
            this.hour_label8.AutoSize = true;
            this.hour_label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label8.Location = new System.Drawing.Point(4, 1);
            this.hour_label8.Name = "hour_label8";
            this.hour_label8.Size = new System.Drawing.Size(155, 32);
            this.hour_label8.TabIndex = 6;
            this.hour_label8.Text = "08:00";
            this.hour_label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label9
            // 
            this.hour_label9.AutoSize = true;
            this.hour_label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label9.Location = new System.Drawing.Point(4, 34);
            this.hour_label9.Name = "hour_label9";
            this.hour_label9.Size = new System.Drawing.Size(155, 32);
            this.hour_label9.TabIndex = 7;
            this.hour_label9.Text = "09:00";
            this.hour_label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label10
            // 
            this.hour_label10.AutoSize = true;
            this.hour_label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label10.Location = new System.Drawing.Point(4, 67);
            this.hour_label10.Name = "hour_label10";
            this.hour_label10.Size = new System.Drawing.Size(155, 32);
            this.hour_label10.TabIndex = 8;
            this.hour_label10.Text = "10:00";
            this.hour_label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label11
            // 
            this.hour_label11.AutoSize = true;
            this.hour_label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label11.Location = new System.Drawing.Point(4, 100);
            this.hour_label11.Name = "hour_label11";
            this.hour_label11.Size = new System.Drawing.Size(155, 32);
            this.hour_label11.TabIndex = 9;
            this.hour_label11.Text = "11:00";
            this.hour_label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label12
            // 
            this.hour_label12.AutoSize = true;
            this.hour_label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label12.Location = new System.Drawing.Point(4, 133);
            this.hour_label12.Name = "hour_label12";
            this.hour_label12.Size = new System.Drawing.Size(155, 32);
            this.hour_label12.TabIndex = 10;
            this.hour_label12.Text = "12:00";
            this.hour_label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label13
            // 
            this.hour_label13.AutoSize = true;
            this.hour_label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label13.Location = new System.Drawing.Point(4, 166);
            this.hour_label13.Name = "hour_label13";
            this.hour_label13.Size = new System.Drawing.Size(155, 32);
            this.hour_label13.TabIndex = 11;
            this.hour_label13.Text = "13:00";
            this.hour_label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label14
            // 
            this.hour_label14.AutoSize = true;
            this.hour_label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label14.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label14.Location = new System.Drawing.Point(4, 199);
            this.hour_label14.Name = "hour_label14";
            this.hour_label14.Size = new System.Drawing.Size(155, 32);
            this.hour_label14.TabIndex = 12;
            this.hour_label14.Text = "14:00";
            this.hour_label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label15
            // 
            this.hour_label15.AutoSize = true;
            this.hour_label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label15.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label15.Location = new System.Drawing.Point(4, 232);
            this.hour_label15.Name = "hour_label15";
            this.hour_label15.Size = new System.Drawing.Size(155, 32);
            this.hour_label15.TabIndex = 13;
            this.hour_label15.Text = "15:00";
            this.hour_label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label16
            // 
            this.hour_label16.AutoSize = true;
            this.hour_label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label16.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label16.Location = new System.Drawing.Point(4, 265);
            this.hour_label16.Name = "hour_label16";
            this.hour_label16.Size = new System.Drawing.Size(155, 32);
            this.hour_label16.TabIndex = 14;
            this.hour_label16.Text = "16:00";
            this.hour_label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label17
            // 
            this.hour_label17.AutoSize = true;
            this.hour_label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label17.Location = new System.Drawing.Point(4, 298);
            this.hour_label17.Name = "hour_label17";
            this.hour_label17.Size = new System.Drawing.Size(155, 32);
            this.hour_label17.TabIndex = 15;
            this.hour_label17.Text = "17:00";
            this.hour_label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label18
            // 
            this.hour_label18.AutoSize = true;
            this.hour_label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label18.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label18.Location = new System.Drawing.Point(4, 331);
            this.hour_label18.Name = "hour_label18";
            this.hour_label18.Size = new System.Drawing.Size(155, 32);
            this.hour_label18.TabIndex = 16;
            this.hour_label18.Text = "18:00";
            this.hour_label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label19
            // 
            this.hour_label19.AutoSize = true;
            this.hour_label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label19.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label19.Location = new System.Drawing.Point(4, 364);
            this.hour_label19.Name = "hour_label19";
            this.hour_label19.Size = new System.Drawing.Size(155, 32);
            this.hour_label19.TabIndex = 17;
            this.hour_label19.Text = "19:00";
            this.hour_label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label20
            // 
            this.hour_label20.AutoSize = true;
            this.hour_label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label20.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label20.Location = new System.Drawing.Point(4, 397);
            this.hour_label20.Name = "hour_label20";
            this.hour_label20.Size = new System.Drawing.Size(155, 32);
            this.hour_label20.TabIndex = 18;
            this.hour_label20.Text = "20:00";
            this.hour_label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label21
            // 
            this.hour_label21.AutoSize = true;
            this.hour_label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label21.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label21.Location = new System.Drawing.Point(4, 430);
            this.hour_label21.Name = "hour_label21";
            this.hour_label21.Size = new System.Drawing.Size(155, 32);
            this.hour_label21.TabIndex = 19;
            this.hour_label21.Text = "21:00";
            this.hour_label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour_label22
            // 
            this.hour_label22.AutoSize = true;
            this.hour_label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hour_label22.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hour_label22.Location = new System.Drawing.Point(4, 463);
            this.hour_label22.Name = "hour_label22";
            this.hour_label22.Size = new System.Drawing.Size(155, 33);
            this.hour_label22.TabIndex = 20;
            this.hour_label22.Text = "22:00";
            this.hour_label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysTable
            // 
            this.daysTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.daysTable.ColumnCount = 6;
            this.daysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.daysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.daysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.daysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.daysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.daysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.daysTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.daysTable.Controls.Add(this.sunday_label, 0, 0);
            this.daysTable.Controls.Add(this.monday_label, 1, 0);
            this.daysTable.Controls.Add(this.tuesday_label, 2, 0);
            this.daysTable.Controls.Add(this.wednesday_label, 3, 0);
            this.daysTable.Controls.Add(this.thursday_label, 4, 0);
            this.daysTable.Controls.Add(this.friday_label, 5, 0);
            this.daysTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daysTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.daysTable.Location = new System.Drawing.Point(3, 3);
            this.daysTable.Name = "daysTable";
            this.daysTable.RowCount = 1;
            this.daysTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.daysTable.Size = new System.Drawing.Size(1009, 27);
            this.daysTable.TabIndex = 0;
            // 
            // sunday_label
            // 
            this.sunday_label.AutoSize = true;
            this.sunday_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sunday_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sunday_label.Location = new System.Drawing.Point(845, 1);
            this.sunday_label.Name = "sunday_label";
            this.sunday_label.Size = new System.Drawing.Size(160, 25);
            this.sunday_label.TabIndex = 0;
            this.sunday_label.Text = "יום א\'";
            this.sunday_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monday_label
            // 
            this.monday_label.AutoSize = true;
            this.monday_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monday_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.monday_label.Location = new System.Drawing.Point(677, 1);
            this.monday_label.Name = "monday_label";
            this.monday_label.Size = new System.Drawing.Size(161, 25);
            this.monday_label.TabIndex = 1;
            this.monday_label.Text = "יום ב\'";
            this.monday_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tuesday_label
            // 
            this.tuesday_label.AutoSize = true;
            this.tuesday_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuesday_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tuesday_label.Location = new System.Drawing.Point(509, 1);
            this.tuesday_label.Name = "tuesday_label";
            this.tuesday_label.Size = new System.Drawing.Size(161, 25);
            this.tuesday_label.TabIndex = 2;
            this.tuesday_label.Text = "יום ג\'";
            this.tuesday_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wednesday_label
            // 
            this.wednesday_label.AutoSize = true;
            this.wednesday_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wednesday_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.wednesday_label.Location = new System.Drawing.Point(341, 1);
            this.wednesday_label.Name = "wednesday_label";
            this.wednesday_label.Size = new System.Drawing.Size(161, 25);
            this.wednesday_label.TabIndex = 3;
            this.wednesday_label.Text = "יום ד\'";
            this.wednesday_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thursday_label
            // 
            this.thursday_label.AutoSize = true;
            this.thursday_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thursday_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.thursday_label.Location = new System.Drawing.Point(173, 1);
            this.thursday_label.Name = "thursday_label";
            this.thursday_label.Size = new System.Drawing.Size(161, 25);
            this.thursday_label.TabIndex = 4;
            this.thursday_label.Text = "יום ה\'";
            this.thursday_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friday_label
            // 
            this.friday_label.AutoSize = true;
            this.friday_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friday_label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friday_label.Location = new System.Drawing.Point(4, 1);
            this.friday_label.Name = "friday_label";
            this.friday_label.Size = new System.Drawing.Size(162, 25);
            this.friday_label.TabIndex = 5;
            this.friday_label.Text = "יום ו\'";
            this.friday_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scheduleTable
            // 
            this.scheduleTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.scheduleTable.ColumnCount = 6;
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.scheduleTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleTable.Location = new System.Drawing.Point(3, 36);
            this.scheduleTable.Name = "scheduleTable";
            this.scheduleTable.RowCount = 15;
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.scheduleTable.Size = new System.Drawing.Size(1009, 497);
            this.scheduleTable.TabIndex = 1;
            this.scheduleTable.Paint += new System.Windows.Forms.PaintEventHandler(this.ScheduleTable_Paint);
            // 
            // cornerPanel
            // 
            this.cornerPanel.Controls.Add(this.logoPicture);
            this.cornerPanel.Controls.Add(this.scheduleNumber_label);
            this.cornerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cornerPanel.Location = new System.Drawing.Point(1018, 3);
            this.cornerPanel.Name = "cornerPanel";
            this.cornerPanel.Size = new System.Drawing.Size(163, 27);
            this.cornerPanel.TabIndex = 2;
            // 
            // logoPicture
            // 
            this.logoPicture.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoPicture.Image = global::ScheduleBuilder.Properties.Resources.icon_512;
            this.logoPicture.Location = new System.Drawing.Point(75, 0);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(88, 27);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 1;
            this.logoPicture.TabStop = false;
            // 
            // scheduleNumber_label
            // 
            this.scheduleNumber_label.AutoEllipsis = true;
            this.scheduleNumber_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.scheduleNumber_label.Location = new System.Drawing.Point(0, 0);
            this.scheduleNumber_label.Name = "scheduleNumber_label";
            this.scheduleNumber_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scheduleNumber_label.Size = new System.Drawing.Size(78, 27);
            this.scheduleNumber_label.TabIndex = 0;
            this.scheduleNumber_label.Text = "Schedule 0 of 0";
            this.scheduleNumber_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.ToolStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedules Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewSchedule_FormClosed);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.BackPanel.ResumeLayout(false);
            this.baseTable.ResumeLayout(false);
            this.hoursTable.ResumeLayout(false);
            this.hoursTable.PerformLayout();
            this.daysTable.ResumeLayout(false);
            this.daysTable.PerformLayout();
            this.cornerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton filterToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton prevSchedule;
        private System.Windows.Forms.ToolStripTextBox currentSchedule_box;
        private System.Windows.Forms.ToolStripButton nextSchedule;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Label hour_label9;
        private System.Windows.Forms.Label hour_label8;
        private System.Windows.Forms.Label friday_label;
        private System.Windows.Forms.Label thursday_label;
        private System.Windows.Forms.Label wednesday_label;
        private System.Windows.Forms.Label tuesday_label;
        private System.Windows.Forms.Label monday_label;
        private System.Windows.Forms.Label sunday_label;
        private System.Windows.Forms.Label hour_label17;
        private System.Windows.Forms.Label hour_label16;
        private System.Windows.Forms.Label hour_label15;
        private System.Windows.Forms.Label hour_label14;
        private System.Windows.Forms.Label hour_label13;
        private System.Windows.Forms.Label hour_label12;
        private System.Windows.Forms.Label hour_label11;
        private System.Windows.Forms.Label hour_label10;
        private System.Windows.Forms.Label hour_label22;
        private System.Windows.Forms.Label hour_label21;
        private System.Windows.Forms.Label hour_label20;
        private System.Windows.Forms.Label hour_label19;
        private System.Windows.Forms.Label hour_label18;
        private System.Windows.Forms.TableLayoutPanel baseTable;
        private System.Windows.Forms.TableLayoutPanel daysTable;
        private System.Windows.Forms.TableLayoutPanel hoursTable;
        private System.Windows.Forms.TableLayoutPanel scheduleTable;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.Panel cornerPanel;
        private System.Windows.Forms.Label scheduleNumber_label;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton testsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripTextSizeLabel;
    }
}