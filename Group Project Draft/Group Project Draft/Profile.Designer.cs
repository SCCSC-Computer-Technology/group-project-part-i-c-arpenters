namespace Group_Project_Draft
{
    partial class Profile
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
            this.lblFavTeam = new System.Windows.Forms.Label();
            this.cmbFavoriteTeam = new System.Windows.Forms.ComboBox();
            this.cmbFavoriteSport = new System.Windows.Forms.ComboBox();
            this.lblFavoriteSport = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFavTeam
            // 
            this.lblFavTeam.AutoSize = true;
            this.lblFavTeam.Location = new System.Drawing.Point(12, 376);
            this.lblFavTeam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFavTeam.Name = "lblFavTeam";
            this.lblFavTeam.Size = new System.Drawing.Size(163, 27);
            this.lblFavTeam.TabIndex = 28;
            this.lblFavTeam.Text = "Favorite Team:";
            // 
            // cmbFavoriteTeam
            // 
            this.cmbFavoriteTeam.FormattingEnabled = true;
            this.cmbFavoriteTeam.Location = new System.Drawing.Point(231, 373);
            this.cmbFavoriteTeam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbFavoriteTeam.Name = "cmbFavoriteTeam";
            this.cmbFavoriteTeam.Size = new System.Drawing.Size(285, 35);
            this.cmbFavoriteTeam.TabIndex = 27;
            // 
            // cmbFavoriteSport
            // 
            this.cmbFavoriteSport.FormattingEnabled = true;
            this.cmbFavoriteSport.Items.AddRange(new object[] {
            "Basketball",
            "Lacrosse",
            "Midget Wrestling"});
            this.cmbFavoriteSport.Location = new System.Drawing.Point(231, 297);
            this.cmbFavoriteSport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbFavoriteSport.Name = "cmbFavoriteSport";
            this.cmbFavoriteSport.Size = new System.Drawing.Size(285, 35);
            this.cmbFavoriteSport.TabIndex = 26;
            // 
            // lblFavoriteSport
            // 
            this.lblFavoriteSport.AutoSize = true;
            this.lblFavoriteSport.Location = new System.Drawing.Point(61, 297);
            this.lblFavoriteSport.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFavoriteSport.Name = "lblFavoriteSport";
            this.lblFavoriteSport.Size = new System.Drawing.Size(160, 27);
            this.lblFavoriteSport.TabIndex = 25;
            this.lblFavoriteSport.Text = "Favorite Sport:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(231, 239);
            this.passBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(285, 34);
            this.passBox.TabIndex = 23;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(231, 171);
            this.emailBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(285, 34);
            this.emailBox.TabIndex = 22;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(231, 104);
            this.nameBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(285, 34);
            this.nameBox.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(107, 244);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 27);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(148, 180);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 27);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(90, 104);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(131, 27);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "User Name:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(20, 460);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(104, 70);
            this.btnSaveChanges.TabIndex = 29;
            this.btnSaveChanges.Text = "&Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(167, 459);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(116, 70);
            this.btnChangePassword.TabIndex = 30;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(324, 459);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 70);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 550);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblFavTeam);
            this.Controls.Add(this.cmbFavoriteTeam);
            this.Controls.Add(this.cmbFavoriteSport);
            this.Controls.Add(this.lblFavoriteSport);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFavTeam;
        private System.Windows.Forms.ComboBox cmbFavoriteTeam;
        private System.Windows.Forms.ComboBox cmbFavoriteSport;
        private System.Windows.Forms.Label lblFavoriteSport;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnBack;
    }
}