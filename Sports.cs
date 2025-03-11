using Microsoft.Office.Interop.Word;
using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
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
    public partial class Sports : Form
    {
        private string currentUsername;
        public Sports(string username)
        {
            InitializeComponent();
            currentUsername = username;
            LoadUserData();
        }

        // Tailor the page for the user that's logged in
        private void LoadUserData()
        {
            // Get the stuff from the database to determine favorite sport
            string connectionString = "Data Source=UserDatabase.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT favorite_sport FROM Users WHERE username = @username";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", currentUsername);
                    var result = cmd.ExecuteScalar(); // Gets their favorite sport

                    titleLabel.Text = $"Hello, {currentUsername}!!           Welcome to the C#arpenters Sports App!";

                    // Check to make sure it's not empty
                    if (result != null)
                    {
                        string favoriteSport = result.ToString();

                        // Make their homepage the theme of whatever their favorite sport is
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
                    }
                    else
                    {
                        MessageBox.Show("Favorite sport not found for user.");
                    }
                }
            }
        }

        // Stuff for the Basketballl page
        private void SetBasketballTheme()
        {

            // Added Sound Effects - Mike Breen's Bang plays on the Basketball page
            try
            {
                // Path to the file - it's in the Debug folder. 
                string soundPath = System.Windows.Forms.Application.StartupPath + @"\Bang.wav";
                SoundPlayer rumbleSound = new SoundPlayer(soundPath);
                rumbleSound.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }

            // Set the background and all the stuff for the theme
            this.BackColor = Color.Blue;
            string imagePath3 = System.Windows.Forms.Application.StartupPath + @"\BB.jpg";
            this.BackgroundImage = Image.FromFile(imagePath3);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            titleLabel.ForeColor = Color.White;
            titleLabel.BackColor = Color.Transparent;
            infoLabel.ForeColor = Color.White;
            infoLabel.BackColor = Color.Transparent;
            otherLabel.ForeColor = Color.White;
            otherLabel.BackColor = Color.Transparent;
            infoLabel.Text = "Current Basketball Schedule:";
            string imagePath = System.Windows.Forms.Application.StartupPath + @"\basketball.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            picBox1.BackColor = Color.Transparent;
            string imagePath2 = System.Windows.Forms.Application.StartupPath + @"\";
            logoBox1.Visible = true;
            logoBox1.BackColor = Color.Transparent;
            logoBox2.Visible = true;
            logoBox2.BackColor = Color.Transparent;
            logoBox3.Visible = true;
            logoBox3.BackColor = Color.Transparent;
            logoBox4.Visible = true;
            logoBox4.BackColor = Color.Transparent;
            logoBox1.Image = Image.FromFile(imagePath2 + "PS.png");
            logoBox2.Image = Image.FromFile(imagePath2 + "OM.png");
            logoBox3.Image = Image.FromFile(imagePath2 + "CH.png");
            logoBox4.Image = Image.FromFile(imagePath2 + "BC.png");
            logoBox1.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox2.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox3.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox4.SizeMode = PictureBoxSizeMode.Zoom;
            LSchedule.Visible = false;
            WSchedule.Visible = false;
            BSchedule.Visible = true;
        }

        // Stuff for the Lacrosse page
        private void SetLacrosseTheme()
        {

            // Added Sound Effects - A clip from American Pie plays when the Lacrosse page loads. 
            try
            {
                // Path to the file - it's in the Debug folder. 
                string soundPath = System.Windows.Forms.Application.StartupPath + @"\Pie.wav";
                SoundPlayer rumbleSound = new SoundPlayer(soundPath);
                rumbleSound.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }

            // Set the background image and all the stuff
            this.BackColor = Color.Green;
            string imagePath3 = System.Windows.Forms.Application.StartupPath + @"\LB.jpg"; 
            this.BackgroundImage = Image.FromFile(imagePath3);
            this.BackgroundImageLayout = ImageLayout.Stretch; 

            titleLabel.ForeColor = Color.Black;
            titleLabel.BackColor = Color.Transparent;
            infoLabel.ForeColor = Color.Black;
            infoLabel.BackColor = Color.Transparent;
            otherLabel.ForeColor = Color.Black;
            otherLabel.BackColor = Color.Transparent;
            infoLabel.Text = "Current Lacrosse Schedule:";
            string imagePath = System.Windows.Forms.Application.StartupPath + @"\lacrosse.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            picBox1.BackColor = Color.Transparent;
            string imagePath2 = System.Windows.Forms.Application.StartupPath + @"\";
            logoBox1.Visible = true;
            logoBox1.BackColor = Color.Transparent;
            logoBox2.Visible = true;
            logoBox2.BackColor = Color.Transparent;
            logoBox3.Visible = true;
            logoBox3.BackColor = Color.Transparent;
            logoBox4.Visible = true;
            logoBox4.BackColor = Color.Transparent;
            logoBox1.Image = Image.FromFile(imagePath2 + "CAN.jpg");
            logoBox2.Image = Image.FromFile(imagePath2 + "CHA.jpg");
            logoBox3.Image = Image.FromFile(imagePath2 + "WAT.jpg");
            logoBox4.Image = Image.FromFile(imagePath2 + "RED.jpg");
            logoBox1.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox2.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox3.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox4.SizeMode = PictureBoxSizeMode.Zoom;
            LSchedule.Visible = true;
            WSchedule.Visible = false;
            BSchedule.Visible = false;
        }

        // Stuff for the Wrestling page
        private void SetWrestlingTheme()
        {

            // Added Sound Effects - "Let's Get Ready to Rumble!" plays when the Wrestling page loads. 
            try
            {
                // Path to the file - it's in the Debug folder. 
                string soundPath = System.Windows.Forms.Application.StartupPath + @"\Rumble.wav";
                SoundPlayer rumbleSound = new SoundPlayer(soundPath);
                rumbleSound.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }

            // Set the background and all the other stuff
            this.BackColor = Color.Black;
            string imagePath4 = System.Windows.Forms.Application.StartupPath + @"\WB.png";
            this.BackgroundImage = Image.FromFile(imagePath4);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            titleLabel.ForeColor = Color.Black;
            titleLabel.BackColor = Color.Transparent;
            infoLabel.ForeColor = Color.Black;
            infoLabel.BackColor = Color.Transparent;
            infoLabel.Text = "Current Micro Wrestling Schedule:";
            otherLabel.ForeColor = Color.Black;
            otherLabel.BackColor = Color.Transparent;
            string imagePath = System.Windows.Forms.Application.StartupPath + @"\midgetwrestling.jpg";
            picBox1.Image = Image.FromFile(imagePath);
            picBox1.BackColor = Color.Transparent;
            picBox1.SizeMode = PictureBoxSizeMode.Zoom; // Setting this in properties NEVER works. I always have to do it here?
            string imagePath2 = System.Windows.Forms.Application.StartupPath + @"\";
            logoBox1.Visible = true;
            logoBox1.BackColor = Color.Transparent;
            logoBox2.Visible = true;
            logoBox2.BackColor = Color.Transparent;
            logoBox3.Visible = true;
            logoBox3.BackColor = Color.Transparent;
            logoBox4.Visible = true;
            logoBox4.BackColor = Color.Transparent;
            logoBox1.Image = Image.FromFile(imagePath2 + "MWF.png");
            logoBox2.Image = Image.FromFile(imagePath2 + "CMLL.png");
            logoBox3.Image = Image.FromFile(imagePath2 + "ECW.png");
            logoBox4.Image = Image.FromFile(imagePath2 + "AAA.png");
            logoBox1.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox2.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox3.SizeMode = PictureBoxSizeMode.Zoom;
            logoBox4.SizeMode = PictureBoxSizeMode.Zoom;
            LSchedule.Visible = false;
            WSchedule.Visible = true;
            BSchedule.Visible = false;

        }

        // Changes the theme if you click a different sport
        private void ballBtn_Click(object sender, EventArgs e)
        {
            SetBasketballTheme();
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Goes to the data page for the stats depending on the sport 
        // mapped to background color - Y'all this is so dumb, but it was the easiest way I could think of.... 
        private void statsBtn_Click(object sender, EventArgs e)
        {
            string selectedSport = "";

            if (this.BackColor == Color.Blue)
                selectedSport = "Basketball";
            else if (this.BackColor == Color.Green)
                selectedSport = "Lacrosse";
            else if (this.BackColor == Color.Black)
                selectedSport = "Midget Wrestling";

            Data dataForm = new Data(selectedSport);
            dataForm.ShowDialog();
        }

        // Sets Lacrosse theme
        private void lacrosseBtn_Click(object sender, EventArgs e)
        {
            SetLacrosseTheme();
        }

        // Sets Wrestling theme
        private void midgetBtn_Click(object sender, EventArgs e)
        {
            SetWrestlingTheme();
        }

        // Loads the tables
        private void Sports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDataSet4.BasketballSchedule' table. You can move, or remove it, as needed.
            this.basketballScheduleTableAdapter.Fill(this.sportsDataSet4.BasketballSchedule);
            // TODO: This line of code loads data into the 'sportsDataSet2.WrestlingSchedule' table. You can move, or remove it, as needed.
            this.wrestlingScheduleTableAdapter.Fill(this.sportsDataSet2.WrestlingSchedule);
            // TODO: This line of code loads data into the 'pllStatsDataSet.LacrosseSchedule' table. You can move, or remove it, as needed.
            this.lacrosseScheduleTableAdapter.Fill(this.pllStatsDataSet.LacrosseSchedule);
            // TODO: This line of code loads data into the 'pllStatsDataSet._pll_team_stats' table. You can move, or remove it, as needed.
            this.pll_team_statsTableAdapter.Fill(this.pllStatsDataSet._pll_team_stats);

        }


        // Save the Schedule as a doc file
        private void saveBtn_Click(object sender, EventArgs e)
        {
            DataGridView activeSchedule;
            string scheduleName;

            // Figure out which Schedule is showing so it saves correctly
            if (WSchedule.Visible)
            {
                activeSchedule = WSchedule;
                scheduleName = "Wrestling Schedule";
            }
            else if (LSchedule.Visible)
            {
                activeSchedule = LSchedule;
                scheduleName = "Lacrosse Schedule";
            }
            else if (BSchedule.Visible)
            {
                activeSchedule = LSchedule;
                scheduleName = "Basketball Schedule";
            }
            else
            {
                MessageBox.Show("No data to export.");
                return;
            }

            if (activeSchedule.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            try
            {
                // Create a Word application to save the file. Had to Google pretty much all of this.
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();

                // Add a title
                Microsoft.Office.Interop.Word.Paragraph title = doc.Paragraphs.Add();
                title.Range.Text = scheduleName;
                title.Range.Font.Size = 13;
                title.Range.Font.Bold = 1;
                title.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();

                // Add a table with DataGridView contents
                int rowCount = activeSchedule.Rows.Count;
                int colCount = activeSchedule.Columns.Count;

                Microsoft.Office.Interop.Word.Table table = doc.Tables.Add(doc.Range(), rowCount + 1, colCount);
                table.Borders.Enable = 1; // Add table borders
                table.Rows[1].Range.Font.Bold = 1; // Bold the header row
                table.Rows[1].Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                // Insert column headers
                for (int col = 0; col < colCount; col++)
                {
                    table.Cell(1, col + 1).Range.Text = activeSchedule.Columns[col].HeaderText;
                }

                // Insert rows with formatting
                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        string cellText = activeSchedule.Rows[row].Cells[col].Value?.ToString() ?? "";

                        // Format DateTime columns if applicable
                        if (DateTime.TryParse(cellText, out DateTime dateValue))
                        {
                            cellText = dateValue.ToString("MM/dd/yyyy hh:mm tt"); // Format as "MM/DD/YYYY HH:MM AM/PM"
                        }

                        table.Cell(row + 2, col + 1).Range.Text = cellText;
                    }
                }

                // Auto-fit columns for better appearance
                table.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);

                // Save the file 
                string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{scheduleName}.docx");

                doc.SaveAs2(docPath);
                doc.Close();
                wordApp.Quit();

                MessageBox.Show($"{scheduleName} exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}



