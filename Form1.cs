using System.Diagnostics;

namespace IntervalTimer
{
    public partial class IntervalTimer : Form
    {

        Stopwatch sw = new Stopwatch();
        string elapsedTime = "";

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
        }

        private void lblSpecify_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Disable controls to prevent changes
            nudMins.Enabled = false;
            nudSecs.Enabled = false;
            rdoHundredths.Enabled = false;
            rdoTenths.Enabled = false;
            // btnStart.Enabled = false; //uncomment this once Timer sorted

            // Start timing
            sw.Start();

            TimeSpan ts = sw.Elapsed;

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
    }
}