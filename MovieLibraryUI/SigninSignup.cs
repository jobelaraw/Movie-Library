using MovieLibraryBL;
using MovieLibraryCommon;
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
    public partial class SigninSignup : Form
    {
        static MovieLibraryProcess movielibraryprocess = new MovieLibraryProcess();
        static bool loggedin = false;
        public static Account userAccount;

        public SigninSignup()
        {
            InitializeComponent();
        }

        private void SigninSignup_Load(object sender, EventArgs e)
        {

        }
        //exit for panelbglogo
        private void btnExit_Click(object sender, EventArgs e)
        {
            FirstFrame firstFrame = new FirstFrame();
            firstFrame.Show();
            this.Close();

        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            panelBGLogo.Visible = false;
            panelSignup.BringToFront();

        }

        //exit for panelsignup
        private void btnExitSingup_Click(object sender, EventArgs e)
        {
            FirstFrame firstFrame = new FirstFrame();
            firstFrame.Show();
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            panelBGLogo.Visible = false;
            panelSignin.Visible = true;
            panelSignin.BringToFront();

        }

        private void btnSignup2_Click(object sender, EventArgs e)
        {
            string name;
            string userName;
            string password;

            name = txtNameSignup.Text.Trim();
            userName = txtUsernameSignup.Text.Trim();
            password = txtPasswordSignup.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input your Name, Username, and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                movielibraryprocess.CreateAccount(name, userName, password);
                MessageBox.Show("Account created successfully! Please log in." , "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panelSignin.Visible = true;
                panelSignup.Visible = false;
                panelSignin.BringToFront();

            }
        }

        private void btnSeePasswordSignup_Click(object sender, EventArgs e)
        {
            txtPasswordSignup.UseSystemPasswordChar = !txtPasswordSignup.UseSystemPasswordChar;

            if (!txtPasswordSignup.UseSystemPasswordChar)
            {
                btnSeePasswordSignup.BackgroundImage = Properties.Resources.eyeclose;
            }
            else
            {
                btnSeePasswordSignup.BackgroundImage = Properties.Resources.eyeopen;
            }
        }

        //exit for panelsignin
        private void btnExitSignin_Click(object sender, EventArgs e)
        {
            FirstFrame firstFrame = new FirstFrame();
            firstFrame.Show();
            this.Close();
        }

        private void btnSignin2_Click(object sender, EventArgs e)
        {

            string userName = txtUsernameSignin.Text.Trim();
            string password = txtPasswordSignin.Text.Trim();

            var account = movielibraryprocess.GetMovieLibraryAccount(userName, password);

            if (movielibraryprocess.ValidateAccount(userName, password))
            {
                loggedin = true;
                userAccount = account;
                MessageBox.Show("Login successful! Welcome, " + userName, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MovieLibraryDashboard.userAccount = userAccount;
                MovieLibraryDashboard movielibrarydashboard = new MovieLibraryDashboard();
                movielibrarydashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsernameSignin.Clear();
                txtPasswordSignin.Clear();
            }

        }

        private void btnSignup3_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            panelSignin.Visible = false;
            panelSignup.BringToFront();
        }

        private void btnSeePassword_Click(object sender, EventArgs e)
        {
            txtPasswordSignin.UseSystemPasswordChar = !txtPasswordSignin.UseSystemPasswordChar;

            if (!txtPasswordSignin.UseSystemPasswordChar)
            {
                btnSeePasswordSignin.BackgroundImage = Properties.Resources.eyeclose;
            }
            else
            {
                btnSeePasswordSignin.BackgroundImage = Properties.Resources.eyeopen;
            }
        }
    }
}

