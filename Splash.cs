using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
           timer1.Start();

        }

        int startpoint = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint+=2;
            VProgressBar.Value = startpoint;
            LProgressBar.Value = startpoint;   
            if(LProgressBar.Value == 100)
            {
                VProgressBar.Value = 0;
                LProgressBar.Value = 0;
                timer1.Stop();  
                LogIn log_in =new LogIn();
                log_in.Show();
                this.Hide();
                
            }
        }
    }
}
