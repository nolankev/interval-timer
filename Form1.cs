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
            lblClock.Text = sw.Elapsed.ToString();


        }
    }
}