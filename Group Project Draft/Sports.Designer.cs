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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ballBtn = new System.Windows.Forms.Button();
            this.midgetBtn = new System.Windows.Forms.Button();
            this.lacrosseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.statsBtn = new System.Windows.Forms.Button();
            this.otherLabel = new System.Windows.Forms.Label();
            this.logoBox1 = new System.Windows.Forms.PictureBox();
            this.logoBox2 = new System.Windows.Forms.PictureBox();
            this.logoBox3 = new System.Windows.Forms.PictureBox();
            this.logoBox4 = new System.Windows.Forms.PictureBox();
            this.pllStatsDataSet = new Group_Project_Draft.PllStatsDataSet();
            this.pllteamstatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pll_team_statsTableAdapter = new Group_Project_Draft.PllStatsDataSetTableAdapters.pll_team_statsTableAdapter();
            this.lacrosseScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lacrosseScheduleTableAdapter = new Group_Project_Draft.PllStatsDataSetTableAdapters.LacrosseScheduleTableAdapter();
            this.tableAdapterManager = new Group_Project_Draft.PllStatsDataSetTableAdapters.TableAdapterManager();
            this.LSchedule = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WSchedule = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.establishmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrestlingScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsDataSet2 = new Group_Project_Draft.SportsDataSet2();
            this.wrestlingScheduleTableAdapter = new Group_Project_Draft.SportsDataSet2TableAdapters.WrestlingScheduleTableAdapter();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pllStatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pllteamstatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lacrosseScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrestlingScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1425, 61);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "C#arpenters Sports Application\r\n";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ballBtn
            // 
            this.ballBtn.Location = new System.Drawing.Point(571, 695);
            this.ballBtn.Name = "ballBtn";
            this.ballBtn.Size = new System.Drawing.Size(157, 42);
            this.ballBtn.TabIndex = 3;
            this.ballBtn.Text = "Basketball";
            this.ballBtn.UseVisualStyleBackColor = true;
            this.ballBtn.Click += new System.EventHandler(this.ballBtn_Click);
            // 
            // midgetBtn
            // 
            this.midgetBtn.Location = new System.Drawing.Point(987, 695);
            this.midgetBtn.Name = "midgetBtn";
            this.midgetBtn.Size = new System.Drawing.Size(176, 42);
            this.midgetBtn.TabIndex = 8;
            this.midgetBtn.Text = "Micro Wrestling";
            this.midgetBtn.UseVisualStyleBackColor = true;
            this.midgetBtn.Click += new System.EventHandler(this.midgetBtn_Click);
            // 
            // lacrosseBtn
            // 
            this.lacrosseBtn.Location = new System.Drawing.Point(775, 695);
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
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.Location = new System.Drawing.Point(45, 215);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(398, 437);
            this.picBox1.TabIndex = 17;
            this.picBox1.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(612, 231);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(506, 46);
            this.infoLabel.TabIndex = 18;
            this.infoLabel.Text = "Current Micro Wrestling Schedule:\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statsBtn
            // 
            this.statsBtn.Location = new System.Drawing.Point(775, 569);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(176, 42);
            this.statsBtn.TabIndex = 20;
            this.statsBtn.Text = "Go to Stats!";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // otherLabel
            // 
            this.otherLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherLabel.Location = new System.Drawing.Point(698, 636);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(328, 28);
            this.otherLabel.TabIndex = 21;
            this.otherLabel.Text = "Or check out some other sports:\r\n";
            this.otherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoBox1
            // 
            this.logoBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // pllStatsDataSet
            // 
            this.pllStatsDataSet.DataSetName = "PllStatsDataSet";
            this.pllStatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pllteamstatsBindingSource
            // 
            this.pllteamstatsBindingSource.DataMember = "pll-team-stats";
            this.pllteamstatsBindingSource.DataSource = this.pllStatsDataSet;
            // 
            // pll_team_statsTableAdapter
            // 
            this.pll_team_statsTableAdapter.ClearBeforeFill = true;
            // 
            // lacrosseScheduleBindingSource
            // 
            this.lacrosseScheduleBindingSource.DataMember = "LacrosseSchedule";
            this.lacrosseScheduleBindingSource.DataSource = this.pllStatsDataSet;
            // 
            // lacrosseScheduleTableAdapter
            // 
            this.lacrosseScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LacrosseScheduleTableAdapter = this.lacrosseScheduleTableAdapter;
            this.tableAdapterManager.pll_player_statsTableAdapter = null;
            this.tableAdapterManager.pll_team_statsTableAdapter = this.pll_team_statsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Group_Project_Draft.PllStatsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LSchedule
            // 
            this.LSchedule.AutoGenerateColumns = false;
            this.LSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.homeTeamDataGridViewTextBoxColumn,
            this.awayTeamDataGridViewTextBoxColumn,
            this.gameDateDataGridViewTextBoxColumn,
            this.gameTimeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.LSchedule.DataSource = this.lacrosseScheduleBindingSource;
            this.LSchedule.Location = new System.Drawing.Point(540, 292);
            this.LSchedule.Name = "LSchedule";
            this.LSchedule.Size = new System.Drawing.Size(644, 241);
            this.LSchedule.TabIndex = 27;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homeTeamDataGridViewTextBoxColumn
            // 
            this.homeTeamDataGridViewTextBoxColumn.DataPropertyName = "HomeTeam";
            this.homeTeamDataGridViewTextBoxColumn.HeaderText = "HomeTeam";
            this.homeTeamDataGridViewTextBoxColumn.Name = "homeTeamDataGridViewTextBoxColumn";
            // 
            // awayTeamDataGridViewTextBoxColumn
            // 
            this.awayTeamDataGridViewTextBoxColumn.DataPropertyName = "AwayTeam";
            this.awayTeamDataGridViewTextBoxColumn.HeaderText = "AwayTeam";
            this.awayTeamDataGridViewTextBoxColumn.Name = "awayTeamDataGridViewTextBoxColumn";
            // 
            // gameDateDataGridViewTextBoxColumn
            // 
            this.gameDateDataGridViewTextBoxColumn.DataPropertyName = "GameDate";
            this.gameDateDataGridViewTextBoxColumn.HeaderText = "GameDate";
            this.gameDateDataGridViewTextBoxColumn.Name = "gameDateDataGridViewTextBoxColumn";
            // 
            // gameTimeDataGridViewTextBoxColumn
            // 
            this.gameTimeDataGridViewTextBoxColumn.DataPropertyName = "GameTime";
            this.gameTimeDataGridViewTextBoxColumn.HeaderText = "GameTime";
            this.gameTimeDataGridViewTextBoxColumn.Name = "gameTimeDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // WSchedule
            // 
            this.WSchedule.AutoGenerateColumns = false;
            this.WSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.teamDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.establishmentDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn1});
            this.WSchedule.DataSource = this.wrestlingScheduleBindingSource;
            this.WSchedule.Location = new System.Drawing.Point(540, 292);
            this.WSchedule.Name = "WSchedule";
            this.WSchedule.Size = new System.Drawing.Size(644, 241);
            this.WSchedule.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // establishmentDataGridViewTextBoxColumn
            // 
            this.establishmentDataGridViewTextBoxColumn.DataPropertyName = "Establishment";
            this.establishmentDataGridViewTextBoxColumn.HeaderText = "Establishment";
            this.establishmentDataGridViewTextBoxColumn.Name = "establishmentDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn1
            // 
            this.locationDataGridViewTextBoxColumn1.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn1.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn1.Name = "locationDataGridViewTextBoxColumn1";
            // 
            // wrestlingScheduleBindingSource
            // 
            this.wrestlingScheduleBindingSource.DataMember = "WrestlingSchedule";
            this.wrestlingScheduleBindingSource.DataSource = this.sportsDataSet2BindingSource;
            // 
            // sportsDataSet2BindingSource
            // 
            this.sportsDataSet2BindingSource.DataSource = this.sportsDataSet2;
            this.sportsDataSet2BindingSource.Position = 0;
            // 
            // sportsDataSet2
            // 
            this.sportsDataSet2.DataSetName = "SportsDataSet2";
            this.sportsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wrestlingScheduleTableAdapter
            // 
            this.wrestlingScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1022, 539);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(162, 31);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.Text = "Save Schedule";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 775);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.WSchedule);
            this.Controls.Add(this.LSchedule);
            this.Controls.Add(this.logoBox4);
            this.Controls.Add(this.logoBox3);
            this.Controls.Add(this.logoBox2);
            this.Controls.Add(this.logoBox1);
            this.Controls.Add(this.otherLabel);
            this.Controls.Add(this.statsBtn);
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
            this.Load += new System.EventHandler(this.Sports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pllStatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pllteamstatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lacrosseScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrestlingScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDataSet2)).EndInit();
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
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Label otherLabel;
        private System.Windows.Forms.PictureBox logoBox1;
        private System.Windows.Forms.PictureBox logoBox2;
        private System.Windows.Forms.PictureBox logoBox3;
        private System.Windows.Forms.PictureBox logoBox4;
        private PllStatsDataSet pllStatsDataSet;
        private System.Windows.Forms.BindingSource pllteamstatsBindingSource;
        private PllStatsDataSetTableAdapters.pll_team_statsTableAdapter pll_team_statsTableAdapter;
        private System.Windows.Forms.BindingSource lacrosseScheduleBindingSource;
        private PllStatsDataSetTableAdapters.LacrosseScheduleTableAdapter lacrosseScheduleTableAdapter;
        private PllStatsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView LSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView WSchedule;
        private System.Windows.Forms.BindingSource sportsDataSet2BindingSource;
        private SportsDataSet2 sportsDataSet2;
        private System.Windows.Forms.BindingSource wrestlingScheduleBindingSource;
        private SportsDataSet2TableAdapters.WrestlingScheduleTableAdapter wrestlingScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn establishmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button saveBtn;
    }
}