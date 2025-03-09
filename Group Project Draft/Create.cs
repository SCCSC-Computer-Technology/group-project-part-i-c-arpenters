using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

/* C#arpenters Group Project
 * CPT 206 - Brandon Hines, Caleb Thompson, Kara Crumpton
 * Sports Stats Application
 * Pics from freepik.com, Wikipedia, and OpenArt AI
 */

namespace Group_Project_Draft
{
    public partial class Create : Form
    {
        // Path for the user database. It's in the Debug Folder
        private string connectionString = "Data Source=UserDatabase.db;Version=3;";

        public Create()
        {
            InitializeComponent();
            CreateDatabase();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            sportLabel.BackColor = Color.Transparent;
            createBtn.BackColor = Color.Transparent;
            createBtn.ForeColor = Color.White;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.FlatAppearance.BorderSize = 0;
            backBtn.BackColor = Color.Transparent;
            backBtn.ForeColor = Color.White;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.FlatAppearance.BorderSize = 0;
        }

        // Create the database entry if it doesn't exist 
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
                                    favorite_sport TEXT
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

        // Store the user info in the database
        private void createBtn_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string email = emailBox.Text;
            string password = passBox.Text;
            string confirm = passBox2.Text;
            string favoriteSport = sportBox.SelectedItem?.ToString();  // Had to look this up, was getting an error if they left it blank. For whatever reason, the "?" fixed it.

            // Check if all fields are filled, error if not
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(favoriteSport))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Validate if the passwords match
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // Update the user's favorite sport in the database
            UpdateFavoriteSport(username, favoriteSport);

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string hashedPassword = HashPassword(password);

            // Database stuff
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

        // Update the user's favorite sport
        private void UpdateFavoriteSport(string username, string favoriteSport)
        {
            string connectionString = "Data Source=UserDatabase.db;Version=3;"; 
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

