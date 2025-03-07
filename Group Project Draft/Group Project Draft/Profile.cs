using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_Draft
{
    public partial class Profile : Form
    {
        private string connectionString = "Data Source=UserDatabase.db;Version=3;";
        private string currentUsername;

        public Profile(string username)
        {
            InitializeComponent();
            currentUsername = username; // Store the logged-in username
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT username, email, favorite_sport, favorite_team FROM Users WHERE username = @username";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", currentUsername);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblUsername.Text = "Username: " + reader["username"].ToString();
                            lblEmail.Text = "Email: " + reader["email"].ToString();
                            cmbFavoriteSport.Text = reader["favorite_sport"].ToString();
                            cmbFavoriteTeam.Text = reader["favorite_team"].ToString();
                        }
                    }
                }
            }
        }

        private void cmbFavoriteSport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFavoriteSport.SelectedItem != null && cmbFavoriteSport.SelectedItem.ToString() == "Lacrosse")
            {
                LoadLacrosseTeams();
            }
        }

        private void LoadLacrosseTeams()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT TeamName FROM dbo.[pll-team-stats]";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    cmbFavoriteTeam.Items.Clear();
                    while (reader.Read())
                    {
                        cmbFavoriteTeam.Items.Add(reader["TeamName"].ToString());
                    }
                }
            }
        }


        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string newSport = cmbFavoriteSport.SelectedItem?.ToString();
            string newTeam = cmbFavoriteTeam.SelectedItem?.ToString();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET favorite_sport = @sport, favorite_team = @team WHERE username = @username";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sport", newSport);
                    cmd.Parameters.AddWithValue("@team", newTeam);
                    cmd.Parameters.AddWithValue("@username", currentUsername);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Profile updated successfully!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
