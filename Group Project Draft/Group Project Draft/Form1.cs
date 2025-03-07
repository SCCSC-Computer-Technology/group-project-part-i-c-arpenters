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
 */

namespace Group_Project_Draft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Create createAccount = new Create();
            createAccount.ShowDialog();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string username = nameBox.Text;
            string password = passBox.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Sports sportsForm = new Sports(username);
                sportsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Failure!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string connectionString = "Data Source=UserDatabase.db;Version=3;";
            string hashedPassword = HashPassword(password); // Hash input to compare

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
