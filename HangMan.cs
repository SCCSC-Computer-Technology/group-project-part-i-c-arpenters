using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class HangMan : Form
    {
        // Store the words and the guesses
        private string[] wordList = { "basketball", "football", "wrestling", "baseball", "hockey", "arena", "match", "foul", "hoop", "court", "block", 
        "check", "cradle", "Shot", "grapple", "suplex", "headlock", "ring", "Brandon", "Caleb", "Kara", "SCC", "Computer", "Science", "GitHub"};
        private string chosenWord;
        private char[] displayWord;
        private int incorrectGuesses;
        private List<char> wrongGuesses = new List<char>();
        private List<Image> hangmanImages = new List<Image>();


        public HangMan()
        {
            InitializeComponent();
            LoadHangmanImages();
            StartNewGame();
        }

        private void HangMan_Load(object sender, EventArgs e)
        {
            titleLabel.BackColor = Color.Transparent;
            picBox1.SizeMode = PictureBoxSizeMode.Zoom;
            picBox1.BackColor = Color.Transparent;
            wordLabel.BackColor = Color.Transparent;
            resultLabel.BackColor = Color.Transparent;
            playBtn.Visible = false;
        }

        private void LoadHangmanImages()
        {
            // Get the hangman pics - they're in the Debug folder
            for (int i = 0; i < 7; i++)
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"hangman{i}.png");
                hangmanImages.Add(Image.FromFile(imagePath));
            }
        }

        private void StartNewGame()
        {
            Random rand = new Random();
            chosenWord = wordList[rand.Next(wordList.Length)];
            displayWord = new string('_', chosenWord.Length).ToCharArray();
            incorrectGuesses = 0;
            wrongGuesses.Clear();
            wordLabel.Text = string.Join(" ", displayWord);  // Had to look this up to make it put individual blanks instead of just one big 'ol line
            wrongLabel.Text = "Wrong Guesses: ";
            wrongLabel.BackColor = Color.Transparent;
            picBox1.Image = hangmanImages[0]; 
        }

        // Guessing the letters, checks to see if it matches the word
        private void guessBtn_Click(object sender, EventArgs e)
        {
            if (guessBox.Text.Length != 1) return;

            char guessedLetter = guessBox.Text.ToLower()[0];
            guessBox.Clear();

            // If it's right it puts it in the display
            if (chosenWord.Contains(guessedLetter))
            {
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == guessedLetter)
                    {
                        displayWord[i] = guessedLetter;
                    }
                }
            }
            else
            {
                // If it's wrong it adds it to the "wrong guesses" and loads the next picture
                if (!wrongGuesses.Contains(guessedLetter))
                {
                    wrongGuesses.Add(guessedLetter);
                    incorrectGuesses++;
                    picBox1.Image = hangmanImages[incorrectGuesses];

                    wrongLabel.Text = "Wrong Guesses: " + string.Join(" ", wrongGuesses);
                }
            }

            wordLabel.Text = string.Join(" ", displayWord);

            // What happens when you win or lose. Messages show in a label.
            if (!new string(displayWord).Contains("_"))
            {
                // If you win...
                resultLabel.Text = $"YOU WON!\nThe word was: {chosenWord}";
                resultLabel.ForeColor = Color.Green;  
                resultLabel.Font = new Font("Arial", 24, FontStyle.Bold); 
                resultLabel.Visible = true;
                playBtn.Visible = true;
                

                
            }
            else if (incorrectGuesses >= 6)
            {
                // If you lose...
                resultLabel.Text = $"YOU LOSE!\nThe word was: {chosenWord}";
                resultLabel.ForeColor = Color.Red;  
                resultLabel.Font = new Font("Arial", 24, FontStyle.Bold); 
                resultLabel.Visible = true;
                playBtn.Visible = true;
                
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Button to start it over if they wanna play again
        private void playBtn_Click(object sender, EventArgs e)
        {
            StartNewGame();
            resultLabel.Visible= false;
            playBtn.Visible= false;
        }
    }
}
        
    

