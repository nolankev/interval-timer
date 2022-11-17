using System.Diagnostics;

namespace IntervalTimer
{
    public partial class IntervalTimer : Form
    {

        Stopwatch sw = new Stopwatch();

        public IntervalTimer()
        {
            InitializeComponent();

            if (rdoTenths.Checked)
            {
                lblClock.Text = "00:00.0";
            }
            else if (rdoHundredths.Checked)
            {
                lblClock.Text = "00:00.00";
            }
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


            // Start timing
            sw.Start();

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:0}",
                    ts.Minutes,
                    ts.Seconds,
                    ts.Milliseconds / 100);

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
            

            //lblClock.Text = sw.Elapsed.ToString();
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
    }
}