using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* C#arpenters Group Project
 * CPT 206 - Brandon Hines, Caleb Thompson, Kara Crumpton
 * Sports Stats Application
 * Pics from freepik.com, Wikipedia, and OpenArt AI
 * Sound effects from YouTube
 */

namespace Group_Project_Draft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Setting up the stuff so it looks cool
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            logBtn.BackColor = Color.Transparent;
            logBtn.FlatStyle = FlatStyle.Flat;  
            logBtn.FlatAppearance.BorderSize = 0;  
            createBtn.BackColor = Color.Transparent;
            createBtn.FlatStyle = FlatStyle.Flat;  
            createBtn.FlatAppearance.BorderSize = 0;  
            exitBtn.BackColor = Color.Transparent;
            exitBtn.FlatStyle = FlatStyle.Flat;  
            exitBtn.FlatAppearance.BorderSize = 0;  

        }

        // Users go here to make a new account
        private void createBtn_Click(object sender, EventArgs e)
        {
            Create createAccount = new Create();
            createAccount.ShowDialog();
        }

        // Log in if you already have an account
        private void logBtn_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string password = passBox.Text;

            // Check to make sure the username and password match
            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Sports sportsForm = new Sports(username);
                sportsForm.ShowDialog();
            }
            // Error if it's wrong
            else
            {
                MessageBox.Show("Invalid username or password.", "Failure!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Doin' the security stuff for the password. 
        private static string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Checking with the database and doing the smart stuff...
        private bool ValidateLogin(string username, string password)
        {
            string connectionString = "Data Source=UserDatabase.db;Version=3;";
            string hashedPassword = HashPassword(password); 

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE username=@username AND password_hash=@password";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
