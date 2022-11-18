using System.Diagnostics;

namespace IntervalTimer
{
    public partial class IntervalTimer : Form
    {
        // Declarations
        Stopwatch sw = new Stopwatch();
        System.Windows.Forms.Timer tmrClock = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmrRepnum = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmrBeeper = new System.Windows.Forms.Timer();
        string elapsedTime = "";
        double totalRepDuration, totalSeconds, totalSeconds_mod;
        double m, s, millis;
        double rc;


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

        private void lblSpecify_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Get inputs
            totalRepDuration = decimal.ToDouble((60*nudMins.Value) + nudSecs.Value);

            // Disable controls to prevent changes
            nudMins.Enabled = false;
            nudSecs.Enabled = false;
            rdoHundredths.Enabled = false;
            rdoTenths.Enabled = false;
            btnStart.Enabled = false;

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
            tmrRepnum.Interval = ((int)totalRepDuration);
            tmrRepnum.Tick += new System.EventHandler(RepnumTimerEventProcessor);
            
            // Beeper refresh timer
            tmrBeeper.Interval = ((int)totalRepDuration);
            tmrBeeper.Tick += new System.EventHandler(BeeperTimerEventProcessor);

            // Actions: wait, start timers, BEEP, start watch
            Thread.Sleep(3000);
            tmrClock.Start();
            tmrRepnum.Start();
            tmrBeeper.Start();
            sw.Start();
        }


        private void BeeperTimerEventProcessor(Object sender, EventArgs e) 
        {
            // Make Beep sound
        }


        private void RepnumTimerEventProcessor(Object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;
            totalSeconds = ts.TotalSeconds;

            // Rep count
            rc = Math.Floor(totalSeconds / totalRepDuration) + 1;
            lblRepnum.Text = rc.ToString();
        }


        private void ClockTimerEventProcessor(Object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;

            totalSeconds = ts.TotalSeconds;
            totalSeconds_mod = totalSeconds % totalRepDuration;
            m = Math.Floor(totalSeconds_mod / 60);
            s = Math.Floor(totalSeconds_mod % 60);
            millis = (totalSeconds_mod % 60) - s;

            if (rdoTenths.Checked)
            {
                millis = Math.Round(10*millis);
                elapsedTime = String.Format("{0:00}:{1:00}.{2:0}",
                    m.ToString().PadLeft(2, '0'),
                    s.ToString().PadLeft(2, '0'),
                    millis.ToString().Substring(0, 1));
            }
            else if (rdoHundredths.Checked)
            {
                millis = Math.Round(100 * millis);
                elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                    m.ToString().PadLeft(2, '0'),
                    s.ToString().PadLeft(2, '0'),
                    millis.ToString().PadLeft(2, '0').Substring(0, 2));
            }
            
            lblClock.Text = elapsedTime;
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
            sw.Reset();
            tmrClock.Stop();
            tmrRepnum.Stop();
            
            nudMins.Enabled = true;
            nudSecs.Enabled = true;
            rdoHundredths.Enabled = true;
            rdoTenths.Enabled = true;
            btnStart.Enabled = true;
            
            rdoTenths.Checked = true;

            nudMins.Value = 3;
            nudSecs.Value = 0;
            lblRepnum.Text = "0";
            lblClock.Text = "00:00.0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}