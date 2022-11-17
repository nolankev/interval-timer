using System.Diagnostics;

namespace IntervalTimer
{
    public partial class IntervalTimer : Form
    {

        Stopwatch sw = new Stopwatch();

        public IntervalTimer()
        {
            InitializeComponent();
        }

        private void lblSpecify_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sw.Start();

            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes,
                ts.Seconds,
                ts.Milliseconds / 10);

            //lblClock.Text = sw.Elapsed.ToString();
            lblClock.Text = elapsedTime;
        }
    }
}