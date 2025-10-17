namespace MovieLibraryUI
{
    partial class MovieLibraryDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelHome = new Panel();
            lblProfileName = new Label();
            btnProfile = new Button();
            cmbMovieGenres = new ComboBox();
            btnManageLibrary = new Button();
            panelManageLibrary = new Panel();
            btnUpdateMovieDetails = new Button();
            btnDeleteMovie = new Button();
            btnMovieList = new Button();
            btnHome = new Button();
            btnAddMovie = new Button();
            panelMovieList = new Panel();
            btnRefresh = new Button();
            dgvMovieList = new DataGridView();
            clmMovieTitle = new DataGridViewTextBoxColumn();
            clmCountry = new DataGridViewTextBoxColumn();
            clmGenre = new DataGridViewTextBoxColumn();
            clmReleaseyear = new DataGridViewTextBoxColumn();
            clmWatched = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            txtAddSearch = new TextBox();
            btnAddSearch = new Button();
            panelDeleteMovie = new Panel();
            lblNote = new Label();
            btnDelete = new Button();
            btnDeleteRefresh = new Button();
            dgvDeleteMovie = new DataGridView();
            clmMovieTitleDelete = new DataGridViewTextBoxColumn();
            clmCountryDelete = new DataGridViewTextBoxColumn();
            clmGenreDelete = new DataGridViewTextBoxColumn();
            clmReleaseYearDelete = new DataGridViewTextBoxColumn();
            clmWatchedDelete = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            txtDeleteSearch = new TextBox();
            btnDeleteSearch = new Button();
            panelAddMovieDetails = new Panel();
            btnAddMovieDetails = new Button();
            txtAddWatched = new TextBox();
            txtAddReleaseYear = new TextBox();
            txtAddGenre = new TextBox();
            txtAddCountry = new TextBox();
            txtAddMovieTitle = new TextBox();
            panelProfileDetails = new Panel();
            btnSeePasswordProfile = new Button();
            txtPasswordProfile = new TextBox();
            lblUsernameProfile = new Label();
            lblNameProfile = new Label();
            btnDeleteAccProfile = new Button();
            btnLogout = new Button();
            panelDeleteAccount = new Panel();
            btnSeePasswordDelete = new Button();
            btnCancel = new Button();
            btnDeleteAccount = new Button();
            txtPasswordDeleteAcc = new TextBox();
            txtUsernameDeleteAcc = new TextBox();
            panelUpdateMovieDetails2 = new Panel();
            btnSaveChanges = new Button();
            txtNewWatched = new TextBox();
            txtNewReleasedYear = new TextBox();
            txtNewGenre = new TextBox();
            txtNewCountry = new TextBox();
            txtNewMovieTitle = new TextBox();
            panelUpdateMovieDetails1 = new Panel();
            btnSearchUpdateMovie = new Button();
            txtSearchUpdateMovie = new TextBox();
            panelHome.SuspendLayout();
            panelManageLibrary.SuspendLayout();
            panelMovieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovieList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panelDeleteMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelAddMovieDetails.SuspendLayout();
            panelProfileDetails.SuspendLayout();
            panelDeleteAccount.SuspendLayout();
            panelUpdateMovieDetails2.SuspendLayout();
            panelUpdateMovieDetails1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.FromArgb(44, 62, 80);
            panelHome.BackgroundImage = Properties.Resources.home;
            panelHome.Controls.Add(lblProfileName);
            panelHome.Controls.Add(btnProfile);
            panelHome.Controls.Add(cmbMovieGenres);
            panelHome.Controls.Add(btnManageLibrary);
            panelHome.Location = new Point(-1, -1);
            panelHome.Margin = new Padding(0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(207, 539);
            panelHome.TabIndex = 0;
            // 
            // lblProfileName
            // 
            lblProfileName.AutoSize = true;
            lblProfileName.BackColor = Color.FromArgb(44, 62, 80);
            lblProfileName.Enabled = false;
            lblProfileName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProfileName.ForeColor = Color.White;
            lblProfileName.Location = new Point(62, 501);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(50, 18);
            lblProfileName.TabIndex = 11;
            lblProfileName.Text = "label1";
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = Properties.Resources.profilebtn;
            btnProfile.Location = new Point(7, 484);
            btnProfile.Margin = new Padding(0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(54, 45);
            btnProfile.TabIndex = 1;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // cmbMovieGenres
            // 
            cmbMovieGenres.BackColor = Color.FromArgb(183, 201, 242);
            cmbMovieGenres.FlatStyle = FlatStyle.Flat;
            cmbMovieGenres.Font = new Font("Arial Rounded MT Bold", 12F);
            cmbMovieGenres.FormattingEnabled = true;
            cmbMovieGenres.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Horror", "Sci-Fi", "Romance" });
            cmbMovieGenres.Location = new Point(49, 287);
            cmbMovieGenres.Margin = new Padding(0);
            cmbMovieGenres.Name = "cmbMovieGenres";
            cmbMovieGenres.Size = new Size(144, 26);
            cmbMovieGenres.TabIndex = 1;
            cmbMovieGenres.Text = "Movie Genres";
            cmbMovieGenres.SelectedIndexChanged += cmbMovieGenres_SelectedIndexChanged;
            // 
            // btnManageLibrary
            // 
            btnManageLibrary.BackColor = Color.FromArgb(183, 201, 242);
            btnManageLibrary.FlatAppearance.BorderSize = 0;
            btnManageLibrary.FlatStyle = FlatStyle.Flat;
            btnManageLibrary.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageLibrary.ForeColor = Color.Black;
            btnManageLibrary.Location = new Point(42, 204);
            btnManageLibrary.Name = "btnManageLibrary";
            btnManageLibrary.Size = new Size(141, 38);
            btnManageLibrary.TabIndex = 1;
            btnManageLibrary.Text = "Manage Library";
            btnManageLibrary.UseVisualStyleBackColor = false;
            btnManageLibrary.Click += btnManageLibrary_Click;
            // 
            // panelManageLibrary
            // 
            panelManageLibrary.BackgroundImage = Properties.Resources.managelibrary;
            panelManageLibrary.Controls.Add(btnUpdateMovieDetails);
            panelManageLibrary.Controls.Add(btnDeleteMovie);
            panelManageLibrary.Controls.Add(btnMovieList);
            panelManageLibrary.Controls.Add(btnHome);
            panelManageLibrary.Controls.Add(btnAddMovie);
            panelManageLibrary.Location = new Point(0, -1);
            panelManageLibrary.Margin = new Padding(0);
            panelManageLibrary.Name = "panelManageLibrary";
            panelManageLibrary.Size = new Size(207, 539);
            panelManageLibrary.TabIndex = 2;
            panelManageLibrary.Visible = false;
            // 
            // btnUpdateMovieDetails
            // 
            btnUpdateMovieDetails.BackColor = Color.FromArgb(183, 201, 242);
            btnUpdateMovieDetails.FlatAppearance.BorderSize = 0;
            btnUpdateMovieDetails.FlatStyle = FlatStyle.Flat;
            btnUpdateMovieDetails.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateMovieDetails.ForeColor = Color.Black;
            btnUpdateMovieDetails.Location = new Point(52, 379);
            btnUpdateMovieDetails.Margin = new Padding(0);
            btnUpdateMovieDetails.Name = "btnUpdateMovieDetails";
            btnUpdateMovieDetails.Size = new Size(141, 37);
            btnUpdateMovieDetails.TabIndex = 6;
            btnUpdateMovieDetails.Text = "Update Details";
            btnUpdateMovieDetails.UseVisualStyleBackColor = false;
            btnUpdateMovieDetails.Click += btnUpdateMovieDetails_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.BackColor = Color.FromArgb(183, 201, 242);
            btnDeleteMovie.FlatAppearance.BorderSize = 0;
            btnDeleteMovie.FlatStyle = FlatStyle.Flat;
            btnDeleteMovie.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteMovie.ForeColor = Color.Black;
            btnDeleteMovie.Location = new Point(52, 315);
            btnDeleteMovie.Margin = new Padding(0);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(141, 37);
            btnDeleteMovie.TabIndex = 5;
            btnDeleteMovie.Text = "Delete";
            btnDeleteMovie.UseVisualStyleBackColor = false;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // btnMovieList
            // 
            btnMovieList.BackColor = Color.FromArgb(183, 201, 242);
            btnMovieList.FlatAppearance.BorderSize = 0;
            btnMovieList.FlatStyle = FlatStyle.Flat;
            btnMovieList.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMovieList.ForeColor = Color.Black;
            btnMovieList.Location = new Point(52, 188);
            btnMovieList.Margin = new Padding(0);
            btnMovieList.Name = "btnMovieList";
            btnMovieList.Size = new Size(141, 37);
            btnMovieList.TabIndex = 4;
            btnMovieList.Text = "Movie List";
            btnMovieList.UseVisualStyleBackColor = false;
            btnMovieList.Click += btnMovieList_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(44, 62, 80);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Properties.Resources.homebtn;
            btnHome.Location = new Point(135, 478);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(58, 51);
            btnHome.TabIndex = 3;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnAddMovie
            // 
            btnAddMovie.BackColor = Color.FromArgb(183, 201, 242);
            btnAddMovie.FlatAppearance.BorderSize = 0;
            btnAddMovie.FlatStyle = FlatStyle.Flat;
            btnAddMovie.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMovie.ForeColor = Color.Black;
            btnAddMovie.Location = new Point(52, 251);
            btnAddMovie.Margin = new Padding(0);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(141, 37);
            btnAddMovie.TabIndex = 2;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = false;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // panelMovieList
            // 
            panelMovieList.BackColor = Color.FromArgb(44, 62, 80);
            panelMovieList.BackgroundImage = Properties.Resources.movielist;
            panelMovieList.Controls.Add(btnRefresh);
            panelMovieList.Controls.Add(dgvMovieList);
            panelMovieList.Controls.Add(dataGridView3);
            panelMovieList.Controls.Add(txtAddSearch);
            panelMovieList.Controls.Add(btnAddSearch);
            panelMovieList.Location = new Point(250, 62);
            panelMovieList.Name = "panelMovieList";
            panelMovieList.Size = new Size(734, 416);
            panelMovieList.TabIndex = 3;
            panelMovieList.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(44, 62, 80);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = Properties.Resources.refreshbtn;
            btnRefresh.Location = new Point(673, 348);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(39, 41);
            btnRefresh.TabIndex = 5;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvMovieList
            // 
            dgvMovieList.AllowUserToResizeRows = false;
            dgvMovieList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovieList.BackgroundColor = Color.FromArgb(113, 137, 191);
            dgvMovieList.BorderStyle = BorderStyle.None;
            dgvMovieList.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMovieList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovieList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovieList.Columns.AddRange(new DataGridViewColumn[] { clmMovieTitle, clmCountry, clmGenre, clmReleaseyear, clmWatched });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(138, 205, 215);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMovieList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMovieList.EnableHeadersVisualStyles = false;
            dgvMovieList.GridColor = SystemColors.WindowText;
            dgvMovieList.Location = new Point(30, 138);
            dgvMovieList.Name = "dgvMovieList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(138, 205, 215);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMovieList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMovieList.RowHeadersVisible = false;
            dgvMovieList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovieList.Size = new Size(676, 207);
            dgvMovieList.TabIndex = 8;
            // 
            // clmMovieTitle
            // 
            clmMovieTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmMovieTitle.FillWeight = 115.482246F;
            clmMovieTitle.HeaderText = "Movie Title";
            clmMovieTitle.Name = "clmMovieTitle";
            // 
            // clmCountry
            // 
            clmCountry.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmCountry.FillWeight = 78.17259F;
            clmCountry.HeaderText = "Country";
            clmCountry.Name = "clmCountry";
            // 
            // clmGenre
            // 
            clmGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmGenre.FillWeight = 78.17259F;
            clmGenre.HeaderText = "Movie Genre";
            clmGenre.Name = "clmGenre";
            // 
            // clmReleaseyear
            // 
            clmReleaseyear.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmReleaseyear.FillWeight = 78.17259F;
            clmReleaseyear.HeaderText = "Year Released";
            clmReleaseyear.Name = "clmReleaseyear";
            // 
            // clmWatched
            // 
            clmWatched.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmWatched.HeaderText = "Watched?";
            clmWatched.Name = "clmWatched";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(361, 184);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(8, 8);
            dataGridView3.TabIndex = 7;
            // 
            // txtAddSearch
            // 
            txtAddSearch.BackColor = Color.FromArgb(183, 201, 242);
            txtAddSearch.BorderStyle = BorderStyle.None;
            txtAddSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddSearch.Location = new Point(426, 72);
            txtAddSearch.Name = "txtAddSearch";
            txtAddSearch.PlaceholderText = "Search movie title";
            txtAddSearch.Size = new Size(164, 19);
            txtAddSearch.TabIndex = 6;
            // 
            // btnAddSearch
            // 
            btnAddSearch.BackgroundImage = Properties.Resources.searchbtn;
            btnAddSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddSearch.FlatAppearance.BorderSize = 0;
            btnAddSearch.FlatStyle = FlatStyle.Flat;
            btnAddSearch.Location = new Point(619, 65);
            btnAddSearch.Name = "btnAddSearch";
            btnAddSearch.Size = new Size(40, 35);
            btnAddSearch.TabIndex = 0;
            btnAddSearch.UseVisualStyleBackColor = true;
            btnAddSearch.Click += btnAddSearch_Click;
            // 
            // panelDeleteMovie
            // 
            panelDeleteMovie.BackColor = Color.FromArgb(44, 62, 80);
            panelDeleteMovie.BackgroundImage = Properties.Resources.deletemovie;
            panelDeleteMovie.Controls.Add(lblNote);
            panelDeleteMovie.Controls.Add(btnDelete);
            panelDeleteMovie.Controls.Add(btnDeleteRefresh);
            panelDeleteMovie.Controls.Add(dgvDeleteMovie);
            panelDeleteMovie.Controls.Add(dataGridView2);
            panelDeleteMovie.Controls.Add(txtDeleteSearch);
            panelDeleteMovie.Controls.Add(btnDeleteSearch);
            panelDeleteMovie.Location = new Point(249, 62);
            panelDeleteMovie.Name = "panelDeleteMovie";
            panelDeleteMovie.Size = new Size(734, 416);
            panelDeleteMovie.TabIndex = 9;
            panelDeleteMovie.Visible = false;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Enabled = false;
            lblNote.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.ForeColor = Color.White;
            lblNote.Location = new Point(34, 383);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(139, 14);
            lblNote.TabIndex = 10;
            lblNote.Text = "(Select movie title to delete)";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(141, 216, 255);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(47, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteRefresh
            // 
            btnDeleteRefresh.BackColor = Color.FromArgb(44, 62, 80);
            btnDeleteRefresh.FlatAppearance.BorderSize = 0;
            btnDeleteRefresh.FlatStyle = FlatStyle.Flat;
            btnDeleteRefresh.Image = Properties.Resources.refreshbtn;
            btnDeleteRefresh.Location = new Point(673, 348);
            btnDeleteRefresh.Margin = new Padding(0);
            btnDeleteRefresh.Name = "btnDeleteRefresh";
            btnDeleteRefresh.Size = new Size(39, 41);
            btnDeleteRefresh.TabIndex = 5;
            btnDeleteRefresh.UseVisualStyleBackColor = false;
            btnDeleteRefresh.Click += btnDeleteRefresh_Click;
            // 
            // dgvDeleteMovie
            // 
            dgvDeleteMovie.AllowUserToResizeRows = false;
            dgvDeleteMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeleteMovie.BackgroundColor = Color.FromArgb(113, 137, 191);
            dgvDeleteMovie.BorderStyle = BorderStyle.None;
            dgvDeleteMovie.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDeleteMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDeleteMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleteMovie.Columns.AddRange(new DataGridViewColumn[] { clmMovieTitleDelete, clmCountryDelete, clmGenreDelete, clmReleaseYearDelete, clmWatchedDelete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(138, 205, 215);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDeleteMovie.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDeleteMovie.EnableHeadersVisualStyles = false;
            dgvDeleteMovie.GridColor = SystemColors.WindowText;
            dgvDeleteMovie.Location = new Point(30, 138);
            dgvDeleteMovie.Name = "dgvDeleteMovie";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(113, 137, 191);
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(138, 205, 215);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDeleteMovie.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDeleteMovie.RowHeadersVisible = false;
            dgvDeleteMovie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeleteMovie.Size = new Size(676, 172);
            dgvDeleteMovie.TabIndex = 8;
            dgvDeleteMovie.TabStop = false;
            dgvDeleteMovie.CellContentClick += dgvDeleteMovie_CellContentClick;
            // 
            // clmMovieTitleDelete
            // 
            clmMovieTitleDelete.HeaderText = "Movie Title";
            clmMovieTitleDelete.Name = "clmMovieTitleDelete";
            // 
            // clmCountryDelete
            // 
            clmCountryDelete.HeaderText = "Country";
            clmCountryDelete.Name = "clmCountryDelete";
            // 
            // clmGenreDelete
            // 
            clmGenreDelete.HeaderText = "Genre";
            clmGenreDelete.Name = "clmGenreDelete";
            // 
            // clmReleaseYearDelete
            // 
            clmReleaseYearDelete.HeaderText = "Year Released";
            clmReleaseYearDelete.Name = "clmReleaseYearDelete";
            // 
            // clmWatchedDelete
            // 
            clmWatchedDelete.HeaderText = "Watched?";
            clmWatchedDelete.Name = "clmWatchedDelete";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(361, 184);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(8, 8);
            dataGridView2.TabIndex = 7;
            // 
            // txtDeleteSearch
            // 
            txtDeleteSearch.BackColor = Color.FromArgb(183, 201, 242);
            txtDeleteSearch.BorderStyle = BorderStyle.None;
            txtDeleteSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeleteSearch.Location = new Point(426, 72);
            txtDeleteSearch.Name = "txtDeleteSearch";
            txtDeleteSearch.PlaceholderText = "Search movie title";
            txtDeleteSearch.Size = new Size(164, 19);
            txtDeleteSearch.TabIndex = 6;
            // 
            // btnDeleteSearch
            // 
            btnDeleteSearch.BackgroundImage = Properties.Resources.searchbtn;
            btnDeleteSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteSearch.FlatAppearance.BorderSize = 0;
            btnDeleteSearch.FlatStyle = FlatStyle.Flat;
            btnDeleteSearch.Location = new Point(619, 65);
            btnDeleteSearch.Name = "btnDeleteSearch";
            btnDeleteSearch.Size = new Size(40, 35);
            btnDeleteSearch.TabIndex = 0;
            btnDeleteSearch.UseVisualStyleBackColor = true;
            btnDeleteSearch.Click += btnDeleteSearch_Click;
            // 
            // panelAddMovieDetails
            // 
            panelAddMovieDetails.BackgroundImage = Properties.Resources.addmoviedetails;
            panelAddMovieDetails.Controls.Add(btnAddMovieDetails);
            panelAddMovieDetails.Controls.Add(txtAddWatched);
            panelAddMovieDetails.Controls.Add(txtAddReleaseYear);
            panelAddMovieDetails.Controls.Add(txtAddGenre);
            panelAddMovieDetails.Controls.Add(txtAddCountry);
            panelAddMovieDetails.Controls.Add(txtAddMovieTitle);
            panelAddMovieDetails.Location = new Point(410, 15);
            panelAddMovieDetails.Name = "panelAddMovieDetails";
            panelAddMovieDetails.Size = new Size(420, 500);
            panelAddMovieDetails.TabIndex = 4;
            panelAddMovieDetails.Visible = false;
            // 
            // btnAddMovieDetails
            // 
            btnAddMovieDetails.BackColor = Color.FromArgb(141, 216, 255);
            btnAddMovieDetails.FlatAppearance.BorderSize = 0;
            btnAddMovieDetails.FlatStyle = FlatStyle.Flat;
            btnAddMovieDetails.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMovieDetails.Location = new Point(157, 420);
            btnAddMovieDetails.Name = "btnAddMovieDetails";
            btnAddMovieDetails.Size = new Size(114, 38);
            btnAddMovieDetails.TabIndex = 5;
            btnAddMovieDetails.Text = "ADD";
            btnAddMovieDetails.UseVisualStyleBackColor = false;
            btnAddMovieDetails.Click += btnAddMovieDetails_Click;
            // 
            // txtAddWatched
            // 
            txtAddWatched.BackColor = Color.FromArgb(183, 201, 242);
            txtAddWatched.BorderStyle = BorderStyle.None;
            txtAddWatched.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddWatched.Location = new Point(156, 339);
            txtAddWatched.Name = "txtAddWatched";
            txtAddWatched.PlaceholderText = "Yes/No";
            txtAddWatched.Size = new Size(216, 18);
            txtAddWatched.TabIndex = 4;
            // 
            // txtAddReleaseYear
            // 
            txtAddReleaseYear.BackColor = Color.FromArgb(183, 201, 242);
            txtAddReleaseYear.BorderStyle = BorderStyle.None;
            txtAddReleaseYear.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddReleaseYear.Location = new Point(155, 283);
            txtAddReleaseYear.Name = "txtAddReleaseYear";
            txtAddReleaseYear.PlaceholderText = "Enter released year";
            txtAddReleaseYear.Size = new Size(216, 18);
            txtAddReleaseYear.TabIndex = 3;
            // 
            // txtAddGenre
            // 
            txtAddGenre.BackColor = Color.FromArgb(183, 201, 242);
            txtAddGenre.BorderStyle = BorderStyle.None;
            txtAddGenre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddGenre.Location = new Point(155, 227);
            txtAddGenre.Name = "txtAddGenre";
            txtAddGenre.PlaceholderText = "Enter genre";
            txtAddGenre.Size = new Size(216, 18);
            txtAddGenre.TabIndex = 2;
            // 
            // txtAddCountry
            // 
            txtAddCountry.BackColor = Color.FromArgb(183, 201, 242);
            txtAddCountry.BorderStyle = BorderStyle.None;
            txtAddCountry.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddCountry.Location = new Point(155, 170);
            txtAddCountry.Name = "txtAddCountry";
            txtAddCountry.PlaceholderText = "Enter country of origin";
            txtAddCountry.Size = new Size(216, 18);
            txtAddCountry.TabIndex = 1;
            // 
            // txtAddMovieTitle
            // 
            txtAddMovieTitle.BackColor = Color.FromArgb(183, 201, 242);
            txtAddMovieTitle.BorderStyle = BorderStyle.None;
            txtAddMovieTitle.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddMovieTitle.Location = new Point(155, 114);
            txtAddMovieTitle.Name = "txtAddMovieTitle";
            txtAddMovieTitle.PlaceholderText = "Enter movie title";
            txtAddMovieTitle.Size = new Size(216, 18);
            txtAddMovieTitle.TabIndex = 0;
            // 
            // panelProfileDetails
            // 
            panelProfileDetails.BackgroundImage = Properties.Resources.profile;
            panelProfileDetails.Controls.Add(btnSeePasswordProfile);
            panelProfileDetails.Controls.Add(txtPasswordProfile);
            panelProfileDetails.Controls.Add(lblUsernameProfile);
            panelProfileDetails.Controls.Add(lblNameProfile);
            panelProfileDetails.Controls.Add(btnDeleteAccProfile);
            panelProfileDetails.Controls.Add(btnLogout);
            panelProfileDetails.Location = new Point(409, 13);
            panelProfileDetails.Name = "panelProfileDetails";
            panelProfileDetails.Size = new Size(420, 504);
            panelProfileDetails.TabIndex = 6;
            panelProfileDetails.Visible = false;
            // 
            // btnSeePasswordProfile
            // 
            btnSeePasswordProfile.BackColor = Color.FromArgb(129, 154, 145);
            btnSeePasswordProfile.BackgroundImage = Properties.Resources.eyeopen;
            btnSeePasswordProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeePasswordProfile.FlatAppearance.BorderSize = 0;
            btnSeePasswordProfile.FlatStyle = FlatStyle.Flat;
            btnSeePasswordProfile.Location = new Point(333, 300);
            btnSeePasswordProfile.Name = "btnSeePasswordProfile";
            btnSeePasswordProfile.Size = new Size(40, 35);
            btnSeePasswordProfile.TabIndex = 14;
            btnSeePasswordProfile.UseVisualStyleBackColor = false;
            btnSeePasswordProfile.Click += btnSeePasswordProfile_Click;
            // 
            // txtPasswordProfile
            // 
            txtPasswordProfile.BackColor = Color.FromArgb(129, 154, 145);
            txtPasswordProfile.BorderStyle = BorderStyle.None;
            txtPasswordProfile.Font = new Font("Arial", 12F);
            txtPasswordProfile.Location = new Point(195, 308);
            txtPasswordProfile.Name = "txtPasswordProfile";
            txtPasswordProfile.Size = new Size(100, 19);
            txtPasswordProfile.TabIndex = 7;
            txtPasswordProfile.UseSystemPasswordChar = true;
            // 
            // lblUsernameProfile
            // 
            lblUsernameProfile.AutoSize = true;
            lblUsernameProfile.BackColor = Color.FromArgb(129, 154, 145);
            lblUsernameProfile.Enabled = false;
            lblUsernameProfile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameProfile.Location = new Point(190, 239);
            lblUsernameProfile.Name = "lblUsernameProfile";
            lblUsernameProfile.Size = new Size(50, 18);
            lblUsernameProfile.TabIndex = 9;
            lblUsernameProfile.Text = "label1";
            // 
            // lblNameProfile
            // 
            lblNameProfile.AutoSize = true;
            lblNameProfile.BackColor = Color.FromArgb(129, 154, 145);
            lblNameProfile.Enabled = false;
            lblNameProfile.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameProfile.Location = new Point(187, 165);
            lblNameProfile.Name = "lblNameProfile";
            lblNameProfile.Size = new Size(50, 18);
            lblNameProfile.TabIndex = 8;
            lblNameProfile.Text = "label1";
            // 
            // btnDeleteAccProfile
            // 
            btnDeleteAccProfile.BackColor = Color.FromArgb(44, 62, 80);
            btnDeleteAccProfile.FlatAppearance.BorderSize = 0;
            btnDeleteAccProfile.FlatStyle = FlatStyle.Flat;
            btnDeleteAccProfile.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteAccProfile.ForeColor = Color.White;
            btnDeleteAccProfile.Location = new Point(162, 437);
            btnDeleteAccProfile.Name = "btnDeleteAccProfile";
            btnDeleteAccProfile.Size = new Size(97, 21);
            btnDeleteAccProfile.TabIndex = 7;
            btnDeleteAccProfile.Text = "Delete Account";
            btnDeleteAccProfile.UseVisualStyleBackColor = false;
            btnDeleteAccProfile.Click += btnDeleteAccProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(141, 216, 255);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(154, 395);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 38);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelDeleteAccount
            // 
            panelDeleteAccount.BackgroundImage = Properties.Resources.deleteacc;
            panelDeleteAccount.Controls.Add(btnSeePasswordDelete);
            panelDeleteAccount.Controls.Add(btnCancel);
            panelDeleteAccount.Controls.Add(btnDeleteAccount);
            panelDeleteAccount.Controls.Add(txtPasswordDeleteAcc);
            panelDeleteAccount.Controls.Add(txtUsernameDeleteAcc);
            panelDeleteAccount.Location = new Point(408, 15);
            panelDeleteAccount.Name = "panelDeleteAccount";
            panelDeleteAccount.Size = new Size(420, 500);
            panelDeleteAccount.TabIndex = 8;
            panelDeleteAccount.Visible = false;
            // 
            // btnSeePasswordDelete
            // 
            btnSeePasswordDelete.BackColor = Color.FromArgb(129, 154, 145);
            btnSeePasswordDelete.BackgroundImage = Properties.Resources.eyeopen;
            btnSeePasswordDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeePasswordDelete.FlatAppearance.BorderSize = 0;
            btnSeePasswordDelete.FlatStyle = FlatStyle.Flat;
            btnSeePasswordDelete.Location = new Point(327, 269);
            btnSeePasswordDelete.Name = "btnSeePasswordDelete";
            btnSeePasswordDelete.Size = new Size(40, 35);
            btnSeePasswordDelete.TabIndex = 15;
            btnSeePasswordDelete.UseVisualStyleBackColor = false;
            btnSeePasswordDelete.Click += btnSeePasswordDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(69, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 38);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.BackColor = Color.FromArgb(141, 216, 255);
            btnDeleteAccount.FlatAppearance.BorderSize = 0;
            btnDeleteAccount.FlatStyle = FlatStyle.Flat;
            btnDeleteAccount.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteAccount.Location = new Point(236, 393);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(114, 38);
            btnDeleteAccount.TabIndex = 8;
            btnDeleteAccount.Text = "DELETE";
            btnDeleteAccount.UseVisualStyleBackColor = false;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // txtPasswordDeleteAcc
            // 
            txtPasswordDeleteAcc.BackColor = Color.FromArgb(129, 154, 145);
            txtPasswordDeleteAcc.BorderStyle = BorderStyle.None;
            txtPasswordDeleteAcc.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasswordDeleteAcc.ForeColor = Color.Black;
            txtPasswordDeleteAcc.Location = new Point(183, 277);
            txtPasswordDeleteAcc.Margin = new Padding(0);
            txtPasswordDeleteAcc.Name = "txtPasswordDeleteAcc";
            txtPasswordDeleteAcc.PlaceholderText = "Enter password";
            txtPasswordDeleteAcc.Size = new Size(171, 19);
            txtPasswordDeleteAcc.TabIndex = 7;
            txtPasswordDeleteAcc.UseSystemPasswordChar = true;
            // 
            // txtUsernameDeleteAcc
            // 
            txtUsernameDeleteAcc.BackColor = Color.FromArgb(129, 154, 145);
            txtUsernameDeleteAcc.BorderStyle = BorderStyle.None;
            txtUsernameDeleteAcc.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsernameDeleteAcc.ForeColor = Color.Black;
            txtUsernameDeleteAcc.Location = new Point(183, 183);
            txtUsernameDeleteAcc.Margin = new Padding(0);
            txtUsernameDeleteAcc.Name = "txtUsernameDeleteAcc";
            txtUsernameDeleteAcc.PlaceholderText = "Enter username";
            txtUsernameDeleteAcc.Size = new Size(171, 19);
            txtUsernameDeleteAcc.TabIndex = 6;
            // 
            // panelUpdateMovieDetails2
            // 
            panelUpdateMovieDetails2.BackgroundImage = Properties.Resources.updatedetails;
            panelUpdateMovieDetails2.Controls.Add(btnSaveChanges);
            panelUpdateMovieDetails2.Controls.Add(txtNewWatched);
            panelUpdateMovieDetails2.Controls.Add(txtNewReleasedYear);
            panelUpdateMovieDetails2.Controls.Add(txtNewGenre);
            panelUpdateMovieDetails2.Controls.Add(txtNewCountry);
            panelUpdateMovieDetails2.Controls.Add(txtNewMovieTitle);
            panelUpdateMovieDetails2.Location = new Point(0, 107);
            panelUpdateMovieDetails2.Name = "panelUpdateMovieDetails2";
            panelUpdateMovieDetails2.Size = new Size(422, 398);
            panelUpdateMovieDetails2.TabIndex = 6;
            panelUpdateMovieDetails2.Visible = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(141, 216, 255);
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.Location = new Point(152, 336);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(114, 38);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtNewWatched
            // 
            txtNewWatched.BackColor = Color.FromArgb(183, 201, 242);
            txtNewWatched.BorderStyle = BorderStyle.None;
            txtNewWatched.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewWatched.Location = new Point(176, 254);
            txtNewWatched.Name = "txtNewWatched";
            txtNewWatched.PlaceholderText = "Yes/No";
            txtNewWatched.Size = new Size(216, 18);
            txtNewWatched.TabIndex = 5;
            // 
            // txtNewReleasedYear
            // 
            txtNewReleasedYear.BackColor = Color.FromArgb(183, 201, 242);
            txtNewReleasedYear.BorderStyle = BorderStyle.None;
            txtNewReleasedYear.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewReleasedYear.Location = new Point(176, 198);
            txtNewReleasedYear.Name = "txtNewReleasedYear";
            txtNewReleasedYear.PlaceholderText = "Enter new released year";
            txtNewReleasedYear.Size = new Size(216, 18);
            txtNewReleasedYear.TabIndex = 4;
            // 
            // txtNewGenre
            // 
            txtNewGenre.BackColor = Color.FromArgb(183, 201, 242);
            txtNewGenre.BorderStyle = BorderStyle.None;
            txtNewGenre.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewGenre.Location = new Point(176, 141);
            txtNewGenre.Name = "txtNewGenre";
            txtNewGenre.PlaceholderText = "Enter new genre";
            txtNewGenre.Size = new Size(216, 18);
            txtNewGenre.TabIndex = 3;
            // 
            // txtNewCountry
            // 
            txtNewCountry.BackColor = Color.FromArgb(183, 201, 242);
            txtNewCountry.BorderStyle = BorderStyle.None;
            txtNewCountry.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewCountry.ForeColor = Color.Black;
            txtNewCountry.Location = new Point(176, 85);
            txtNewCountry.Name = "txtNewCountry";
            txtNewCountry.PlaceholderText = "Enter new country of origin";
            txtNewCountry.Size = new Size(216, 18);
            txtNewCountry.TabIndex = 2;
            // 
            // txtNewMovieTitle
            // 
            txtNewMovieTitle.BackColor = Color.FromArgb(183, 201, 242);
            txtNewMovieTitle.BorderStyle = BorderStyle.None;
            txtNewMovieTitle.Enabled = false;
            txtNewMovieTitle.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewMovieTitle.Location = new Point(175, 28);
            txtNewMovieTitle.Name = "txtNewMovieTitle";
            txtNewMovieTitle.PlaceholderText = "Enter movie title";
            txtNewMovieTitle.Size = new Size(216, 18);
            txtNewMovieTitle.TabIndex = 1;
            // 
            // panelUpdateMovieDetails1
            // 
            panelUpdateMovieDetails1.BackgroundImage = Properties.Resources.updatesearch;
            panelUpdateMovieDetails1.Controls.Add(btnSearchUpdateMovie);
            panelUpdateMovieDetails1.Controls.Add(txtSearchUpdateMovie);
            panelUpdateMovieDetails1.Controls.Add(panelUpdateMovieDetails2);
            panelUpdateMovieDetails1.Location = new Point(407, 13);
            panelUpdateMovieDetails1.Margin = new Padding(0);
            panelUpdateMovieDetails1.Name = "panelUpdateMovieDetails1";
            panelUpdateMovieDetails1.Size = new Size(422, 505);
            panelUpdateMovieDetails1.TabIndex = 0;
            panelUpdateMovieDetails1.Visible = false;
            // 
            // btnSearchUpdateMovie
            // 
            btnSearchUpdateMovie.BackgroundImage = Properties.Resources.searchbtn;
            btnSearchUpdateMovie.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchUpdateMovie.FlatAppearance.BorderSize = 0;
            btnSearchUpdateMovie.FlatStyle = FlatStyle.Flat;
            btnSearchUpdateMovie.Location = new Point(315, 68);
            btnSearchUpdateMovie.Name = "btnSearchUpdateMovie";
            btnSearchUpdateMovie.Size = new Size(40, 33);
            btnSearchUpdateMovie.TabIndex = 10;
            btnSearchUpdateMovie.UseVisualStyleBackColor = true;
            btnSearchUpdateMovie.Click += btnSearchUpdateMovie_Click;
            // 
            // txtSearchUpdateMovie
            // 
            txtSearchUpdateMovie.BackColor = Color.FromArgb(183, 201, 242);
            txtSearchUpdateMovie.BorderStyle = BorderStyle.None;
            txtSearchUpdateMovie.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchUpdateMovie.Location = new Point(70, 75);
            txtSearchUpdateMovie.Name = "txtSearchUpdateMovie";
            txtSearchUpdateMovie.PlaceholderText = "Search movie title";
            txtSearchUpdateMovie.Size = new Size(227, 19);
            txtSearchUpdateMovie.TabIndex = 10;
            // 
            // MovieLibraryDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1030, 537);
            Controls.Add(panelDeleteAccount);
            Controls.Add(panelAddMovieDetails);
            Controls.Add(panelProfileDetails);
            Controls.Add(panelMovieList);
            Controls.Add(panelDeleteMovie);
            Controls.Add(panelUpdateMovieDetails1);
            Controls.Add(panelHome);
            Controls.Add(panelManageLibrary);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovieLibraryDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovieLibraryDashboard";
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            panelManageLibrary.ResumeLayout(false);
            panelMovieList.ResumeLayout(false);
            panelMovieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovieList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panelDeleteMovie.ResumeLayout(false);
            panelDeleteMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleteMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelAddMovieDetails.ResumeLayout(false);
            panelAddMovieDetails.PerformLayout();
            panelProfileDetails.ResumeLayout(false);
            panelProfileDetails.PerformLayout();
            panelDeleteAccount.ResumeLayout(false);
            panelDeleteAccount.PerformLayout();
            panelUpdateMovieDetails2.ResumeLayout(false);
            panelUpdateMovieDetails2.PerformLayout();
            panelUpdateMovieDetails1.ResumeLayout(false);
            panelUpdateMovieDetails1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHome;
        private Button btnManageLibrary;
        private ComboBox cmbMovieGenres;
        private Button btnProfile;
        private Panel panelManageLibrary;
        private Button btnAddMovie;
        private Button btnHome;
        private Panel panelMovieList;
        private Button btnAddSearch;
        private TextBox txtAddSearch;
        private Panel panelAddMovieDetails;
        private TextBox txtAddMovieTitle;
        private Button btnAddMovieDetails;
        private TextBox txtAddWatched;
        private TextBox txtAddReleaseYear;
        private TextBox txtAddGenre;
        private TextBox txtAddCountry;
        private DataGridView dataGridView3;
        private DataGridView dgvMovieList;
        private Button btnMovieList;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn clmMovieTitle;
        private DataGridViewTextBoxColumn clmCountry;
        private DataGridViewTextBoxColumn clmGenre;
        private DataGridViewTextBoxColumn clmReleaseyear;
        private DataGridViewTextBoxColumn clmWatched;
        private Button btnDeleteMovie;
        private Button btnUpdateMovieDetails;
        private Panel panelProfileDetails;
        private Button btnLogout;
        private Button btnDeleteAccProfile;
        private Panel panelDeleteAccount;
        private TextBox txtUsernameDeleteAcc;
        private TextBox txtPasswordDeleteAcc;
        private Button btnCancel;
        private Button btnDeleteAccount;
        private Label lblNameProfile;
        private Label lblPasswordProfile;
        private Label lblUsernameProfile;
        private Label lblProfileName;
        private Panel panelDeleteMovie;
        private Button btnDeleteRefresh;
        private DataGridView dgvDeleteMovie;
        private DataGridView dataGridView2;
        private TextBox txtDeleteSearch;
        private Button btnDeleteSearch;
        private DataGridViewTextBoxColumn clmMovieTitleDelete;
        private DataGridViewTextBoxColumn clmCountryDelete;
        private DataGridViewTextBoxColumn clmGenreDelete;
        private DataGridViewTextBoxColumn clmReleaseYearDelete;
        private DataGridViewTextBoxColumn clmWatchedDelete;
        private Button btnDelete;
        private Label lblNote;
        private TextBox txtPasswordProfile;
        private Panel panelUpdateMovieDetails2;
        private Panel panelUpdateMovieDetails1;
        private Button btnSearchUpdateMovie;
        private TextBox txtSearchUpdateMovie;
        private TextBox txtNewWatched;
        private TextBox txtNewReleasedYear;
        private TextBox txtNewGenre;
        private TextBox txtNewCountry;
        private TextBox txtNewMovieTitle;
        private Button btnSaveChanges;
        private Button btnSeePasswordProfile;
        private Button btnSeePasswordDelete;
    }
}