namespace AutoMouse
{
    partial class AutoMouseMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoMouseMain));
            this.cbMouseType = new System.Windows.Forms.ComboBox();
            this.cbMouseClick = new System.Windows.Forms.ComboBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnRecordReset = new System.Windows.Forms.Button();
            this.groupBoxRepeatInterval = new System.Windows.Forms.GroupBox();
            this.repeatIntervalTenthOfSecond = new System.Windows.Forms.NumericUpDown();
            this.repeatIntervalSecond = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.repeatIntervalMinute = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.tbClickPointCount = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioTimes = new System.Windows.Forms.RadioButton();
            this.radioInfinite = new System.Windows.Forms.RadioButton();
            this.tbClicks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStartKey1 = new System.Windows.Forms.ComboBox();
            this.cbStartKey2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClickInterval = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.clickIntervalTenthOfSecond = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clickIntervalSecond = new System.Windows.Forms.NumericUpDown();
            this.clickIntervalMinute = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxRandomMin = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.randomMinimumSecond = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.randomMinimumTenthOfSecond = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRandomMax = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.randomMaximumSecond = new System.Windows.Forms.NumericUpDown();
            this.randomMaximumTenthOfSecond = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.chkBoxUseRandom = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStripBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbSettings.SuspendLayout();
            this.groupBoxRepeatInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatIntervalTenthOfSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatIntervalSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatIntervalMinute)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxClickInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickIntervalTenthOfSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickIntervalSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickIntervalMinute)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxRandomMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomMinimumSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMinimumTenthOfSecond)).BeginInit();
            this.groupBoxRandomMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaximumSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaximumTenthOfSecond)).BeginInit();
            this.statusStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMouseType
            // 
            this.cbMouseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMouseType.FormattingEnabled = true;
            this.cbMouseType.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cbMouseType.Location = new System.Drawing.Point(59, 36);
            this.cbMouseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMouseType.Name = "cbMouseType";
            this.cbMouseType.Size = new System.Drawing.Size(60, 23);
            this.cbMouseType.TabIndex = 0;
            // 
            // cbMouseClick
            // 
            this.cbMouseClick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMouseClick.FormattingEnabled = true;
            this.cbMouseClick.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.cbMouseClick.Location = new System.Drawing.Point(59, 83);
            this.cbMouseClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMouseClick.Name = "cbMouseClick";
            this.cbMouseClick.Size = new System.Drawing.Size(60, 23);
            this.cbMouseClick.TabIndex = 1;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btnRecordReset);
            this.gbSettings.Controls.Add(this.groupBoxRepeatInterval);
            this.gbSettings.Controls.Add(this.btnStart);
            this.gbSettings.Controls.Add(this.btnRecord);
            this.gbSettings.Controls.Add(this.tbClickPointCount);
            this.gbSettings.Controls.Add(this.groupBox6);
            this.gbSettings.Controls.Add(this.groupBox5);
            this.gbSettings.Controls.Add(this.groupBox1);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.groupBoxClickInterval);
            this.gbSettings.Controls.Add(this.groupBox2);
            this.gbSettings.Location = new System.Drawing.Point(14, 14);
            this.gbSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSettings.Size = new System.Drawing.Size(580, 292);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnRecordReset
            // 
            this.btnRecordReset.Location = new System.Drawing.Point(381, 253);
            this.btnRecordReset.Name = "btnRecordReset";
            this.btnRecordReset.Size = new System.Drawing.Size(116, 33);
            this.btnRecordReset.TabIndex = 6;
            this.btnRecordReset.Text = "Record Reset";
            this.btnRecordReset.UseVisualStyleBackColor = true;
            this.btnRecordReset.Click += new System.EventHandler(this.btnRecordReset_Click);
            // 
            // groupBoxRepeatInterval
            // 
            this.groupBoxRepeatInterval.Controls.Add(this.repeatIntervalTenthOfSecond);
            this.groupBoxRepeatInterval.Controls.Add(this.repeatIntervalSecond);
            this.groupBoxRepeatInterval.Controls.Add(this.label13);
            this.groupBoxRepeatInterval.Controls.Add(this.label6);
            this.groupBoxRepeatInterval.Controls.Add(this.repeatIntervalMinute);
            this.groupBoxRepeatInterval.Controls.Add(this.label2);
            this.groupBoxRepeatInterval.Location = new System.Drawing.Point(361, 155);
            this.groupBoxRepeatInterval.Name = "groupBoxRepeatInterval";
            this.groupBoxRepeatInterval.Size = new System.Drawing.Size(213, 92);
            this.groupBoxRepeatInterval.TabIndex = 7;
            this.groupBoxRepeatInterval.TabStop = false;
            this.groupBoxRepeatInterval.Text = "Repeat Interval";
            // 
            // repeatIntervalTenthOfSecond
            // 
            this.repeatIntervalTenthOfSecond.Location = new System.Drawing.Point(130, 46);
            this.repeatIntervalTenthOfSecond.Name = "repeatIntervalTenthOfSecond";
            this.repeatIntervalTenthOfSecond.Size = new System.Drawing.Size(55, 25);
            this.repeatIntervalTenthOfSecond.TabIndex = 12;
            // 
            // repeatIntervalSecond
            // 
            this.repeatIntervalSecond.Location = new System.Drawing.Point(68, 46);
            this.repeatIntervalSecond.Name = "repeatIntervalSecond";
            this.repeatIntervalSecond.Size = new System.Drawing.Size(56, 25);
            this.repeatIntervalSecond.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "1/10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seconds";
            // 
            // repeatIntervalMinute
            // 
            this.repeatIntervalMinute.Location = new System.Drawing.Point(6, 46);
            this.repeatIntervalMinute.Name = "repeatIntervalMinute";
            this.repeatIntervalMinute.Size = new System.Drawing.Size(56, 25);
            this.repeatIntervalMinute.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Minutes";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(7, 253);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 33);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(503, 253);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(71, 33);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // tbClickPointCount
            // 
            this.tbClickPointCount.Location = new System.Drawing.Point(297, 259);
            this.tbClickPointCount.Name = "tbClickPointCount";
            this.tbClickPointCount.ReadOnly = true;
            this.tbClickPointCount.Size = new System.Drawing.Size(49, 25);
            this.tbClickPointCount.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioTimes);
            this.groupBox6.Controls.Add(this.radioInfinite);
            this.groupBox6.Controls.Add(this.tbClicks);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(7, 155);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(135, 92);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Repeat";
            // 
            // radioTimes
            // 
            this.radioTimes.AutoSize = true;
            this.radioTimes.Location = new System.Drawing.Point(6, 19);
            this.radioTimes.Name = "radioTimes";
            this.radioTimes.Size = new System.Drawing.Size(62, 19);
            this.radioTimes.TabIndex = 28;
            this.radioTimes.TabStop = true;
            this.radioTimes.Text = "times";
            this.radioTimes.UseVisualStyleBackColor = true;
            this.radioTimes.CheckedChanged += new System.EventHandler(this.radioTimes_CheckedChanged);
            // 
            // radioInfinite
            // 
            this.radioInfinite.AutoSize = true;
            this.radioInfinite.Location = new System.Drawing.Point(6, 66);
            this.radioInfinite.Name = "radioInfinite";
            this.radioInfinite.Size = new System.Drawing.Size(69, 19);
            this.radioInfinite.TabIndex = 27;
            this.radioInfinite.TabStop = true;
            this.radioInfinite.Text = "Infinite";
            this.radioInfinite.UseVisualStyleBackColor = true;
            this.radioInfinite.CheckedChanged += new System.EventHandler(this.radioInfinite_CheckedChanged);
            // 
            // tbClicks
            // 
            this.tbClicks.Location = new System.Drawing.Point(74, 17);
            this.tbClicks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClicks.Name = "tbClicks";
            this.tbClicks.Size = new System.Drawing.Size(45, 25);
            this.tbClicks.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Clicks";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbMouseType);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cbMouseClick);
            this.groupBox5.Location = new System.Drawing.Point(7, 24);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(135, 125);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mouse Setting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mouse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Click";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStartKey1);
            this.groupBox1.Controls.Add(this.cbStartKey2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(461, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(113, 125);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stop Hotkey";
            // 
            // cbStartKey1
            // 
            this.cbStartKey1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartKey1.FormattingEnabled = true;
            this.cbStartKey1.Items.AddRange(new object[] {
            "None",
            "Alt",
            "Ctrl"});
            this.cbStartKey1.Location = new System.Drawing.Point(18, 35);
            this.cbStartKey1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStartKey1.Name = "cbStartKey1";
            this.cbStartKey1.Size = new System.Drawing.Size(79, 23);
            this.cbStartKey1.TabIndex = 7;
            this.cbStartKey1.TabStop = false;
            this.cbStartKey1.SelectedIndexChanged += new System.EventHandler(this.cbStartKey1_SelectedIndexChanged);
            // 
            // cbStartKey2
            // 
            this.cbStartKey2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartKey2.FormattingEnabled = true;
            this.cbStartKey2.Items.AddRange(new object[] {
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbStartKey2.Location = new System.Drawing.Point(18, 84);
            this.cbStartKey2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStartKey2.Name = "cbStartKey2";
            this.cbStartKey2.Size = new System.Drawing.Size(79, 23);
            this.cbStartKey2.TabIndex = 8;
            this.cbStartKey2.TabStop = false;
            this.cbStartKey2.SelectedIndexChanged += new System.EventHandler(this.cbStartKey2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Records";
            // 
            // groupBoxClickInterval
            // 
            this.groupBoxClickInterval.Controls.Add(this.label15);
            this.groupBoxClickInterval.Controls.Add(this.clickIntervalTenthOfSecond);
            this.groupBoxClickInterval.Controls.Add(this.label7);
            this.groupBoxClickInterval.Controls.Add(this.label8);
            this.groupBoxClickInterval.Controls.Add(this.clickIntervalSecond);
            this.groupBoxClickInterval.Controls.Add(this.clickIntervalMinute);
            this.groupBoxClickInterval.Location = new System.Drawing.Point(148, 155);
            this.groupBoxClickInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxClickInterval.Name = "groupBoxClickInterval";
            this.groupBoxClickInterval.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxClickInterval.Size = new System.Drawing.Size(207, 92);
            this.groupBoxClickInterval.TabIndex = 32;
            this.groupBoxClickInterval.TabStop = false;
            this.groupBoxClickInterval.Text = "Click Interval";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(139, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 37;
            this.label15.Text = "1/10";
            // 
            // clickIntervalTenthOfSecond
            // 
            this.clickIntervalTenthOfSecond.Location = new System.Drawing.Point(133, 46);
            this.clickIntervalTenthOfSecond.Name = "clickIntervalTenthOfSecond";
            this.clickIntervalTenthOfSecond.Size = new System.Drawing.Size(54, 25);
            this.clickIntervalTenthOfSecond.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Seconds";
            // 
            // clickIntervalSecond
            // 
            this.clickIntervalSecond.Location = new System.Drawing.Point(70, 46);
            this.clickIntervalSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clickIntervalSecond.Name = "clickIntervalSecond";
            this.clickIntervalSecond.Size = new System.Drawing.Size(57, 25);
            this.clickIntervalSecond.TabIndex = 31;
            // 
            // clickIntervalMinute
            // 
            this.clickIntervalMinute.Location = new System.Drawing.Point(9, 46);
            this.clickIntervalMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clickIntervalMinute.Name = "clickIntervalMinute";
            this.clickIntervalMinute.Size = new System.Drawing.Size(55, 25);
            this.clickIntervalMinute.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxRandomMin);
            this.groupBox2.Controls.Add(this.groupBoxRandomMax);
            this.groupBox2.Controls.Add(this.chkBoxUseRandom);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(148, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(307, 127);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Time(Sec.)";
            // 
            // groupBoxRandomMin
            // 
            this.groupBoxRandomMin.Controls.Add(this.label9);
            this.groupBoxRandomMin.Controls.Add(this.randomMinimumSecond);
            this.groupBoxRandomMin.Controls.Add(this.label5);
            this.groupBoxRandomMin.Controls.Add(this.randomMinimumTenthOfSecond);
            this.groupBoxRandomMin.Location = new System.Drawing.Point(9, 46);
            this.groupBoxRandomMin.Name = "groupBoxRandomMin";
            this.groupBoxRandomMin.Size = new System.Drawing.Size(118, 75);
            this.groupBoxRandomMin.TabIndex = 4;
            this.groupBoxRandomMin.TabStop = false;
            this.groupBoxRandomMin.Text = "Mininum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "1/10";
            // 
            // randomMinimumSecond
            // 
            this.randomMinimumSecond.Location = new System.Drawing.Point(6, 40);
            this.randomMinimumSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.randomMinimumSecond.Name = "randomMinimumSecond";
            this.randomMinimumSecond.Size = new System.Drawing.Size(50, 25);
            this.randomMinimumSecond.TabIndex = 32;
            this.randomMinimumSecond.ValueChanged += new System.EventHandler(this.randomMinimumSecond_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sec";
            // 
            // randomMinimumTenthOfSecond
            // 
            this.randomMinimumTenthOfSecond.Location = new System.Drawing.Point(62, 40);
            this.randomMinimumTenthOfSecond.Name = "randomMinimumTenthOfSecond";
            this.randomMinimumTenthOfSecond.Size = new System.Drawing.Size(51, 25);
            this.randomMinimumTenthOfSecond.TabIndex = 37;
            this.randomMinimumTenthOfSecond.ValueChanged += new System.EventHandler(this.randomMinimumTenthOfSecond_ValueChanged);
            // 
            // groupBoxRandomMax
            // 
            this.groupBoxRandomMax.Controls.Add(this.label16);
            this.groupBoxRandomMax.Controls.Add(this.randomMaximumSecond);
            this.groupBoxRandomMax.Controls.Add(this.randomMaximumTenthOfSecond);
            this.groupBoxRandomMax.Controls.Add(this.label14);
            this.groupBoxRandomMax.Location = new System.Drawing.Point(151, 46);
            this.groupBoxRandomMax.Name = "groupBoxRandomMax";
            this.groupBoxRandomMax.Size = new System.Drawing.Size(117, 75);
            this.groupBoxRandomMax.TabIndex = 36;
            this.groupBoxRandomMax.TabStop = false;
            this.groupBoxRandomMax.Text = "Maximum";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(65, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "1/10";
            // 
            // randomMaximumSecond
            // 
            this.randomMaximumSecond.Location = new System.Drawing.Point(6, 40);
            this.randomMaximumSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.randomMaximumSecond.Name = "randomMaximumSecond";
            this.randomMaximumSecond.Size = new System.Drawing.Size(47, 25);
            this.randomMaximumSecond.TabIndex = 33;
            // 
            // randomMaximumTenthOfSecond
            // 
            this.randomMaximumTenthOfSecond.Location = new System.Drawing.Point(59, 40);
            this.randomMaximumTenthOfSecond.Name = "randomMaximumTenthOfSecond";
            this.randomMaximumTenthOfSecond.Size = new System.Drawing.Size(50, 25);
            this.randomMaximumTenthOfSecond.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Sec";
            // 
            // chkBoxUseRandom
            // 
            this.chkBoxUseRandom.AutoSize = true;
            this.chkBoxUseRandom.Location = new System.Drawing.Point(9, 23);
            this.chkBoxUseRandom.Name = "chkBoxUseRandom";
            this.chkBoxUseRandom.Size = new System.Drawing.Size(112, 19);
            this.chkBoxUseRandom.TabIndex = 36;
            this.chkBoxUseRandom.Text = "use Random";
            this.chkBoxUseRandom.UseVisualStyleBackColor = true;
            this.chkBoxUseRandom.CheckedChanged += new System.EventHandler(this.chkBoxUseRandom_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "~";
            // 
            // statusStripBar
            // 
            this.statusStripBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusStatus});
            this.statusStripBar.Location = new System.Drawing.Point(0, 313);
            this.statusStripBar.Name = "statusStripBar";
            this.statusStripBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripBar.Size = new System.Drawing.Size(611, 26);
            this.statusStripBar.TabIndex = 3;
            this.statusStripBar.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(48, 20);
            this.toolStripStatusLabel.Text = "status";
            // 
            // toolStripStatusStatus
            // 
            this.toolStripStatusStatus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripStatusStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusStatus.Name = "toolStripStatusStatus";
            this.toolStripStatusStatus.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusStatus.Text = "(stop)";
            // 
            // AutoMouseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 339);
            this.Controls.Add(this.statusStripBar);
            this.Controls.Add(this.gbSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AutoMouseMain";
            this.Opacity = 0.9D;
            this.Text = "AutoMouse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutoMouseMain_FormClosed);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.groupBoxRepeatInterval.ResumeLayout(false);
            this.groupBoxRepeatInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatIntervalTenthOfSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatIntervalSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatIntervalMinute)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxClickInterval.ResumeLayout(false);
            this.groupBoxClickInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickIntervalTenthOfSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickIntervalSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickIntervalMinute)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxRandomMin.ResumeLayout(false);
            this.groupBoxRandomMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomMinimumSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMinimumTenthOfSecond)).EndInit();
            this.groupBoxRandomMax.ResumeLayout(false);
            this.groupBoxRandomMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaximumSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomMaximumTenthOfSecond)).EndInit();
            this.statusStripBar.ResumeLayout(false);
            this.statusStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMouseType;
        private System.Windows.Forms.ComboBox cbMouseClick;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.TextBox tbClicks;
        private System.Windows.Forms.ComboBox cbStartKey1;
        private System.Windows.Forms.ComboBox cbStartKey2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown clickIntervalMinute;
        private System.Windows.Forms.NumericUpDown clickIntervalSecond;
        private System.Windows.Forms.NumericUpDown randomMinimumSecond;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown randomMaximumSecond;
        private System.Windows.Forms.GroupBox groupBoxClickInterval;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.StatusStrip statusStripBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClickPointCount;
        private System.Windows.Forms.Button btnRecordReset;
        private System.Windows.Forms.RadioButton radioTimes;
        private System.Windows.Forms.RadioButton radioInfinite;
        private System.Windows.Forms.GroupBox groupBoxRepeatInterval;
        private System.Windows.Forms.NumericUpDown repeatIntervalMinute;
        private System.Windows.Forms.NumericUpDown repeatIntervalSecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBoxUseRandom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusStatus;
        private System.Windows.Forms.NumericUpDown repeatIntervalTenthOfSecond;
        private System.Windows.Forms.NumericUpDown clickIntervalTenthOfSecond;
        private System.Windows.Forms.NumericUpDown randomMaximumTenthOfSecond;
        private System.Windows.Forms.NumericUpDown randomMinimumTenthOfSecond;
        private System.Windows.Forms.GroupBox groupBoxRandomMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxRandomMax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

