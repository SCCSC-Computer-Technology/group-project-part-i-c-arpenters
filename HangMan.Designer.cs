namespace Group_Project_Draft
{
    partial class HangMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangMan));
            this.titleLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.guessBtn = new System.Windows.Forms.Button();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(58, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1261, 114);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Let\'s Play HangMan!!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.titleLabel, "Welcome to hangman!");
            // 
            // wordLabel
            // 
            this.wordLabel.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordLabel.Location = new System.Drawing.Point(537, 159);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(730, 143);
            this.wordLabel.TabIndex = 1;
            this.wordLabel.Text = "1";
            this.toolTip1.SetToolTip(this.wordLabel, "Guess the word!");
            // 
            // guessBox
            // 
            this.guessBox.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessBox.Location = new System.Drawing.Point(580, 320);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(225, 43);
            this.guessBox.TabIndex = 2;
            // 
            // guessBtn
            // 
            this.guessBtn.Location = new System.Drawing.Point(698, 381);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(107, 32);
            this.guessBtn.TabIndex = 3;
            this.guessBtn.Text = "Guess!";
            this.toolTip1.SetToolTip(this.guessBtn, "Click to submit your letter");
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // wrongLabel
            // 
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wrongLabel.Location = new System.Drawing.Point(894, 320);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(373, 103);
            this.wrongLabel.TabIndex = 4;
            this.wrongLabel.Text = "2";
            this.toolTip1.SetToolTip(this.wrongLabel, "Incorrect guesses");
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.Location = new System.Drawing.Point(66, 136);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(393, 589);
            this.picBox1.TabIndex = 5;
            this.picBox1.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(12, 731);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(107, 32);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.toolTip1.SetToolTip(this.exitBtn, "Quit");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(487, 491);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(492, 182);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.resultLabel, "Results!");
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(656, 689);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(149, 36);
            this.playBtn.TabIndex = 8;
            this.playBtn.Text = "Play Again!";
            this.toolTip1.SetToolTip(this.playBtn, "Play again?");
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // HangMan
            // 
            this.AcceptButton = this.guessBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1449, 775);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HangMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangMan";
            this.Load += new System.EventHandler(this.HangMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}