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
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(333, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(450, 45);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Location = new System.Drawing.Point(63, 99);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(30, 15);
            this.lblRep.TabIndex = 2;
            this.lblRep.Text = "Rep:";
            // 
            // nudMins
            // 
            this.nudMins.Location = new System.Drawing.Point(124, 45);
            this.nudMins.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMins.Name = "nudMins";
            this.nudMins.Size = new System.Drawing.Size(57, 23);
            this.nudMins.TabIndex = 1;
            this.nudMins.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudSecs
            // 
            this.nudSecs.Location = new System.Drawing.Point(210, 45);
            this.nudSecs.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSecs.Name = "nudSecs";
            this.nudSecs.Size = new System.Drawing.Size(57, 23);
            this.nudSecs.TabIndex = 2;
            // 
            // lblSpecify
            // 
            this.lblSpecify.AutoSize = true;
            this.lblSpecify.Location = new System.Drawing.Point(32, 52);
            this.lblSpecify.Name = "lblSpecify";
            this.lblSpecify.Size = new System.Drawing.Size(78, 15);
            this.lblSpecify.TabIndex = 7;
            this.lblSpecify.Text = "Rep duration:";
            this.lblSpecify.Click += new System.EventHandler(this.lblSpecify_Click);
            // 
            // lblNudSecs
            // 
            this.lblNudSecs.AutoSize = true;
            this.lblNudSecs.Location = new System.Drawing.Point(210, 25);
            this.lblNudSecs.Name = "lblNudSecs";
            this.lblNudSecs.Size = new System.Drawing.Size(51, 15);
            this.lblNudSecs.TabIndex = 8;
            this.lblNudSecs.Text = "Seconds";
            // 
            // lblnudMins
            // 
            this.lblnudMins.AutoSize = true;
            this.lblnudMins.Location = new System.Drawing.Point(122, 25);
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
            this.lblRepnum.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRepnum.Location = new System.Drawing.Point(122, 90);
            this.lblRepnum.Name = "lblRepnum";
            this.lblRepnum.Size = new System.Drawing.Size(76, 91);
            this.lblRepnum.TabIndex = 10;
            this.lblRepnum.Text = "0";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.SystemColors.Window;
            this.lblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClock.Location = new System.Drawing.Point(12, 197);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(1131, 357);
            this.lblClock.TabIndex = 11;
            this.lblClock.Text = "00:00:00";
            // 
            // IntervalTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 602);
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
    }
}