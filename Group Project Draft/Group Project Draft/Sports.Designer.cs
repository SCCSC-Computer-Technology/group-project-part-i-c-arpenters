namespace Group_Project_Draft
{
    partial class Sports
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ballBtn = new System.Windows.Forms.Button();
            this.midgetBtn = new System.Windows.Forms.Button();
            this.weirdBtn = new System.Windows.Forms.Button();
            this.lacrosseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.eventBox = new System.Windows.Forms.ListBox();
            this.statsBtn = new System.Windows.Forms.Button();
            this.otherLabel = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.dgvLacrosseSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLacrosseSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1217, 114);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "C#arpenters Sports Application\r\n";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ballBtn
            // 
            this.ballBtn.Location = new System.Drawing.Point(496, 589);
            this.ballBtn.Name = "ballBtn";
            this.ballBtn.Size = new System.Drawing.Size(157, 42);
            this.ballBtn.TabIndex = 3;
            this.ballBtn.Text = "Basketball";
            this.ballBtn.UseVisualStyleBackColor = true;
            this.ballBtn.Click += new System.EventHandler(this.ballBtn_Click);
            // 
            // midgetBtn
            // 
            this.midgetBtn.Location = new System.Drawing.Point(914, 589);
            this.midgetBtn.Name = "midgetBtn";
            this.midgetBtn.Size = new System.Drawing.Size(176, 42);
            this.midgetBtn.TabIndex = 8;
            this.midgetBtn.Text = "Micro Wrestling";
            this.midgetBtn.UseVisualStyleBackColor = true;
            this.midgetBtn.Click += new System.EventHandler(this.midgetBtn_Click);
            // 
            // weirdBtn
            // 
            this.weirdBtn.Location = new System.Drawing.Point(1072, 606);
            this.weirdBtn.Name = "weirdBtn";
            this.weirdBtn.Size = new System.Drawing.Size(157, 42);
            this.weirdBtn.TabIndex = 14;
            this.weirdBtn.Text = "Weird Sports";
            this.weirdBtn.UseVisualStyleBackColor = true;
            this.weirdBtn.Click += new System.EventHandler(this.weirdBtn_Click);
            // 
            // lacrosseBtn
            // 
            this.lacrosseBtn.Location = new System.Drawing.Point(708, 589);
            this.lacrosseBtn.Name = "lacrosseBtn";
            this.lacrosseBtn.Size = new System.Drawing.Size(157, 42);
            this.lacrosseBtn.TabIndex = 15;
            this.lacrosseBtn.Text = "Lacrosse";
            this.lacrosseBtn.UseVisualStyleBackColor = true;
            this.lacrosseBtn.Click += new System.EventHandler(this.lacrosseBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 619);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 34);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "&Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox1.Location = new System.Drawing.Point(32, 157);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(398, 437);
            this.picBox1.TabIndex = 17;
            this.picBox1.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(662, 157);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(328, 28);
            this.infoLabel.TabIndex = 18;
            this.infoLabel.Text = "Current Micro Wrestling Schedule:\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventBox
            // 
            this.eventBox.FormattingEnabled = true;
            this.eventBox.ItemHeight = 27;
            this.eventBox.Location = new System.Drawing.Point(528, 188);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(462, 220);
            this.eventBox.TabIndex = 19;
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(528, 489);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(202, 42);
            this.statsBtn.TabIndex = 20;
            this.statsBtn.Text = "&Go to Stats!";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // otherLabel
            // 
            this.otherLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherLabel.Location = new System.Drawing.Point(630, 534);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(328, 28);
            this.otherLabel.TabIndex = 21;
            this.otherLabel.Text = "Or check out some other sports:\r\n";
            this.otherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(780, 489);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(210, 42);
            this.btnProfile.TabIndex = 23;
            this.btnProfile.Text = "Go to User Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // dgvLacrosseSchedule
            // 
            this.dgvLacrosseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLacrosseSchedule.Location = new System.Drawing.Point(490, 188);
            this.dgvLacrosseSchedule.Name = "dgvLacrosseSchedule";
            this.dgvLacrosseSchedule.RowHeadersWidth = 51;
            this.dgvLacrosseSchedule.RowTemplate.Height = 24;
            this.dgvLacrosseSchedule.Size = new System.Drawing.Size(726, 295);
            this.dgvLacrosseSchedule.TabIndex = 24;
            this.dgvLacrosseSchedule.Visible = false;
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 660);
            this.Controls.Add(this.dgvLacrosseSchedule);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.otherLabel);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lacrosseBtn);
            this.Controls.Add(this.weirdBtn);
            this.Controls.Add(this.midgetBtn);
            this.Controls.Add(this.ballBtn);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Sports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLacrosseSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button ballBtn;
        private System.Windows.Forms.Button midgetBtn;
        private System.Windows.Forms.Button weirdBtn;
        private System.Windows.Forms.Button lacrosseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListBox eventBox;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.DataGridView dgvLacrosseSchedule;
    }
}