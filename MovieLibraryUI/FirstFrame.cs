using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLibraryUI
{
    public partial class FirstFrame : Form
    {
        public FirstFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            SigninSignup signinsignup = new SigninSignup();
            signinsignup.Show();
            this.Hide();

        }
    }
}
