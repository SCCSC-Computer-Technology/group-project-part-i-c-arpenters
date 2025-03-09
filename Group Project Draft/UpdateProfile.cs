using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_Draft
{
    public partial class UpdateProfile : Form
    {

        private string connectionString = "Data Source=UserDatabase.db;Version=3;";
        private string currentUsername; // Store the logged-in username

        public UpdateProfile(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserData(); // Load user data when the form opens
        }

        private void LoadUserData()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT username, email, favorite_sport FROM Users WHERE username = @username";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", currentUsername);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nameBox.Text = reader["username"].ToString();
                            emailBox.Text = reader["email"].ToString();
                            sportBox.SelectedItem = reader["favorite_sport"].ToString();
                        }
                    }
                }
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DebugUsernameCheck(); // 🚀 Call the debug check


            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                Console.WriteLine($"Current Username Before Update: '{currentUsername}'"); // Debugging line

                using (SQLiteCommand testCmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE username = @currentUsername", conn))
                {
                    testCmd.Parameters.AddWithValue("@currentUsername", currentUsername);
                    int count = Convert.ToInt32(testCmd.ExecuteScalar());
                    Console.WriteLine($"Matching users: {count}");

                    if (count == 0)
                    {
                        MessageBox.Show("Username not found in the database.");
                        return;
                    }
                }

                // Proceed with the update process...
            }
        }

        private void DebugUsernameCheck()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT username FROM Users WHERE username = @currentUsername", conn))
                {
                    cmd.Parameters.AddWithValue("@currentUsername", currentUsername);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show($"Username exists in database: '{result.ToString()}'", "Debug Check");
                    }
                    else
                    {
                        MessageBox.Show($"Username '{currentUsername}' NOT found. Check for spaces or case issues!", "Error");
                    }
                }
            }
        }

        private void ShowAllUsernames()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand("SELECT username FROM Users", conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        List<string> usernames = new List<string>();

                        while (reader.Read())
                        {
                            usernames.Add(reader["username"].ToString());
                        }

                        if (usernames.Count > 0)
                        {
                            MessageBox.Show("Usernames in Database:\n\n" + string.Join("\n", usernames), "All Usernames");
                        }
                        else
                        {
                            MessageBox.Show("No usernames found in the database.", "Database Check");
                        }
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


