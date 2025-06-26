namespace MovieLibraryUI
{
    partial class SigninSignup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBGLogo = new Panel();
            btnSignin = new Button();
            lblHaveAccount = new Label();
            btnSignup = new Button();
            btnExit = new Button();
            panelSignup = new Panel();
            btnSeePasswordSignup = new Button();
            btnSignup2 = new Button();
            txtPasswordSignup = new TextBox();
            txtUsernameSignup = new TextBox();
            txtNameSignup = new TextBox();
            btnExitSingup = new Button();
            panelSignin = new Panel();
            btnSeePasswordSignin = new Button();
            btnSignup3 = new Button();
            lblCreateAccount = new Label();
            btnExitSignin = new Button();
            btnSignin2 = new Button();
            txtPasswordSignin = new TextBox();
            txtUsernameSignin = new TextBox();
            panelBGLogo.SuspendLayout();
            panelSignup.SuspendLayout();
            panelSignin.SuspendLayout();
            SuspendLayout();
            // 
            // panelBGLogo
            // 
            panelBGLogo.BackgroundImage = Properties.Resources.logo;
            panelBGLogo.Controls.Add(btnSignin);
            panelBGLogo.Controls.Add(lblHaveAccount);
            panelBGLogo.Controls.Add(btnSignup);
            panelBGLogo.Controls.Add(btnExit);
            panelBGLogo.Location = new Point(321, 31);
            panelBGLogo.Margin = new Padding(0);
            panelBGLogo.Name = "panelBGLogo";
            panelBGLogo.Size = new Size(420, 500);
            panelBGLogo.TabIndex = 0;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(44, 62, 80);
            btnSignin.FlatAppearance.BorderSize = 0;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = Color.FromArgb(141, 216, 255);
            btnSignin.Location = new Point(257, 389);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(47, 23);
            btnSignin.TabIndex = 0;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.AutoSize = true;
            lblHaveAccount.BackColor = Color.FromArgb(44, 62, 80);
            lblHaveAccount.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHaveAccount.ForeColor = Color.White;
            lblHaveAccount.Location = new Point(124, 393);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(136, 14);
            lblHaveAccount.TabIndex = 2;
            lblHaveAccount.Text = "Already have an Account?";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(141, 216, 255);
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.Location = new Point(155, 337);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(116, 47);
            btnSignup.TabIndex = 1;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = Properties.Resources.exitPanel;
            btnExit.Location = new Point(351, 13);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(56, 52);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelSignup
            // 
            panelSignup.BackgroundImage = Properties.Resources.signup;
            panelSignup.Controls.Add(btnSeePasswordSignup);
            panelSignup.Controls.Add(btnSignup2);
            panelSignup.Controls.Add(txtPasswordSignup);
            panelSignup.Controls.Add(txtUsernameSignup);
            panelSignup.Controls.Add(txtNameSignup);
            panelSignup.Controls.Add(btnExitSingup);
            panelSignup.Location = new Point(319, 31);
            panelSignup.Name = "panelSignup";
            panelSignup.Size = new Size(420, 500);
            panelSignup.TabIndex = 3;
            panelSignup.Visible = false;
            // 
            // btnSeePasswordSignup
            // 
            btnSeePasswordSignup.BackColor = Color.FromArgb(129, 154, 145);
            btnSeePasswordSignup.BackgroundImage = Properties.Resources.eyeopen;
            btnSeePasswordSignup.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeePasswordSignup.FlatAppearance.BorderSize = 0;
            btnSeePasswordSignup.FlatStyle = FlatStyle.Flat;
            btnSeePasswordSignup.Location = new Point(330, 300);
            btnSeePasswordSignup.Name = "btnSeePasswordSignup";
            btnSeePasswordSignup.Size = new Size(40, 35);
            btnSeePasswordSignup.TabIndex = 13;
            btnSeePasswordSignup.UseVisualStyleBackColor = false;
            btnSeePasswordSignup.Click += btnSeePasswordSignup_Click;
            // 
            // btnSignup2
            // 
            btnSignup2.BackColor = Color.FromArgb(141, 216, 255);
            btnSignup2.FlatAppearance.BorderColor = Color.FromArgb(141, 216, 255);
            btnSignup2.FlatAppearance.BorderSize = 0;
            btnSignup2.FlatStyle = FlatStyle.Flat;
            btnSignup2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup2.Location = new Point(153, 395);
            btnSignup2.Margin = new Padding(0);
            btnSignup2.Name = "btnSignup2";
            btnSignup2.Size = new Size(116, 47);
            btnSignup2.TabIndex = 7;
            btnSignup2.Text = "Sign up";
            btnSignup2.UseVisualStyleBackColor = false;
            btnSignup2.Click += btnSignup2_Click;
            // 
            // txtPasswordSignup
            // 
            txtPasswordSignup.BackColor = Color.FromArgb(129, 154, 145);
            txtPasswordSignup.BorderStyle = BorderStyle.None;
            txtPasswordSignup.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordSignup.ForeColor = Color.Black;
            txtPasswordSignup.Location = new Point(175, 308);
            txtPasswordSignup.Margin = new Padding(0);
            txtPasswordSignup.Name = "txtPasswordSignup";
            txtPasswordSignup.PlaceholderText = "Enter password";
            txtPasswordSignup.Size = new Size(203, 19);
            txtPasswordSignup.TabIndex = 6;
            txtPasswordSignup.UseSystemPasswordChar = true;
            // 
            // txtUsernameSignup
            // 
            txtUsernameSignup.BackColor = Color.FromArgb(129, 154, 145);
            txtUsernameSignup.BorderStyle = BorderStyle.None;
            txtUsernameSignup.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameSignup.ForeColor = Color.Black;
            txtUsernameSignup.Location = new Point(175, 237);
            txtUsernameSignup.Margin = new Padding(0);
            txtUsernameSignup.Name = "txtUsernameSignup";
            txtUsernameSignup.PlaceholderText = "Enter username";
            txtUsernameSignup.Size = new Size(205, 19);
            txtUsernameSignup.TabIndex = 5;
            // 
            // txtNameSignup
            // 
            txtNameSignup.BackColor = Color.FromArgb(129, 154, 145);
            txtNameSignup.BorderStyle = BorderStyle.None;
            txtNameSignup.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameSignup.ForeColor = Color.Black;
            txtNameSignup.Location = new Point(174, 164);
            txtNameSignup.Margin = new Padding(0);
            txtNameSignup.Name = "txtNameSignup";
            txtNameSignup.PlaceholderText = "Enter name";
            txtNameSignup.Size = new Size(204, 19);
            txtNameSignup.TabIndex = 4;
            // 
            // btnExitSingup
            // 
            btnExitSingup.FlatAppearance.BorderSize = 0;
            btnExitSingup.FlatStyle = FlatStyle.Flat;
            btnExitSingup.Image = Properties.Resources.exitPanel;
            btnExitSingup.Location = new Point(351, 10);
            btnExitSingup.Margin = new Padding(0);
            btnExitSingup.Name = "btnExitSingup";
            btnExitSingup.Size = new Size(56, 52);
            btnExitSingup.TabIndex = 1;
            btnExitSingup.UseVisualStyleBackColor = true;
            btnExitSingup.Click += btnExitSingup_Click;
            // 
            // panelSignin
            // 
            panelSignin.BackgroundImage = Properties.Resources.signin;
            panelSignin.Controls.Add(btnSeePasswordSignin);
            panelSignin.Controls.Add(btnSignup3);
            panelSignin.Controls.Add(lblCreateAccount);
            panelSignin.Controls.Add(btnExitSignin);
            panelSignin.Controls.Add(btnSignin2);
            panelSignin.Controls.Add(txtPasswordSignin);
            panelSignin.Controls.Add(txtUsernameSignin);
            panelSignin.Location = new Point(319, 31);
            panelSignin.Margin = new Padding(0);
            panelSignin.Name = "panelSignin";
            panelSignin.Size = new Size(420, 500);
            panelSignin.TabIndex = 4;
            panelSignin.Visible = false;
            // 
            // btnSeePasswordSignin
            // 
            btnSeePasswordSignin.BackColor = Color.FromArgb(129, 154, 145);
            btnSeePasswordSignin.BackgroundImage = Properties.Resources.eyeopen;
            btnSeePasswordSignin.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeePasswordSignin.FlatAppearance.BorderSize = 0;
            btnSeePasswordSignin.FlatStyle = FlatStyle.Flat;
            btnSeePasswordSignin.Location = new Point(326, 269);
            btnSeePasswordSignin.Name = "btnSeePasswordSignin";
            btnSeePasswordSignin.Size = new Size(40, 35);
            btnSeePasswordSignin.TabIndex = 12;
            btnSeePasswordSignin.UseVisualStyleBackColor = true;
            btnSeePasswordSignin.Click += btnSeePassword_Click;
            // 
            // btnSignup3
            // 
            btnSignup3.BackColor = Color.FromArgb(44, 62, 80);
            btnSignup3.FlatAppearance.BorderSize = 0;
            btnSignup3.FlatStyle = FlatStyle.Flat;
            btnSignup3.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup3.ForeColor = Color.FromArgb(141, 216, 255);
            btnSignup3.Location = new Point(228, 449);
            btnSignup3.Name = "btnSignup3";
            btnSignup3.Size = new Size(57, 23);
            btnSignup3.TabIndex = 11;
            btnSignup3.Text = "Sign up";
            btnSignup3.UseVisualStyleBackColor = false;
            btnSignup3.Click += btnSignup3_Click;
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.BackColor = Color.FromArgb(44, 62, 80);
            lblCreateAccount.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateAccount.ForeColor = Color.White;
            lblCreateAccount.Location = new Point(143, 453);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(88, 14);
            lblCreateAccount.TabIndex = 10;
            lblCreateAccount.Text = "Create Account?";
            // 
            // btnExitSignin
            // 
            btnExitSignin.FlatAppearance.BorderSize = 0;
            btnExitSignin.FlatStyle = FlatStyle.Flat;
            btnExitSignin.Image = Properties.Resources.exitPanel;
            btnExitSignin.Location = new Point(354, 11);
            btnExitSignin.Margin = new Padding(0);
            btnExitSignin.Name = "btnExitSignin";
            btnExitSignin.Size = new Size(56, 52);
            btnExitSignin.TabIndex = 9;
            btnExitSignin.UseVisualStyleBackColor = true;
            btnExitSignin.Click += btnExitSignin_Click;
            // 
            // btnSignin2
            // 
            btnSignin2.BackColor = Color.FromArgb(141, 216, 255);
            btnSignin2.FlatAppearance.BorderColor = Color.FromArgb(141, 216, 255);
            btnSignin2.FlatAppearance.BorderSize = 0;
            btnSignin2.FlatStyle = FlatStyle.Flat;
            btnSignin2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignin2.Location = new Point(151, 392);
            btnSignin2.Name = "btnSignin2";
            btnSignin2.Size = new Size(116, 52);
            btnSignin2.TabIndex = 4;
            btnSignin2.Text = "Sign in";
            btnSignin2.UseVisualStyleBackColor = true;
            btnSignin2.Click += btnSignin2_Click;
            // 
            // txtPasswordSignin
            // 
            txtPasswordSignin.BackColor = Color.FromArgb(129, 154, 145);
            txtPasswordSignin.BorderStyle = BorderStyle.None;
            txtPasswordSignin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordSignin.ForeColor = Color.Black;
            txtPasswordSignin.Location = new Point(174, 277);
            txtPasswordSignin.Margin = new Padding(0);
            txtPasswordSignin.Name = "txtPasswordSignin";
            txtPasswordSignin.PlaceholderText = "Enter password";
            txtPasswordSignin.Size = new Size(205, 19);
            txtPasswordSignin.TabIndex = 7;
            txtPasswordSignin.UseSystemPasswordChar = true;
            // 
            // txtUsernameSignin
            // 
            txtUsernameSignin.BackColor = Color.FromArgb(129, 154, 145);
            txtUsernameSignin.BorderStyle = BorderStyle.None;
            txtUsernameSignin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameSignin.ForeColor = Color.Black;
            txtUsernameSignin.Location = new Point(173, 183);
            txtUsernameSignin.Margin = new Padding(0);
            txtUsernameSignin.Name = "txtUsernameSignin";
            txtUsernameSignin.PlaceholderText = "Enter username";
            txtUsernameSignin.Size = new Size(205, 19);
            txtUsernameSignin.TabIndex = 6;
            // 
            // SigninSignup
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1046, 576);
            Controls.Add(panelBGLogo);
            Controls.Add(panelSignin);
            Controls.Add(panelSignup);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SigninSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SigninSignup";
            Load += SigninSignup_Load;
            panelBGLogo.ResumeLayout(false);
            panelBGLogo.PerformLayout();
            panelSignup.ResumeLayout(false);
            panelSignup.PerformLayout();
            panelSignin.ResumeLayout(false);
            panelSignin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBGLogo;
        private Button btnSignup;
        private Button btnExit;
        private Label lblHaveAccount;
        private Button btnSignin;
        private Panel panelSignup;
        private TextBox txtNameSignup;
        private Button btnExitSingup;
        private TextBox txtPasswordSignup;
        private TextBox txtUsernameSignup;
        private Button btnSignup2;
        private Panel panelSignin;
        private TextBox txtPasswordSignin;
        private TextBox txtUsernameSignin;
        private Button btnSignin2;
        private Button btnExitSignin;
        private Button btnSignup3;
        private Label lblCreateAccount;
        private Button btnSeePasswordSignin;
        private Button btnSeePasswordSignup;
    }
}