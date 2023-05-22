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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text=="" || PassTb.Text=="")
            {
                MessageBox.Show("Enter User Name and Password");
            }
            else if(UidTb.Text=="Admin" &&  PassTb.Text=="Admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Name or Password is wrong");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
