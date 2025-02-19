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
    public partial class Sports : Form
    {
        private string currentUsername;
        public Sports(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserData();
        }

        
        private void LoadUserData()
        {
            string connectionString = "Data Source=UserDatabase.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT favorite_sport FROM Users WHERE username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", currentUsername);
                    var result = cmd.ExecuteScalar(); // Gets the favorite sport

                    titleLabel.Text = $"Hello, {currentUsername}! \nWelcome to the C#arpenters Sports Application!";

                    // Check if the result is null or empty
                    if (result != null)
                    {
                        string favoriteSport = result.ToString();

                        // Tailor the page based on the favorite sport
                        if (favoriteSport == "Basketball")
                        {
                            SetBasketballTheme();
                        }
                        else if (favoriteSport == "Lacrosse")
                        {
                            SetLacrosseTheme();
                        }
                        else if (favoriteSport == "Midget Wrestling")
                        {
                            SetWrestlingTheme();

                        }
                        else
                        {
                            // Don't really need this... but it's here anyway
                            this.BackColor = Color.Gray; // Default background
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favorite sport not found for user.");
                    }
                }
            }
        }

        private void SetBasketballTheme()
        {
            this.BackColor = Color.Blue;
            titleLabel.ForeColor = Color.White;
            infoLabel.ForeColor = Color.White;
            otherLabel.ForeColor = Color.White;
            infoLabel.Text = "Current Basketball Schedule:";
            ballBtn.Visible = false;
            weirdBtn.Location = new Point(914, 589);
            midgetBtn.Location = new Point(496, 589);
            midgetBtn.Visible = true;
            lacrosseBtn.Visible = true;
            lacrosseBtn.Location = new Point(708, 589);
            string imagePath = Application.StartupPath + @"\basketball.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            eventBox.Items.Clear();
            eventBox.Items.Add("Basketball Schedule will show here.");
        }

        private void SetLacrosseTheme()
        {
            this.BackColor = Color.Green;
            titleLabel.ForeColor = Color.White;
            infoLabel.ForeColor = Color.White;
            otherLabel.ForeColor = Color.White;
            infoLabel.Text = "Current Lacrosse Schedule:";
            ballBtn.Visible = true;
            ballBtn.Location = new Point(708, 589);
            weirdBtn.Location = new Point(914, 589);
            midgetBtn.Location = new Point(496, 589);
            midgetBtn.Visible = true;
            lacrosseBtn.Visible = false;
            string imagePath = Application.StartupPath + @"\lacrosse.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            eventBox.Items.Clear( );
            eventBox.Items.Add("Lacrosse Schedule will show here.");
        }

        private void SetWrestlingTheme()
        {
            this.BackColor = Color.Black;
            titleLabel.ForeColor = Color.White;
            infoLabel.ForeColor = Color.White;
            infoLabel.Text = "Current Micro Wrestling Schedule:";
            otherLabel.ForeColor = Color.White;
            midgetBtn.Visible = false;
            weirdBtn.Location = new Point(914, 589);
            ballBtn.Visible = true;
            ballBtn.Location = new Point(708, 589);
            lacrosseBtn.Visible = true;
            lacrosseBtn.Location = new Point(496, 589);
            string imagePath = Application.StartupPath + @"\midgetwrestling.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            eventBox.Items.Clear();
            eventBox.Items.Add("Wrestling Schedule will show here.");
        }
        private void ballBtn_Click(object sender, EventArgs e)
        {
            SetBasketballTheme();
        }

        private void weirdBtn_Click(object sender, EventArgs e)
        {
            Weird weirdForm = new Weird();
            weirdForm.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            Data dataForm = new Data();
            dataForm.ShowDialog();
        }

        private void lacrosseBtn_Click(object sender, EventArgs e)
        {
            SetLacrosseTheme();
        }

        private void midgetBtn_Click(object sender, EventArgs e)
        {
            SetWrestlingTheme();
        }
    }
}
