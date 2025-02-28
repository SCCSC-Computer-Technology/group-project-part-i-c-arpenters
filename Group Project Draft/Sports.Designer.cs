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
            this.lacrosseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.eventBox = new System.Windows.Forms.ListBox();
            this.statsBtn = new System.Windows.Forms.Button();
            this.otherLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.logoBox1 = new System.Windows.Forms.PictureBox();
            this.logoBox2 = new System.Windows.Forms.PictureBox();
            this.logoBox3 = new System.Windows.Forms.PictureBox();
            this.logoBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(35, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(730, 61);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "C#arpenters Sports Application\r\n";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ballBtn
            // 
            this.ballBtn.Location = new System.Drawing.Point(1105, 410);
            this.ballBtn.Name = "ballBtn";
            this.ballBtn.Size = new System.Drawing.Size(157, 42);
            this.ballBtn.TabIndex = 3;
            this.ballBtn.Text = "Basketball";
            this.ballBtn.UseVisualStyleBackColor = true;
            this.ballBtn.Click += new System.EventHandler(this.ballBtn_Click);
            // 
            // midgetBtn
            // 
            this.midgetBtn.Location = new System.Drawing.Point(1096, 572);
            this.midgetBtn.Name = "midgetBtn";
            this.midgetBtn.Size = new System.Drawing.Size(176, 42);
            this.midgetBtn.TabIndex = 8;
            this.midgetBtn.Text = "Micro Wrestling";
            this.midgetBtn.UseVisualStyleBackColor = true;
            this.midgetBtn.Click += new System.EventHandler(this.midgetBtn_Click);
            // 
            // lacrosseBtn
            // 
            this.lacrosseBtn.Location = new System.Drawing.Point(1105, 488);
            this.lacrosseBtn.Name = "lacrosseBtn";
            this.lacrosseBtn.Size = new System.Drawing.Size(157, 42);
            this.lacrosseBtn.TabIndex = 15;
            this.lacrosseBtn.Text = "Lacrosse";
            this.lacrosseBtn.UseVisualStyleBackColor = true;
            this.lacrosseBtn.Click += new System.EventHandler(this.lacrosseBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 709);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(117, 31);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox1.Location = new System.Drawing.Point(45, 215);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(398, 437);
            this.picBox1.TabIndex = 17;
            this.picBox1.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(567, 244);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(339, 46);
            this.infoLabel.TabIndex = 18;
            this.infoLabel.Text = "Current Micro Wrestling Schedule:\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventBox
            // 
            this.eventBox.FormattingEnabled = true;
            this.eventBox.ItemHeight = 22;
            this.eventBox.Location = new System.Drawing.Point(509, 293);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(462, 246);
            this.eventBox.TabIndex = 19;
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(1096, 293);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(176, 42);
            this.statsBtn.TabIndex = 20;
            this.statsBtn.Text = "Go to Stats!";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // otherLabel
            // 
            this.otherLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherLabel.Location = new System.Drawing.Point(1024, 362);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(328, 28);
            this.otherLabel.TabIndex = 21;
            this.otherLabel.Text = "Or check out some other sports:\r\n";
            this.otherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(45, 108);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(157, 31);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "Update Profile\r\n";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // logoBox1
            // 
            this.logoBox1.Location = new System.Drawing.Point(392, 108);
            this.logoBox1.Name = "logoBox1";
            this.logoBox1.Size = new System.Drawing.Size(171, 84);
            this.logoBox1.TabIndex = 23;
            this.logoBox1.TabStop = false;
            // 
            // logoBox2
            // 
            this.logoBox2.Location = new System.Drawing.Point(649, 108);
            this.logoBox2.Name = "logoBox2";
            this.logoBox2.Size = new System.Drawing.Size(171, 84);
            this.logoBox2.TabIndex = 24;
            this.logoBox2.TabStop = false;
            // 
            // logoBox3
            // 
            this.logoBox3.Location = new System.Drawing.Point(886, 108);
            this.logoBox3.Name = "logoBox3";
            this.logoBox3.Size = new System.Drawing.Size(171, 84);
            this.logoBox3.TabIndex = 25;
            this.logoBox3.TabStop = false;
            // 
            // logoBox4
            // 
            this.logoBox4.Location = new System.Drawing.Point(1105, 108);
            this.logoBox4.Name = "logoBox4";
            this.logoBox4.Size = new System.Drawing.Size(171, 84);
            this.logoBox4.TabIndex = 26;
            this.logoBox4.TabStop = false;
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 752);
            this.Controls.Add(this.logoBox4);
            this.Controls.Add(this.logoBox3);
            this.Controls.Add(this.logoBox2);
            this.Controls.Add(this.logoBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.otherLabel);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.eventBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lacrosseBtn);
            this.Controls.Add(this.midgetBtn);
            this.Controls.Add(this.ballBtn);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Sports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports";
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button ballBtn;
        private System.Windows.Forms.Button midgetBtn;
        private System.Windows.Forms.Button lacrosseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ListBox eventBox;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox logoBox1;
        private System.Windows.Forms.PictureBox logoBox2;
        private System.Windows.Forms.PictureBox logoBox3;
        private System.Windows.Forms.PictureBox logoBox4;
    }
}