using Microsoft.VisualBasic.Devices;
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
    public partial class MovieLibraryDashboard : Form
    {
        static MovieLibraryProcess movielibraryprocess = new MovieLibraryProcess();
        public static Account userAccount;
        static bool loggedin = false;


        public MovieLibraryDashboard()
        {
            InitializeComponent();
            lblProfileName.Text = userAccount.Name;
            InitializeGenreMoviecbx();

        }


        //MovieLibraryHome
        private void btnManageLibrary_Click(object sender, EventArgs e)
        {
            panelProfileDetails.Visible = false;
            panelDeleteAccount.Visible = false;
            panelManageLibrary.Visible = true;
            panelHome.Visible = false;
            panelHome.BringToFront();
        }

        private void cmbMovieGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovieGenres.SelectedItem != null)
            {
                string selectedGenre = cmbMovieGenres.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(selectedGenre))
                    return;

                var genre = movielibraryprocess.GetGenreRecommendations().FirstOrDefault(g => g.Name.Equals(selectedGenre));
                if (genre != null)
                {
                    string movies = string.Join("\n", genre.Movies);
                    MessageBox.Show("Movies under" + " " + selectedGenre + ":" + "\n\n" + movies, "MOVIE RECOMMENDATION", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            lblNameProfile.Text = userAccount.Name;
            lblUsernameProfile.Text = userAccount.Username;
            txtPasswordProfile.Text = userAccount.Password;

            panelDeleteAccount.Visible = false;
            panelMovieList.Visible = false;
            panelHome.Visible = true;
            panelProfileDetails.Visible = true;
            panelProfileDetails.BringToFront();
        }


        //ManageLibrary
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelDeleteAccount.Visible = false;
            panelMovieList.Visible = false;
            panelUpdateMovieDetails1.Visible = false;
            panelAddMovieDetails.Visible = false;
            panelManageLibrary.Visible = false;
            panelDeleteMovie.Visible = false;
            panelHome.BringToFront();
        }

        private void btnMovieList_Click(object sender, EventArgs e)
        {
            panelProfileDetails.Visible = false;
            panelMovieList.Visible = false;
            panelAddMovieDetails.Visible = false;
            panelManageLibrary.Visible = true;
            panelMovieList.Visible = true;
            panelDeleteMovie.Visible = false;
            panelMovieList.BringToFront();
            LoadMovieListTable();

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            panelProfileDetails.Visible = false;
            panelAddMovieDetails.Visible = true;
            panelManageLibrary.Visible = true;
            panelMovieList.Visible = false;
            panelDeleteMovie.Visible = false;
            panelAddMovieDetails.BringToFront();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            panelDeleteMovie.Visible = true;
            panelManageLibrary.Visible = true;
            panelUpdateMovieDetails1.Visible = false;
            panelAddMovieDetails.Visible = false;
            panelMovieList.Visible = false;
            panelDeleteMovie.BringToFront();
            LoadDeleteMovieTable();
        }

        private void btnUpdateMovieDetails_Click(object sender, EventArgs e)
        {
            panelUpdateMovieDetails1.Visible = true;
            panelManageLibrary.Visible = true;
            panelDeleteMovie.Visible = false;
            panelAddMovieDetails.Visible = false;
            panelMovieList.Visible = false;
            panelUpdateMovieDetails1.BringToFront();
        }


        //panel for movielist

        private void LoadMovieListTable()
        {
            string userName = userAccount.Username;
            var movies = movielibraryprocess.GetMovieList(userName);

            dgvMovieList.Columns.Clear();
            dgvMovieList.DataSource = movies.Select(movielist => new
            {
                movielist.Title,
                movielist.Country,
                movielist.Genre,
                movielist.ReleaseYear,
                movielist.Watched
            }).ToList();

            dgvMovieList.Columns[0].HeaderText = "Movie Title";
            dgvMovieList.Columns[1].HeaderText = "Country";
            dgvMovieList.Columns[2].HeaderText = "Movie Genre";
            dgvMovieList.Columns[3].HeaderText = "Year Released";
            dgvMovieList.Columns[4].HeaderText = "Watched?";
        }

        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = txtAddSearch.Text.Trim();
            string userName = userAccount.Username;
            var movielist = movielibraryprocess.SearchMovie(userName, searchTitle);

            dgvMovieList.Columns.Clear();

            if (movielist != null)
            {
                dgvMovieList.DataSource = new List<object>
            {
                new
                {
                movielist.Title,
                movielist.Country,
                movielist.Genre,
                movielist.ReleaseYear,
                movielist.Watched
                }
                };

                dgvMovieList.Columns[0].HeaderText = "Movie Title";
                dgvMovieList.Columns[1].HeaderText = "Country";
                dgvMovieList.Columns[2].HeaderText = "Movie Genre";
                dgvMovieList.Columns[3].HeaderText = "Year Released";
                dgvMovieList.Columns[4].HeaderText = "Watched?";
            }
            else
            {
                MessageBox.Show(searchTitle + " is not in the list.");
                dgvMovieList.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string userName = userAccount.Username;

            var movies = movielibraryprocess.GetMovieList(userName);

            dgvMovieList.Columns.Clear();
            dgvMovieList.AutoGenerateColumns = true;
            dgvMovieList.DataSource = movies.Select(movielist => new
            {
                movielist.Title,
                movielist.Country,
                movielist.Genre,
                movielist.ReleaseYear,
                movielist.Watched
            }).ToList();

            dgvMovieList.Columns[0].HeaderText = "Movie Title";
            dgvMovieList.Columns[1].HeaderText = "Country";
            dgvMovieList.Columns[2].HeaderText = "Movie Genre";
            dgvMovieList.Columns[3].HeaderText = "Year Released";
            dgvMovieList.Columns[4].HeaderText = "Watched?";
            txtAddSearch.Clear();
        }

        //panel for addmoviedetails
        private void btnAddMovieDetails_Click(object sender, EventArgs e)
        {
            string movieTitle = txtAddMovieTitle.Text.Trim();
            string country = txtAddCountry.Text.Trim();
            string genre = txtAddGenre.Text.Trim();
            string releaseYear = txtAddReleaseYear.Text.Trim();
            string watched = txtAddWatched.Text.Trim();
            string userName = userAccount.Username;


            if (string.IsNullOrWhiteSpace(movieTitle) ||
                string.IsNullOrWhiteSpace(country) ||
                string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(releaseYear) ||
                string.IsNullOrWhiteSpace(watched))
            {
                MessageBox.Show("Please fill in all the fields before adding the movie.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            movielibraryprocess.AddMovie(userName, movieTitle, country, genre, releaseYear, watched);
            MessageBox.Show(movieTitle + " Added Successfully!!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.None);


            txtAddMovieTitle.Clear();
            txtAddCountry.Clear();
            txtAddGenre.Clear();
            txtAddReleaseYear.Clear();
            txtAddWatched.Clear();
            panelAddMovieDetails.Visible = false;
            panelDeleteAccount.Visible = false;
        }

        //panel for profiledetails
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FirstFrame firstframe = new FirstFrame();
                firstframe.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Logout cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteAccProfile_Click(object sender, EventArgs e)
        {
            panelMovieList.Visible = false;
            panelProfileDetails.Visible = false;
            panelDeleteAccount.Visible = true;
            panelManageLibrary.Visible = true;
            panelDeleteAccount.BringToFront();
        }

        private void btnSeePasswordProfile_Click(object sender, EventArgs e)
        {
            txtPasswordProfile.UseSystemPasswordChar = !txtPasswordProfile.UseSystemPasswordChar;

            if (!txtPasswordProfile.UseSystemPasswordChar)
            {
                txtPasswordProfile.BackgroundImage = Properties.Resources.eyeclose;
            }
            else
            {
                txtPasswordProfile.BackgroundImage = Properties.Resources.eyeopen;
            }
        }

        //panel for delete account
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (userAccount == null)
            {
                userAccount = SigninSignup.userAccount;
            }

            string inputUsername = txtUsernameDeleteAcc.Text.Trim();
            string inputPassword = txtPasswordDeleteAcc.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool deleted = movielibraryprocess.DeleteAccount(inputUsername, inputPassword);

                if (deleted)
                {
                    MessageBox.Show("Account has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loggedin = false;
                    userAccount = null;

                    FirstFrame firstFrame = new FirstFrame();
                    firstFrame.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password. Unable to delete account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsernameDeleteAcc.Clear();
            txtPasswordDeleteAcc.Clear();
            panelDeleteAccount.Visible = false;
        }

        private void btnSeePasswordDelete_Click(object sender, EventArgs e)
        {
            txtPasswordDeleteAcc.UseSystemPasswordChar = !txtPasswordDeleteAcc.UseSystemPasswordChar;

            if (!txtPasswordDeleteAcc.UseSystemPasswordChar)
            {
                btnSeePasswordDelete.BackgroundImage = Properties.Resources.eyeclose;
            }
            else
            {
                btnSeePasswordDelete.BackgroundImage = Properties.Resources.eyeopen;
            }
        }

        //panel for delete movie
        private void dgvDeleteMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //table for movielist for delete movie
            string userName = SigninSignup.userAccount.Username;
            var movies = movielibraryprocess.GetMovieList(userName);
            dgvDeleteMovie.Columns.Clear();
            dgvDeleteMovie.DataSource = movies.Select(movielist => new
            {
                movielist.Title,
                movielist.Country,
                movielist.Genre,
                movielist.ReleaseYear,
                movielist.Watched
            }).ToList();

            dgvDeleteMovie.Columns[0].HeaderText = "Movie Title";
            dgvDeleteMovie.Columns[1].HeaderText = "Country";
            dgvDeleteMovie.Columns[2].HeaderText = "Movie Genre";
            dgvDeleteMovie.Columns[3].HeaderText = "Year Released";
            dgvDeleteMovie.Columns[4].HeaderText = "Watched?";
        }

        private void btnDeleteSearch_Click(object sender, EventArgs e)
        {
            string searchTitle = txtDeleteSearch.Text.Trim();
            string userName = userAccount.Username;
            var movielist = movielibraryprocess.SearchMovie(userName, searchTitle);

            dgvDeleteMovie.Columns.Clear();

            if (movielist != null)
            {
                dgvDeleteMovie.DataSource = new List<object>
            {
                new
                {
                movielist.Title,
                movielist.Country,
                movielist.Genre,
                movielist.ReleaseYear,
                movielist.Watched
                }
                };

                dgvDeleteMovie.Columns[0].HeaderText = "Movie Title";
                dgvDeleteMovie.Columns[1].HeaderText = "Country";
                dgvDeleteMovie.Columns[2].HeaderText = "Movie Genre";
                dgvDeleteMovie.Columns[3].HeaderText = "Year Released";
                dgvDeleteMovie.Columns[4].HeaderText = "Watched?";
            }
            else
            {
                MessageBox.Show(searchTitle + " is not in the list.");
                dgvDeleteMovie.DataSource = null;
            }
        }

        private void btnDeleteRefresh_Click(object sender, EventArgs e)
        {
            string userName = userAccount.Username;

            var movies = movielibraryprocess.GetMovieList(userName);

            dgvDeleteMovie.Columns.Clear();
            dgvDeleteMovie.AutoGenerateColumns = true;
            dgvDeleteMovie.DataSource = movies.Select(movielist => new
            {
                movielist.Title,
                movielist.Country,
                movielist.Genre,
                movielist.ReleaseYear,
                movielist.Watched
            }).ToList();

            dgvDeleteMovie.Columns[0].HeaderText = "Movie Title";
            dgvDeleteMovie.Columns[1].HeaderText = "Country";
            dgvDeleteMovie.Columns[2].HeaderText = "Movie Genre";
            dgvDeleteMovie.Columns[3].HeaderText = "Year Released";
            dgvDeleteMovie.Columns[4].HeaderText = "Watched?";
            txtDeleteSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteMovie = dgvDeleteMovie.CurrentRow.Cells["Title"].Value.ToString();
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete " + deleteMovie + "?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = movielibraryprocess.DeleteMovie(userAccount.Username, deleteMovie);

                if (deleted)
                {
                    MessageBox.Show(deleteMovie + " has been deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(null, null);
                }
            }
        }
        private void LoadDeleteMovieTable()
        {
            string userName = userAccount.Username;
            var movies = movielibraryprocess.GetMovieList(userName);

            dgvDeleteMovie.Columns.Clear();
            dgvDeleteMovie.DataSource = movies.Select(movielist => new
            {
                movielist.Title,
                movielist.Country,
                movielist.Genre,
                movielist.ReleaseYear,
                movielist.Watched
            }).ToList();

            dgvDeleteMovie.Columns[0].HeaderText = "Movie Title";
            dgvDeleteMovie.Columns[1].HeaderText = "Country";
            dgvDeleteMovie.Columns[2].HeaderText = "Movie Genre";
            dgvDeleteMovie.Columns[3].HeaderText = "Year Released";
            dgvDeleteMovie.Columns[4].HeaderText = "Watched?";
        }

        //panel for update movie details
        private void btnSearchUpdateMovie_Click(object sender, EventArgs e)
        {
            {
                string searchTitle = txtSearchUpdateMovie.Text.Trim();
                string userName = userAccount.Username;

                var movie = movielibraryprocess.SearchMovie(userName, searchTitle);

                if (movie == null)
                {
                    MessageBox.Show(searchTitle + " is not in the list.", "Movie Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                panelUpdateMovieDetails2.Visible = true;
                panelUpdateMovieDetails2.BringToFront();

                txtNewMovieTitle.Text = movie.Title;
                txtNewCountry.Text = movie.Country;
                txtNewGenre.Text = movie.Genre;
                txtNewReleasedYear.Text = movie.ReleaseYear;
                txtNewWatched.Text = movie.Watched;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string movieTitle = txtNewMovieTitle.Text.Trim();
            string country = txtNewCountry.Text.Trim();
            string genre = txtNewGenre.Text.Trim();
            string releaseYear = txtNewReleasedYear.Text.Trim();
            string watched = txtNewWatched.Text.Trim();
            string userName = userAccount.Username;

            if (string.IsNullOrWhiteSpace(movieTitle) ||
                string.IsNullOrWhiteSpace(country) ||
                string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(releaseYear) ||
                string.IsNullOrWhiteSpace(watched))
            {
                MessageBox.Show("Please fill in all the fields before saving the changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updatedMovie = movielibraryprocess.UpdateMovieDetails(userName, movieTitle, country, genre, releaseYear, watched);

            if (updatedMovie != null)
            {
                MessageBox.Show("Changes have been saved successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSearchUpdateMovie.Clear();
                txtNewMovieTitle.Clear();
                txtNewCountry.Clear();
                txtNewGenre.Clear();
                txtNewReleasedYear.Clear();
                txtNewWatched.Clear();
                panelUpdateMovieDetails2.Visible = false;
            }
        }

        //additional methods for movie genre
        private void InitializeGenreMoviecbx()
        {
            cmbMovieGenres.Items.Clear();

            var genres = movielibraryprocess.GetGenreRecommendations();

            foreach (var genre in genres)
            {
                cmbMovieGenres.Items.Add(genre.Name);
            }
        }
    }
}




