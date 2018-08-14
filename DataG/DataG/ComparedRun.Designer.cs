﻿namespace DataG
{
    partial class ComparedRun
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.activatePanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.allSelectedCheckBox = new System.Windows.Forms.CheckBox();
            this.sensorCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileLoadingButton = new System.Windows.Forms.Button();
            this.sensorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.GPSPanel = new System.Windows.Forms.Panel();
            this.ConfigureButton = new System.Windows.Forms.Button();
            this.GPSGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton_Accelerate = new System.Windows.Forms.RadioButton();
            this.radioButton_Speed = new System.Windows.Forms.RadioButton();
            this.radioButton_Normal = new System.Windows.Forms.RadioButton();
            this.YPanel = new System.Windows.Forms.Panel();
            this.settingButton = new System.Windows.Forms.Button();
            this.allSelectedCheckBox2 = new System.Windows.Forms.CheckBox();
            this.sensorCheckedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.activatePanel.SuspendLayout();
            this.displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorChart)).BeginInit();
            this.GPSGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // activatePanel
            // 
            this.activatePanel.BackColor = System.Drawing.SystemColors.Info;
            this.activatePanel.Controls.Add(this.resetButton);
            this.activatePanel.Controls.Add(this.buttonStop);
            this.activatePanel.Controls.Add(this.buttonPlay);
            this.activatePanel.Location = new System.Drawing.Point(1359, 744);
            this.activatePanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.activatePanel.Name = "activatePanel";
            this.activatePanel.Size = new System.Drawing.Size(443, 198);
            this.activatePanel.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetButton.Location = new System.Drawing.Point(51, 111);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(348, 51);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStop.Location = new System.Drawing.Point(259, 42);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(140, 49);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPlay.Location = new System.Drawing.Point(51, 42);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(132, 49);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // displayPanel
            // 
            this.displayPanel.BackColor = System.Drawing.SystemColors.Info;
            this.displayPanel.Controls.Add(this.allSelectedCheckBox2);
            this.displayPanel.Controls.Add(this.sensorCheckedListBox2);
            this.displayPanel.Controls.Add(this.allSelectedCheckBox);
            this.displayPanel.Controls.Add(this.sensorCheckedListBox);
            this.displayPanel.Controls.Add(this.label4);
            this.displayPanel.Location = new System.Drawing.Point(16, 744);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(605, 199);
            this.displayPanel.TabIndex = 4;
            // 
            // allSelectedCheckBox
            // 
            this.allSelectedCheckBox.AutoSize = true;
            this.allSelectedCheckBox.Checked = true;
            this.allSelectedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allSelectedCheckBox.Location = new System.Drawing.Point(16, 44);
            this.allSelectedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allSelectedCheckBox.Name = "allSelectedCheckBox";
            this.allSelectedCheckBox.Size = new System.Drawing.Size(53, 19);
            this.allSelectedCheckBox.TabIndex = 2;
            this.allSelectedCheckBox.Text = "All";
            this.allSelectedCheckBox.UseVisualStyleBackColor = true;
            this.allSelectedCheckBox.CheckedChanged += new System.EventHandler(this.allSelectedCheckBox_CheckedChanged);
            // 
            // sensorCheckedListBox
            // 
            this.sensorCheckedListBox.CheckOnClick = true;
            this.sensorCheckedListBox.FormattingEnabled = true;
            this.sensorCheckedListBox.Location = new System.Drawing.Point(13, 70);
            this.sensorCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sensorCheckedListBox.Name = "sensorCheckedListBox";
            this.sensorCheckedListBox.Size = new System.Drawing.Size(275, 104);
            this.sensorCheckedListBox.TabIndex = 1;
            this.sensorCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.sensorCheckedListBox_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(222, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Display";
            // 
            // fileLoadingButton
            // 
            this.fileLoadingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileLoadingButton.Location = new System.Drawing.Point(1068, 744);
            this.fileLoadingButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.fileLoadingButton.Name = "fileLoadingButton";
            this.fileLoadingButton.Size = new System.Drawing.Size(139, 55);
            this.fileLoadingButton.TabIndex = 6;
            this.fileLoadingButton.Text = "Load CSV...";
            this.fileLoadingButton.UseVisualStyleBackColor = true;
            this.fileLoadingButton.Click += new System.EventHandler(this.fileLoadingButton_Click);
            // 
            // sensorChart
            // 
            chartArea1.AxisX.LabelStyle.Format = "N3";
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 81.35392F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.sensorChart.ChartAreas.Add(chartArea1);
            this.sensorChart.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Name = "Legend1";
            this.sensorChart.Legends.Add(legend1);
            this.sensorChart.Location = new System.Drawing.Point(16, 11);
            this.sensorChart.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.sensorChart.Name = "sensorChart";
            this.sensorChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sensorChart.Size = new System.Drawing.Size(1269, 718);
            this.sensorChart.TabIndex = 8;
            this.sensorChart.TabStop = false;
            this.sensorChart.Text = "chart1";
            this.sensorChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sensorChart_MouseClick);
            this.sensorChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sensorChart_MouseDown);
            this.sensorChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sensorChart_MouseMove);
            this.sensorChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sensorChart_MouseUp);
            // 
            // chartTimer
            // 
            this.chartTimer.Interval = 1;
            this.chartTimer.Tick += new System.EventHandler(this.chartTimer_Tick);
            // 
            // GPSPanel
            // 
            this.GPSPanel.BackColor = System.Drawing.SystemColors.Info;
            this.GPSPanel.Location = new System.Drawing.Point(1296, 11);
            this.GPSPanel.Margin = new System.Windows.Forms.Padding(4);
            this.GPSPanel.Name = "GPSPanel";
            this.GPSPanel.Size = new System.Drawing.Size(506, 718);
            this.GPSPanel.TabIndex = 9;
            this.GPSPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GPSPanel_Paint);
            this.GPSPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GPSPanel_MouseClick);
            this.GPSPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GPSPanel_MouseDown);
            this.GPSPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GPSPanel_MouseMove);
            this.GPSPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GPSPanel_MouseUp);
            // 
            // ConfigureButton
            // 
            this.ConfigureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfigureButton.Location = new System.Drawing.Point(1069, 891);
            this.ConfigureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConfigureButton.Name = "ConfigureButton";
            this.ConfigureButton.Size = new System.Drawing.Size(139, 52);
            this.ConfigureButton.TabIndex = 10;
            this.ConfigureButton.Text = "Configuration";
            this.ConfigureButton.UseVisualStyleBackColor = true;
            this.ConfigureButton.Click += new System.EventHandler(this.ConfigureButton_Click);
            // 
            // GPSGroupBox
            // 
            this.GPSGroupBox.Controls.Add(this.radioButton_Accelerate);
            this.GPSGroupBox.Controls.Add(this.radioButton_Speed);
            this.GPSGroupBox.Controls.Add(this.radioButton_Normal);
            this.GPSGroupBox.Location = new System.Drawing.Point(1214, 744);
            this.GPSGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.GPSGroupBox.Name = "GPSGroupBox";
            this.GPSGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.GPSGroupBox.Size = new System.Drawing.Size(137, 198);
            this.GPSGroupBox.TabIndex = 12;
            this.GPSGroupBox.TabStop = false;
            this.GPSGroupBox.Text = "GPS";
            // 
            // radioButton_Accelerate
            // 
            this.radioButton_Accelerate.AutoSize = true;
            this.radioButton_Accelerate.Location = new System.Drawing.Point(25, 125);
            this.radioButton_Accelerate.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Accelerate.Name = "radioButton_Accelerate";
            this.radioButton_Accelerate.Size = new System.Drawing.Size(108, 19);
            this.radioButton_Accelerate.TabIndex = 2;
            this.radioButton_Accelerate.TabStop = true;
            this.radioButton_Accelerate.Text = "Accelerate";
            this.radioButton_Accelerate.UseVisualStyleBackColor = true;
            this.radioButton_Accelerate.CheckedChanged += new System.EventHandler(this.radioButton_Accelerate_CheckedChanged);
            // 
            // radioButton_Speed
            // 
            this.radioButton_Speed.AutoSize = true;
            this.radioButton_Speed.Location = new System.Drawing.Point(25, 78);
            this.radioButton_Speed.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Speed.Name = "radioButton_Speed";
            this.radioButton_Speed.Size = new System.Drawing.Size(68, 19);
            this.radioButton_Speed.TabIndex = 1;
            this.radioButton_Speed.TabStop = true;
            this.radioButton_Speed.Text = "Speed";
            this.radioButton_Speed.UseVisualStyleBackColor = true;
            this.radioButton_Speed.CheckedChanged += new System.EventHandler(this.radioButton_Speed_CheckedChanged);
            // 
            // radioButton_Normal
            // 
            this.radioButton_Normal.AutoSize = true;
            this.radioButton_Normal.Checked = true;
            this.radioButton_Normal.Location = new System.Drawing.Point(25, 25);
            this.radioButton_Normal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_Normal.Name = "radioButton_Normal";
            this.radioButton_Normal.Size = new System.Drawing.Size(76, 19);
            this.radioButton_Normal.TabIndex = 0;
            this.radioButton_Normal.TabStop = true;
            this.radioButton_Normal.Text = "Normal";
            this.radioButton_Normal.UseVisualStyleBackColor = true;
            this.radioButton_Normal.CheckedChanged += new System.EventHandler(this.radioButton_Normal_CheckedChanged);
            // 
            // YPanel
            // 
            this.YPanel.AutoScroll = true;
            this.YPanel.BackColor = System.Drawing.SystemColors.Info;
            this.YPanel.Location = new System.Drawing.Point(628, 744);
            this.YPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YPanel.Name = "YPanel";
            this.YPanel.Size = new System.Drawing.Size(432, 199);
            this.YPanel.TabIndex = 13;
            // 
            // settingButton
            // 
            this.settingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.settingButton.Location = new System.Drawing.Point(1068, 819);
            this.settingButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(137, 52);
            this.settingButton.TabIndex = 14;
            this.settingButton.Text = "Load Settings";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // allSelectedCheckBox2
            // 
            this.allSelectedCheckBox2.AutoSize = true;
            this.allSelectedCheckBox2.Checked = true;
            this.allSelectedCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allSelectedCheckBox2.Location = new System.Drawing.Point(320, 44);
            this.allSelectedCheckBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allSelectedCheckBox2.Name = "allSelectedCheckBox2";
            this.allSelectedCheckBox2.Size = new System.Drawing.Size(53, 19);
            this.allSelectedCheckBox2.TabIndex = 4;
            this.allSelectedCheckBox2.Text = "All";
            this.allSelectedCheckBox2.UseVisualStyleBackColor = true;
            // 
            // sensorCheckedListBox2
            // 
            this.sensorCheckedListBox2.CheckOnClick = true;
            this.sensorCheckedListBox2.FormattingEnabled = true;
            this.sensorCheckedListBox2.Location = new System.Drawing.Point(317, 70);
            this.sensorCheckedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sensorCheckedListBox2.Name = "sensorCheckedListBox2";
            this.sensorCheckedListBox2.Size = new System.Drawing.Size(275, 104);
            this.sensorCheckedListBox2.TabIndex = 3;
            // 
            // ComparedRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1817, 950);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.YPanel);
            this.Controls.Add(this.GPSGroupBox);
            this.Controls.Add(this.ConfigureButton);
            this.Controls.Add(this.GPSPanel);
            this.Controls.Add(this.sensorChart);
            this.Controls.Add(this.fileLoadingButton);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.activatePanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ComparedRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Compared Run";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.activatePanel.ResumeLayout(false);
            this.displayPanel.ResumeLayout(false);
            this.displayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorChart)).EndInit();
            this.GPSGroupBox.ResumeLayout(false);
            this.GPSGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel activatePanel;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fileLoadingButton;
        public System.Windows.Forms.DataVisualization.Charting.Chart sensorChart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel GPSPanel;
        private System.Windows.Forms.CheckedListBox sensorCheckedListBox;
        private System.Windows.Forms.CheckBox allSelectedCheckBox;
        private System.Windows.Forms.Button ConfigureButton;
        private System.Windows.Forms.GroupBox GPSGroupBox;
        private System.Windows.Forms.RadioButton radioButton_Accelerate;
        private System.Windows.Forms.RadioButton radioButton_Speed;
        private System.Windows.Forms.RadioButton radioButton_Normal;
        private System.Windows.Forms.Panel YPanel;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.CheckBox allSelectedCheckBox2;
        private System.Windows.Forms.CheckedListBox sensorCheckedListBox2;
    }
}
