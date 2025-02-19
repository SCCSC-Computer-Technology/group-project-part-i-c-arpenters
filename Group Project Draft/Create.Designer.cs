namespace Group_Project_Draft
{
    partial class Create
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passBox2 = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.sportLabel = new System.Windows.Forms.Label();
            this.sportBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Sports Stuff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign Up for a Free Account!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirm Password:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(246, 128);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(175, 29);
            this.nameBox.TabIndex = 7;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(246, 166);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(175, 29);
            this.emailBox.TabIndex = 8;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(246, 208);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(175, 29);
            this.passBox.TabIndex = 9;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // passBox2
            // 
            this.passBox2.Location = new System.Drawing.Point(246, 243);
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(175, 29);
            this.passBox2.TabIndex = 10;
            this.passBox2.UseSystemPasswordChar = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(273, 337);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(148, 29);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Create Account";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Location = new System.Drawing.Point(12, 366);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 29);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Go Back!";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // sportLabel
            // 
            this.sportLabel.AutoSize = true;
            this.sportLabel.Location = new System.Drawing.Point(103, 292);
            this.sportLabel.Name = "sportLabel";
            this.sportLabel.Size = new System.Drawing.Size(132, 22);
            this.sportLabel.TabIndex = 13;
            this.sportLabel.Text = "Favorite Sport:";
            // 
            // sportBox
            // 
            this.sportBox.FormattingEnabled = true;
            this.sportBox.Items.AddRange(new object[] {
            "Basketball",
            "Lacrosse",
            "Midget Wrestling"});
            this.sportBox.Location = new System.Drawing.Point(246, 289);
            this.sportBox.Name = "sportBox";
            this.sportBox.Size = new System.Drawing.Size(177, 30);
            this.sportBox.TabIndex = 14;
            // 
            // Create
            // 
            this.AcceptButton = this.createBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backBtn;
            this.ClientSize = new System.Drawing.Size(696, 407);
            this.Controls.Add(this.sportBox);
            this.Controls.Add(this.sportLabel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.passBox2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox passBox2;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label sportLabel;
        private System.Windows.Forms.ComboBox sportBox;
    }
}