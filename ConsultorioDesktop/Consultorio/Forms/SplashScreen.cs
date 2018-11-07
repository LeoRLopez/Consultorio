using System;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.TransparencyKey = (BackColor);
            timerSplashScreen.Enabled = true;
            timerSplashScreen.Interval = 3000;
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            timerSplashScreen.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}