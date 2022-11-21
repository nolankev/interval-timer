using System.Diagnostics;


namespace IntervalTimer
{
    public partial class IntervalTimer : Form
    {
        // Declarations
        Stopwatch sw = new Stopwatch();
        System.Windows.Forms.Timer tmrClock = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmrRepnum = new System.Windows.Forms.Timer();
        string elapsedTime = "";
        int delay;
        double totalRepDuration, rc;


        public IntervalTimer()
        {
            InitializeComponent();

            if (rdoTenths.Checked)
            {
                elapsedTime = "00:00.0";
            }
            else if (rdoHundredths.Checked)
            {
                elapsedTime = "00:00.00";
            }

            lblClock.Text = elapsedTime;
            CancelButton = btnClose;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Get inputs from user
            totalRepDuration = decimal.ToDouble((60*nudMins.Value) + nudSecs.Value);
            delay = 1000*((int)nudDelay.Value);

            // Clock refresh timer: Set interval (s*1000 milliseconds) and identify timer event handler
            if (rdoTenths.Checked)
            {
                tmrClock.Interval = 100;
            }
            else if (rdoHundredths.Checked)
            {
                tmrClock.Interval = 10;
            }
            tmrClock.Tick += new System.EventHandler(ClockTimerEventProcessor);
            
            // Repnum refresh timer
            tmrRepnum.Interval = 1000*((int)totalRepDuration);
            tmrRepnum.Tick += new System.EventHandler(RepnumTimerEventProcessor);

            // Disable controls to prevent changes while clock is running
            nudMins.Enabled = false;
            nudSecs.Enabled = false;
            nudDelay.Enabled = false;
            rdoHundredths.Enabled = false;
            rdoTenths.Enabled = false;
            btnStart.Enabled = false;

            // Actions: apply delay, set rep counter display=1, start timers, start stopwatch
            Thread.Sleep(delay);
            lblRepnum.Text = "1";
            tmrClock.Start();
            tmrRepnum.Start();
            sw.Start();
        }


        private void RepnumTimerEventProcessor(Object sender, EventArgs e)
        {
            // Update rep counter at the completion of each total rep duration period
            TimeSpan ts = sw.Elapsed;
            rc = Math.Floor(ts.TotalSeconds / totalRepDuration) + 1;
            lblRepnum.Text = rc.ToString();
        }


        private void ClockTimerEventProcessor(Object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;

            if (ts.TotalSeconds < totalRepDuration)
            {
                if (rdoTenths.Checked) 
                {
                    elapsedTime = String.Format("{0:00}:{1:00}.{2:0}",
                        ts.Minutes,
                        ts.Seconds,
                        ts.Milliseconds / 100);
                }
                else if (rdoHundredths.Checked)
                {
                    elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                        ts.Minutes,
                        ts.Seconds,
                        ts.Milliseconds / 10);
                }

                lblClock.Text = elapsedTime;
            }
            else
            {
                sw.Restart();
                lblClock.Text = "00:00.0";
            }
        }

        private void rdoTenths_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTenths.Checked)
            {
                lblClock.Text = "00:00.0";
            }
            else if (!rdoTenths.Checked)
            {
                lblClock.Text = "00:00.00";
            }
        }

        private void rdoHundredths_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHundredths.Checked)
            {
                lblClock.Text = "00:00.00";
            }
            else if (!rdoHundredths.Checked)
            {
                lblClock.Text = "00:00.0";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Stop background activity
            sw.Reset();
            tmrClock.Stop();
            tmrRepnum.Stop();
            
            // Re-enable controls
            nudMins.Enabled = true;
            nudSecs.Enabled = true;
            nudDelay.Enabled = true;
            rdoHundredths.Enabled = true;
            rdoTenths.Enabled = true;
            btnStart.Enabled = true;
            rdoTenths.Checked = true;

            // Reset controls to default values
            nudMins.Value = 3;
            nudSecs.Value = 0;
            nudDelay.Value = 10;
            lblRepnum.Text = "0";
            lblClock.Text = "00:00.0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}