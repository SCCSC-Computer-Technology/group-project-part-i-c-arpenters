using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Data : Form
    {
        private string selectedSport;
        private BindingSource currentBindingSource = new BindingSource();
        private BindingSource teamBindingSource = new BindingSource();

        // Had to put this in to make the reset button work... struggled way too hard with this. It was stupid.
        private DataTable originalPlayerTable;
        private DataTable originalTeamTable;

        public Data(string sport)
        {
            InitializeComponent();
            selectedSport = sport;
            bindingNavigator1.BindingSource = currentBindingSource;
            dataGridView1.Visible = false; // Hides the grid at first
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            teamBtn.Text = "Show Team Table";
            playerBtn.Text = "Show Player Table";

            // Hides the logo boxes, not used for wrestling
            logoBox5.Visible = false;
            logoBox6.Visible = false;
            logoBox7.Visible = false;
            logoBox8.Visible = false;
            logoBox9.Visible = false;
            logoBox10.Visible = false;
            logoBox11.Visible = false;
            logoBox12.Visible = false;

        }

        // Loading all the stuff to get the data in the tables
        private void Data_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'sportsDataSet6.BPlayer' table. You can move, or remove it, as needed.
            this.bPlayerTableAdapter.Fill(this.sportsDataSet6.BPlayer);
            // TODO: This line of code loads data into the 'sportsDataSet5.BTeam' table. You can move, or remove it, as needed.
            this.bTeamTableAdapter.Fill(this.sportsDataSet5.BTeam);
            bindingNavigator1.Visible = true;
            try
            {
                this.pll_player_statsTableAdapter.Fill(this.pllStatsDataSet._pll_player_stats);


                currentBindingSource.DataSource = this.pllStatsDataSet._pll_player_stats;
                pll_player_statsDataGridView.DataSource = currentBindingSource;


                originalPlayerTable = ((DataTable)currentBindingSource.DataSource).Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }

            // TODO: This line of code loads data into the 'pllStatsDataSet._pll_team_stats' table. You can move, or remove it, as needed.
            this.pll_player_statsTableAdapter.Fill(this.pllStatsDataSet._pll_player_stats);
            try
            {
                // Hide Title Label, Only Show for the Sport they choose
                titleLabel.Visible = false;

                // Hide the data grids, only show the one for the sport they picked
                pll_player_statsDataGridView.Visible = false;
                wrestlingDataGridView.Visible = false;
                dataGridView3.Visible = false;


                // Stuff for Basketball
                if (selectedSport == "Basketball")
                {

                    string imagePath4 = Application.StartupPath + @"\BB.jpg"; // Background pic
                    this.BackgroundImage = Image.FromFile(imagePath4);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    teamBtn.Visible = true; // Basketball has two tables like Lacrosse
                    playerBtn.Visible = true; // Two tables for Basketball
                    titleLabel.Visible = true;
                    titleLabel.Text = "BASKETBALL STATS";
                    titleLabel.ForeColor = Color.White;
                    titleLabel.BackColor = Color.Transparent;
                    playerBtn.Visible = false;
                    dataGridView3.Visible = true;
                    currentBindingSource.DataSource = this.sportsDataSet6.BPlayer;


                    // Store the original wrestling table
                    originalPlayerTable = this.sportsDataSet6.BPlayer.Copy();
                    
                }

                // Stuff for Lacrosse
                else if (selectedSport == "Lacrosse")
                {
                    this.lacrosseTableAdapter.Fill(this.sportsDataSet.Lacrosse);
                    currentBindingSource.DataSource = this.sportsDataSet.Lacrosse;
                    pll_player_statsDataGridView.DataSource = currentBindingSource;
                    pll_player_statsDataGridView.Visible = true;
                    string imagePath3 = Application.StartupPath + @"\LB.jpg"; // Background pic
                    this.BackgroundImage = Image.FromFile(imagePath3);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    teamBtn.Visible = true; // team button to switch between tables, Lacrosse has two
                    playerBtn.Visible = true;  // player button to switch between tables
                    titleLabel.Visible = true;
                    titleLabel.BackColor = Color.Transparent;
                    titleLabel.Text = "LACROSSE STATS";
                    titleLabel.ForeColor = Color.Black;
                    playerBtn.Visible= false;



                    // save the player table
                    originalPlayerTable = this.sportsDataSet.Lacrosse.Copy();

                    // save the team table
                    this.pll_team_statsTableAdapter.Fill(this.pllStatsDataSet._pll_team_stats);
                    originalTeamTable = this.pllStatsDataSet._pll_team_stats.Copy();
                }

                // Stuff for Midget Wrestling
                else if (selectedSport == "Midget Wrestling")
                {
                    this.wrestlingTableAdapter.Fill(this.sportsDataSet.Wrestling);
                    currentBindingSource.DataSource = this.sportsDataSet.Wrestling;
                    wrestlingDataGridView.DataSource = currentBindingSource;
                    wrestlingDataGridView.Visible = true;
                    string imagePath4 = Application.StartupPath + @"\WB.png"; // Background pic
                    this.BackgroundImage = Image.FromFile(imagePath4);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    teamBtn.Visible = false; // Hide teamBtn for other sports
                    playerBtn.Visible = false; // Hide playerBtn for other sports, it's not needed
                    titleLabel.Visible = true;
                    titleLabel.Text = "MICRO WRESTLING STATS";
                    titleLabel.ForeColor = Color.Black;
                    titleLabel.BackColor = Color.Transparent;
                    playerBtn.Visible = false;


                    // Store the original wrestling table
                    originalPlayerTable = this.sportsDataSet.Wrestling.Copy();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // For Lacrosse and Basketball to switch between the two tables
        private void teamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSport == "Lacrosse")
                {
                    // Hide Player stuff if they wanna see the Team stuff
                    pll_player_statsDataGridView.Visible = false;
                    bindingNavigator1.Visible = false;
                    searchBtn.Visible = false;
                    searchBox.Visible = false;
                    resetBtn.Visible = false;
                    playerBtn.Visible = true;
                    teamBtn.Visible = false;

                    // Show the Team stuff
                    this.pll_team_statsTableAdapter.Fill(this.pllStatsDataSet._pll_team_stats);
                    teamBindingSource.DataSource = this.pllStatsDataSet._pll_team_stats;
                    dataGridView1.DataSource = teamBindingSource;
                    dataGridView1.Visible = true;

                    // No need for search and all that jazz on the Team Table, it's not that many rows... I added logo pics at the bottom so it wouldn't look so empty
                    string imagePath2 = Application.StartupPath + @"\";
                    logoBox5.Visible = true;
                    logoBox5.BackColor = Color.Transparent;
                    logoBox6.Visible = true;
                    logoBox6.BackColor = Color.Transparent;
                    logoBox7.Visible = true;
                    logoBox7.BackColor = Color.Transparent;
                    logoBox8.Visible = true;
                    logoBox8.BackColor = Color.Transparent;
                    logoBox5.Image = Image.FromFile(imagePath2 + "ARC.jpg");
                    logoBox6.Image = Image.FromFile(imagePath2 + "WHP.jpg");
                    logoBox7.Image = Image.FromFile(imagePath2 + "ATL.jpg");
                    logoBox8.Image = Image.FromFile(imagePath2 + "CHR.jpg");
                    logoBox5.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox6.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox7.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox8.SizeMode = PictureBoxSizeMode.Zoom;

                    logoBox9.Visible = true;
                    logoBox9.BackColor = Color.Transparent;
                    logoBox10.Visible = true;
                    logoBox10.BackColor = Color.Transparent;
                    logoBox11.Visible = true;
                    logoBox11.BackColor = Color.Transparent;
                    logoBox12.Visible = true;
                    logoBox12.BackColor = Color.Transparent;
                    logoBox9.Image = Image.FromFile(imagePath2 + "CAN.jpg");
                    logoBox10.Image = Image.FromFile(imagePath2 + "WAT.jpg");
                    logoBox11.Image = Image.FromFile(imagePath2 + "CHA.jpg");
                    logoBox12.Image = Image.FromFile(imagePath2 + "RED.jpg");
                    logoBox9.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox10.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox11.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox12.SizeMode = PictureBoxSizeMode.Zoom;

                    // Make sure it updates
                    dataGridView1.Refresh();
                }

                if (selectedSport == "Basketball")
                {
                    // Hide Player stuff if they wanna see the Team stuff
                    dataGridView3.Visible = false;
                    bindingNavigator1.Visible = false;


                    // Show the Team stuff
                    this.bTeamTableAdapter.Fill(this.sportsDataSet5.BTeam);
                    teamBindingSource.DataSource = this.pllStatsDataSet._pll_team_stats;
                    dataGridView2.DataSource = bTeamBindingSource;
                    dataGridView2.Visible = true;

                    searchBtn.Visible = false;
                    searchBox.Visible = false;
                    resetBtn.Visible = false;
                    playerBtn.Visible = true;
                    teamBtn.Visible = false;

                    // No need for search and all that jazz on the Team Table, it's only like 10 rows... I added logo pics at the bottom so it wouldn't look so empty
                    string imagePath2 = Application.StartupPath + @"\";
                    logoBox5.Visible = true;
                    logoBox5.BackColor = Color.Transparent;
                    logoBox6.Visible = true;
                    logoBox6.BackColor = Color.Transparent;
                    logoBox7.Visible = true;
                    logoBox7.BackColor = Color.Transparent;
                    logoBox8.Visible = true;
                    logoBox8.BackColor = Color.Transparent;
                    logoBox5.Image = Image.FromFile(imagePath2 + "PS.png");
                    logoBox6.Image = Image.FromFile(imagePath2 + "OM.png");
                    logoBox7.Image = Image.FromFile(imagePath2 + "CH.png");
                    logoBox8.Image = Image.FromFile(imagePath2 + "LA.png");
                    logoBox5.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox6.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox7.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox8.SizeMode = PictureBoxSizeMode.Zoom;

                    logoBox9.Visible = true;
                    logoBox9.BackColor = Color.Transparent;
                    logoBox10.Visible = true;
                    logoBox10.BackColor = Color.Transparent;
                    logoBox11.Visible = true;
                    logoBox11.BackColor = Color.Transparent;
                    logoBox12.Visible = true;
                    logoBox12.BackColor = Color.Transparent;
                    logoBox9.Image = Image.FromFile(imagePath2 + "HR.png");
                    logoBox10.Image = Image.FromFile(imagePath2 + "NY.png");
                    logoBox11.Image = Image.FromFile(imagePath2 + "SK.png");
                    logoBox12.Image = Image.FromFile(imagePath2 + "WW.png");
                    logoBox9.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox10.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox11.SizeMode = PictureBoxSizeMode.Zoom;
                    logoBox12.SizeMode = PictureBoxSizeMode.Zoom;

                    // Make sure it updates
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error switching to team stats: {ex.Message}");
            }
        }

        // For Lacrosse and Basketball, this is for the Player Table (that's the one that shows first)
        private void playerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSport == "Lacrosse")
                {
                    // Hide team stats DataGridView
                    dataGridView1.Visible = false;

                    // Show the player stuff
                    this.lacrosseTableAdapter.Fill(this.sportsDataSet.Lacrosse);
                    currentBindingSource.DataSource = this.sportsDataSet.Lacrosse;
                    pll_player_statsDataGridView.DataSource = currentBindingSource;
                    pll_player_statsDataGridView.Visible = true;
                    searchBtn.Visible = true;
                    searchBox.Visible = true;
                    resetBtn.Visible = true;
                    teamBtn.Visible = true;
                    playerBtn.Visible = false;


                    // Gotta hide these picture boxes so they only show on the Team Table page
                    logoBox5.Visible = false;
                    logoBox6.Visible = false;
                    logoBox7.Visible = false;
                    logoBox8.Visible = false;
                    logoBox9.Visible = false;
                    logoBox10.Visible = false;
                    logoBox11.Visible = false;
                    logoBox12.Visible = false;

                    bindingNavigator1.Visible = true;

                    // Make sure it updates
                    pll_player_statsDataGridView.Refresh();
                }

                if (selectedSport == "Basketball")
                {
                    // Hide team stats DataGridView
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = true;

                    // Show the player stuff
                    this.bPlayerTableAdapter.Fill(this.sportsDataSet6.BPlayer);
                    currentBindingSource.DataSource = this.sportsDataSet6.BPlayer;
                    dataGridView3.DataSource = currentBindingSource;
                    dataGridView3.Visible = true;
                    searchBtn.Visible = true;
                    searchBox.Visible = true;
                    resetBtn.Visible = true;
                    teamBtn.Visible = true;
                    playerBtn.Visible = false;

                    // Gotta hide these picture boxes so they only show on the Team Table page
                    logoBox5.Visible = false;
                    logoBox6.Visible = false;
                    logoBox7.Visible = false;
                    logoBox8.Visible = false;
                    logoBox9.Visible = false;
                    logoBox10.Visible = false;
                    logoBox11.Visible = false;
                    logoBox12.Visible = false;

                    bindingNavigator1.Visible = true;

                    // Make sure it updates
                    dataGridView3.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error switching to player stats: {ex.Message}");
            }
        }

        // Search the table
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchBox.Text.Trim().ToLower();  // they can search for whatever they want, case doesn't matter, etc..


            // Create a filtered table from their search
            DataTable sourceTable = (DataTable)currentBindingSource.DataSource;
            DataTable filteredTable = sourceTable.Clone(); // Clone it, so it's the same structure

            // Search through every row and column for whatever they searched for
            foreach (DataRow row in sourceTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(keyword))
                    {
                        filteredTable.ImportRow(row); // If something matches, use the whole row (all the data from that row)
                        break;
                    }
                }
            }

            // Show the filtered results
            currentBindingSource.DataSource = filteredTable;
        }

        // Set the table back to it's original state, not the filtered version from the search
        private void resetBtn_Click(object sender, EventArgs e)
        {
            searchBox.Clear();
            try
            {
                if (selectedSport == "Lacrosse")
                {
                    if (pll_player_statsDataGridView.Visible)
                    {
                        // Reset the Player table
                        if (originalPlayerTable != null && originalPlayerTable.Rows.Count > 0)
                        {
                            currentBindingSource.DataSource = originalPlayerTable.Copy();
                            pll_player_statsDataGridView.DataSource = currentBindingSource;
                            pll_player_statsDataGridView.Refresh();

                        }

                    }
                }
                else if (selectedSport == "Midget Wrestling")
                {
                    // Reset the wrestling table
                    if (originalPlayerTable != null && originalPlayerTable.Rows.Count > 0)
                    {
                        currentBindingSource.DataSource = originalPlayerTable.Copy();
                        wrestlingDataGridView.DataSource = currentBindingSource;
                        wrestlingDataGridView.Refresh();

                    }
                }

                else if (selectedSport == "Basketball")
                {
                    // Reset the basketball table
                    if (originalPlayerTable != null && originalPlayerTable.Rows.Count > 0)
                    {
                        currentBindingSource.DataSource = originalPlayerTable.Copy();
                        dataGridView3.DataSource = currentBindingSource;
                        dataGridView3.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting data: {ex.Message}");
            }
        }

        // Goes to the Wikipedia page for whatever sport
        private void historyBtn_Click(object sender, EventArgs e)
        {
            string url = "";

            // Gets the right Wikipedia URL based on the selected sport
            if (selectedSport == "Basketball")
            {
                url = "https://en.wikipedia.org/wiki/Basketball";
            }
            else if (selectedSport == "Lacrosse")
            {
                url = "https://en.wikipedia.org/wiki/Lacrosse";
            }
            else if (selectedSport == "Midget Wrestling")
            {
                url = "https://en.wikipedia.org/wiki/Midget_wrestling";
            }
            else
            {
                MessageBox.Show("No history available for this sport.");
                return;
            }

            // Open the Wikipedia page
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Wikipedia: {ex.Message}");
            }
        }

        // Play Hangman! The words are sports related. :)
        private void hangBtn_Click(object sender, EventArgs e)
        {
            HangMan hangForm = new HangMan();
            hangForm.ShowDialog();
        }

        // Takes you to different websites to see more stuff
        private void newsBtn_Click(object sender, EventArgs e)
        {
            string url = "";

            // Gets the right link depending on sport
            if (selectedSport == "Basketball")
            {
                url = "https://www.basketballnews.com/";
            }
            else if (selectedSport == "Lacrosse")
            {
                url = "https://www.insidelacrosse.com/";
            }
            else if (selectedSport == "Midget Wrestling")
            {
                url = "https://www.microwrestling.com/";
            }
            else
            {
                MessageBox.Show("Error");
                return;
            }

            // Open the site
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Site: {ex.Message}");
            }
        }
    }
}
    





