namespace MovieLibraryUI
{
    partial class FirstFrame
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
            btnGetStarted = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.FromArgb(35, 61, 255);
            btnGetStarted.FlatAppearance.BorderSize = 0;
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Font = new Font("Candara", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetStarted.ForeColor = Color.White;
            btnGetStarted.Location = new Point(394, 419);
            btnGetStarted.Margin = new Padding(0);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(291, 52);
            btnGetStarted.TabIndex = 1;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.UseVisualStyleBackColor = false;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(7, 37, 65);
            button1.Image = Properties.Resources.exitFrame;
            button1.Location = new Point(976, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(56, 52);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FirstFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgFirstframe;
            ClientSize = new Size(1043, 576);
            Controls.Add(button1);
            Controls.Add(btnGetStarted);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FirstFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FirstFrame";
            ResumeLayout(false);
        }

        #endregion
        private Button btnGetStarted;
        private Button button1;
    }
}