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

                    titleLabel.Text = $"Hello, {currentUsername}!!";

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
            //ballBtn.Visible = false;
            //midgetBtn.Location = new Point(1105, 410);
            //midgetBtn.Visible = true;
            //lacrosseBtn.Visible = true;
            //lacrosseBtn.Location = new Point(1105, 488);
            string imagePath = Application.StartupPath + @"\basketball.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            eventBox.Items.Clear();
            eventBox.Items.Add("Basketball Schedule will show here.");
            logoBox1.Visible = false;
            logoBox2.Visible = false;
            logoBox3.Visible = false;
            logoBox4.Visible = false;
        }

        private void SetLacrosseTheme()
        {
            this.BackColor = Color.Green;
            titleLabel.ForeColor = Color.White;
            infoLabel.ForeColor = Color.White;
            otherLabel.ForeColor = Color.White;
            infoLabel.Text = "Current Lacrosse Schedule:";
            //ballBtn.Visible = true;
            //ballBtn.Location = new Point(1105, 488);
            //midgetBtn.Location = new Point(1105, 410);
            //midgetBtn.Visible = true;
            //lacrosseBtn.Visible = false;
            string imagePath = Application.StartupPath + @"\lacrosse.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            eventBox.Items.Clear( );
            eventBox.Items.Add("Lacrosse Schedule will show here.");
            logoBox1.Visible = false;
            logoBox2.Visible = false;
            logoBox3.Visible = false;
            logoBox4.Visible = false;
        }

        private void SetWrestlingTheme()
        {
            this.BackColor = Color.Black;
            titleLabel.ForeColor = Color.Red;
            infoLabel.ForeColor = Color.Red;
            infoLabel.Text = "Current Micro Wrestling Schedule:";
            otherLabel.ForeColor = Color.Red;
            //midgetBtn.Visible = false;
            //ballBtn.Visible = true;
            //ballBtn.Location = new Point(1105, 488);
            //lacrosseBtn.Visible = true;
            //lacrosseBtn.Location = new Point(1105, 410);
            string imagePath = Application.StartupPath + @"\midgetwrestling.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            eventBox.Items.Clear();
            eventBox.Items.Add("Wrestling Schedule will show here.");
            // HAHA! THIS IS COOL... Just figured out how to do this with 2 different "imagePath" things. WOO HOO!
            string imagePath2 = Application.StartupPath +@"\";
            logoBox1.Visible = true;
            logoBox2.Visible = true;
            logoBox3.Visible = true;
            logoBox4.Visible = true;
            logoBox1.Image = Image.FromFile(imagePath2 + "MWF.png"); 
            logoBox2.Image = Image.FromFile(imagePath2 + "CMLL.png");
            logoBox3.Image = Image.FromFile(imagePath2 + "ECW.png");
            logoBox4.Image = Image.FromFile(imagePath2 + "AAA.png");
            logoBox1.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox2.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox3.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox4.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void ballBtn_Click(object sender, EventArgs e)
        {
            SetBasketballTheme();
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
