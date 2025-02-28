using System;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Group_Project_Draft
{
    public partial class Create : Form
    {
        // Path to store the SQLite database in the Debug folder
        private string connectionString = "Data Source=UserDatabase.db;Version=3;";

        public Create()
        {
            InitializeComponent();
            CreateDatabase(); // Ensures the database and table exist
        }

        // Create the database file and Users table if they don't exist
        private void CreateDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = @"CREATE TABLE IF NOT EXISTS Users (
                                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    username TEXT UNIQUE,
                                    email TEXT,
                                    password_hash TEXT
                                );";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Hash password
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Insert user into database
        private void createBtn_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string email = emailBox.Text;
            string password = passBox.Text;
            string confirm = passBox2.Text;
            string favoriteSport = sportBox.SelectedItem.ToString();  // Get selected sport

            // Update the user's favorite sport in the database
            UpdateFavoriteSport(username, favoriteSport);

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Users (username, email, password_hash) VALUES (@username, @email, @password)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created successfully!");

                        UpdateFavoriteSport(username, favoriteSport);
                        this.Close();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateFavoriteSport(string username, string favoriteSport)
        {
            string connectionString = "Data Source=UserDatabase.db;Version=3;"; // Update with your database path
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET favorite_sport = @favoriteSport WHERE username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@favoriteSport", favoriteSport);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

