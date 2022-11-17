namespace IntervalTimer
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
            this.txtRep = new System.Windows.Forms.TextBox();
            this.txtClock = new System.Windows.Forms.TextBox();
            this.nudMins = new System.Windows.Forms.NumericUpDown();
            this.nudSecs = new System.Windows.Forms.NumericUpDown();
            this.lblSpecify = new System.Windows.Forms.Label();
            this.lblNudSecs = new System.Windows.Forms.Label();
            this.lblnudMins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(193, 330);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(295, 330);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Location = new System.Drawing.Point(134, 156);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(30, 15);
            this.lblRep.TabIndex = 2;
            this.lblRep.Text = "Rep:";
            // 
            // txtRep
            // 
            this.txtRep.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRep.Location = new System.Drawing.Point(191, 154);
            this.txtRep.Name = "txtRep";
            this.txtRep.Size = new System.Drawing.Size(100, 50);
            this.txtRep.TabIndex = 3;
            // 
            // txtClock
            // 
            this.txtClock.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClock.Location = new System.Drawing.Point(192, 219);
            this.txtClock.Name = "txtClock";
            this.txtClock.Size = new System.Drawing.Size(420, 50);
            this.txtClock.TabIndex = 4;
            // 
            // nudMins
            // 
            this.nudMins.Location = new System.Drawing.Point(193, 71);
            this.nudMins.Name = "nudMins";
            this.nudMins.Size = new System.Drawing.Size(57, 23);
            this.nudMins.TabIndex = 6;
            // 
            // nudSecs
            // 
            this.nudSecs.Location = new System.Drawing.Point(281, 71);
            this.nudSecs.Name = "nudSecs";
            this.nudSecs.Size = new System.Drawing.Size(57, 23);
            this.nudSecs.TabIndex = 6;
            // 
            // lblSpecify
            // 
            this.lblSpecify.AutoSize = true;
            this.lblSpecify.Location = new System.Drawing.Point(191, 24);
            this.lblSpecify.Name = "lblSpecify";
            this.lblSpecify.Size = new System.Drawing.Size(132, 15);
            this.lblSpecify.TabIndex = 7;
            this.lblSpecify.Text = "Specify total rep length:";
            // 
            // lblNudSecs
            // 
            this.lblNudSecs.AutoSize = true;
            this.lblNudSecs.Location = new System.Drawing.Point(279, 48);
            this.lblNudSecs.Name = "lblNudSecs";
            this.lblNudSecs.Size = new System.Drawing.Size(51, 15);
            this.lblNudSecs.TabIndex = 8;
            this.lblNudSecs.Text = "Seconds";
            // 
            // lblnudMins
            // 
            this.lblnudMins.AutoSize = true;
            this.lblnudMins.Location = new System.Drawing.Point(192, 50);
            this.lblnudMins.Name = "lblnudMins";
            this.lblnudMins.Size = new System.Drawing.Size(50, 15);
            this.lblnudMins.TabIndex = 9;
            this.lblnudMins.Text = "Minutes";
            // 
            // IntervalTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnudMins);
            this.Controls.Add(this.lblNudSecs);
            this.Controls.Add(this.lblSpecify);
            this.Controls.Add(this.nudSecs);
            this.Controls.Add(this.nudMins);
            this.Controls.Add(this.txtClock);
            this.Controls.Add(this.txtRep);
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
        private TextBox txtRep;
        private TextBox txtClock;
        private NumericUpDown nudMins;
        private NumericUpDown nudSecs;
        private Label lblSpecify;
        private Label lblNudSecs;
        private Label lblnudMins;
    }
}