﻿namespace IntervalTimer
{
    partial class IntervalTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblRep = new System.Windows.Forms.Label();
            this.nudMins = new System.Windows.Forms.NumericUpDown();
            this.nudSecs = new System.Windows.Forms.NumericUpDown();
            this.lblSpecify = new System.Windows.Forms.Label();
            this.lblNudSecs = new System.Windows.Forms.Label();
            this.lblnudMins = new System.Windows.Forms.Label();
            this.lblRepnum = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.rdoTenths = new System.Windows.Forms.RadioButton();
            this.rdoHundredths = new System.Windows.Forms.RadioButton();
            this.lblSecondDisplay = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDelay = new System.Windows.Forms.Label();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1015, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1015, 47);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Location = new System.Drawing.Point(785, 42);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(30, 15);
            this.lblRep.TabIndex = 2;
            this.lblRep.Text = "Rep:";
            // 
            // nudMins
            // 
            this.nudMins.Location = new System.Drawing.Point(105, 38);
            this.nudMins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMins.Name = "nudMins";
            this.nudMins.Size = new System.Drawing.Size(57, 23);
            this.nudMins.TabIndex = 1;
            this.nudMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMins.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudSecs
            // 
            this.nudSecs.Location = new System.Drawing.Point(168, 38);
            this.nudSecs.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSecs.Name = "nudSecs";
            this.nudSecs.Size = new System.Drawing.Size(57, 23);
            this.nudSecs.TabIndex = 2;
            this.nudSecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSpecify
            // 
            this.lblSpecify.AutoSize = true;
            this.lblSpecify.Location = new System.Drawing.Point(12, 40);
            this.lblSpecify.Name = "lblSpecify";
            this.lblSpecify.Size = new System.Drawing.Size(78, 15);
            this.lblSpecify.TabIndex = 7;
            this.lblSpecify.Text = "Rep duration:";
            // 
            // lblNudSecs
            // 
            this.lblNudSecs.AutoSize = true;
            this.lblNudSecs.Location = new System.Drawing.Point(168, 18);
            this.lblNudSecs.Name = "lblNudSecs";
            this.lblNudSecs.Size = new System.Drawing.Size(51, 15);
            this.lblNudSecs.TabIndex = 8;
            this.lblNudSecs.Text = "Seconds";
            // 
            // lblnudMins
            // 
            this.lblnudMins.AutoSize = true;
            this.lblnudMins.Location = new System.Drawing.Point(103, 18);
            this.lblnudMins.Name = "lblnudMins";
            this.lblnudMins.Size = new System.Drawing.Size(50, 15);
            this.lblnudMins.TabIndex = 9;
            this.lblnudMins.Text = "Minutes";
            // 
            // lblRepnum
            // 
            this.lblRepnum.AutoSize = true;
            this.lblRepnum.BackColor = System.Drawing.SystemColors.Window;
            this.lblRepnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRepnum.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRepnum.Location = new System.Drawing.Point(833, 18);
            this.lblRepnum.Name = "lblRepnum";
            this.lblRepnum.Size = new System.Drawing.Size(90, 108);
            this.lblRepnum.TabIndex = 10;
            this.lblRepnum.Text = "0";
            this.lblRepnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.SystemColors.Window;
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 240F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClock.Location = new System.Drawing.Point(3, 155);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(1183, 427);
            this.lblClock.TabIndex = 11;
            this.lblClock.Text = "00:00.0";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoTenths
            // 
            this.rdoTenths.AutoSize = true;
            this.rdoTenths.Checked = true;
            this.rdoTenths.Location = new System.Drawing.Point(603, 26);
            this.rdoTenths.Name = "rdoTenths";
            this.rdoTenths.Size = new System.Drawing.Size(59, 19);
            this.rdoTenths.TabIndex = 4;
            this.rdoTenths.TabStop = true;
            this.rdoTenths.Text = "Tenths";
            this.rdoTenths.UseVisualStyleBackColor = true;
            this.rdoTenths.CheckedChanged += new System.EventHandler(this.rdoTenths_CheckedChanged);
            // 
            // rdoHundredths
            // 
            this.rdoHundredths.AutoSize = true;
            this.rdoHundredths.Location = new System.Drawing.Point(603, 51);
            this.rdoHundredths.Name = "rdoHundredths";
            this.rdoHundredths.Size = new System.Drawing.Size(88, 19);
            this.rdoHundredths.TabIndex = 5;
            this.rdoHundredths.Text = "Hundredths";
            this.rdoHundredths.UseVisualStyleBackColor = true;
            this.rdoHundredths.CheckedChanged += new System.EventHandler(this.rdoHundredths_CheckedChanged);
            // 
            // lblSecondDisplay
            // 
            this.lblSecondDisplay.AutoSize = true;
            this.lblSecondDisplay.Location = new System.Drawing.Point(540, 42);
            this.lblSecondDisplay.Name = "lblSecondDisplay";
            this.lblSecondDisplay.Size = new System.Drawing.Size(48, 15);
            this.lblSecondDisplay.TabIndex = 14;
            this.lblSecondDisplay.Text = "Display:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1015, 76);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1015, 105);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(315, 40);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(72, 15);
            this.lblDelay.TabIndex = 15;
            this.lblDelay.Text = "Delay (secs):";
            // 
            // nudDelay
            // 
            this.nudDelay.Location = new System.Drawing.Point(402, 38);
            this.nudDelay.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(57, 23);
            this.nudDelay.TabIndex = 3;
            this.nudDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // IntervalTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 715);
            this.Controls.Add(this.nudDelay);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSecondDisplay);
            this.Controls.Add(this.rdoHundredths);
            this.Controls.Add(this.rdoTenths);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblRepnum);
            this.Controls.Add(this.lblnudMins);
            this.Controls.Add(this.lblNudSecs);
            this.Controls.Add(this.lblSpecify);
            this.Controls.Add(this.nudSecs);
            this.Controls.Add(this.nudMins);
            this.Controls.Add(this.lblRep);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "IntervalTimer";
            this.Text = "Interval Timer";
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private Label lblRep;
        private NumericUpDown nudMins;
        private NumericUpDown nudSecs;
        private Label lblSpecify;
        private Label lblNudSecs;
        private Label lblnudMins;
        private Label lblRepnum;
        private Label lblClock;
        private RadioButton rdoTenths;
        private RadioButton rdoHundredths;
        private Label lblSecondDisplay;
        private Button btnReset;
        private Button btnClose;
        private Label lblDelay;
        private NumericUpDown nudDelay;
    }
}