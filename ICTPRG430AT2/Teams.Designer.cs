namespace ClassLibrary
{
    partial class Teams
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
            this.Homebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeamNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryContactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiddEsportsDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiddEsportsData = new ClassLibrary.KiddEsportsDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teamInfoTableAdapter = new ClassLibrary.KiddEsportsDataSetTableAdapters.TeamInfoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TeamNameTxt = new System.Windows.Forms.TextBox();
            this.PrimaryContactTxt = new System.Windows.Forms.TextBox();
            this.ContactEmail = new System.Windows.Forms.TextBox();
            this.PointsTxt = new System.Windows.Forms.TextBox();
            this.AddNewTeamBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ReturnName = new System.Windows.Forms.TextBox();
            this.ReturnID = new System.Windows.Forms.TextBox();
            this.ReturnPoints = new System.Windows.Forms.TextBox();
            this.ReturnEmail = new System.Windows.Forms.TextBox();
            this.ReturnContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PointsSortBTN = new System.Windows.Forms.Button();
            this.AlphabeticalSortBTN = new System.Windows.Forms.Button();
            this.ExportByPoints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Homebtn
            // 
            this.Homebtn.Location = new System.Drawing.Point(68, 37);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(114, 46);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamNameColumn,
            this.PrimaryContactColumn,
            this.ContactEmailColumn,
            this.PointsColumn,
            this.IDColumn});
            this.dataGridView1.DataSource = this.teamInfoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 524);
            this.dataGridView1.TabIndex = 1;
            // 
            // TeamNameColumn
            // 
            this.TeamNameColumn.DataPropertyName = "TeamName";
            this.TeamNameColumn.HeaderText = "TeamName";
            this.TeamNameColumn.Name = "TeamNameColumn";
            this.TeamNameColumn.ReadOnly = true;
            // 
            // PrimaryContactColumn
            // 
            this.PrimaryContactColumn.DataPropertyName = "PrimaryContact";
            this.PrimaryContactColumn.HeaderText = "PrimaryContact";
            this.PrimaryContactColumn.Name = "PrimaryContactColumn";
            this.PrimaryContactColumn.ReadOnly = true;
            // 
            // ContactEmailColumn
            // 
            this.ContactEmailColumn.DataPropertyName = "ContactEmail";
            this.ContactEmailColumn.HeaderText = "ContactEmail";
            this.ContactEmailColumn.Name = "ContactEmailColumn";
            this.ContactEmailColumn.ReadOnly = true;
            // 
            // PointsColumn
            // 
            this.PointsColumn.DataPropertyName = "Points";
            this.PointsColumn.HeaderText = "Points";
            this.PointsColumn.Name = "PointsColumn";
            this.PointsColumn.ReadOnly = true;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // teamInfoBindingSource
            // 
            this.teamInfoBindingSource.DataMember = "TeamInfo";
            this.teamInfoBindingSource.DataSource = this.kiddEsportsDataBindingSource;
            // 
            // kiddEsportsDataBindingSource
            // 
            this.kiddEsportsDataBindingSource.DataSource = this.kiddEsportsData;
            this.kiddEsportsDataBindingSource.Position = 0;
            // 
            // kiddEsportsData
            // 
            this.kiddEsportsData.DataSetName = "KiddEsportsData";
            this.kiddEsportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(315, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 524);
            this.panel1.TabIndex = 2;
            // 
            // teamInfoTableAdapter
            // 
            this.teamInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Teams";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Teams";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "New Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(69, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Results";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(112, 388);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(123, 20);
            this.SearchTextBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(31, 386);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TeamNameTxt
            // 
            this.TeamNameTxt.BackColor = System.Drawing.Color.White;
            this.TeamNameTxt.Location = new System.Drawing.Point(48, 106);
            this.TeamNameTxt.Name = "TeamNameTxt";
            this.TeamNameTxt.Size = new System.Drawing.Size(200, 20);
            this.TeamNameTxt.TabIndex = 13;
            // 
            // PrimaryContactTxt
            // 
            this.PrimaryContactTxt.Location = new System.Drawing.Point(48, 148);
            this.PrimaryContactTxt.Name = "PrimaryContactTxt";
            this.PrimaryContactTxt.Size = new System.Drawing.Size(200, 20);
            this.PrimaryContactTxt.TabIndex = 14;
            // 
            // ContactEmail
            // 
            this.ContactEmail.Location = new System.Drawing.Point(48, 193);
            this.ContactEmail.Name = "ContactEmail";
            this.ContactEmail.Size = new System.Drawing.Size(200, 20);
            this.ContactEmail.TabIndex = 15;
            // 
            // PointsTxt
            // 
            this.PointsTxt.Location = new System.Drawing.Point(48, 238);
            this.PointsTxt.Name = "PointsTxt";
            this.PointsTxt.Size = new System.Drawing.Size(71, 20);
            this.PointsTxt.TabIndex = 16;
            // 
            // AddNewTeamBTN
            // 
            this.AddNewTeamBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewTeamBTN.Location = new System.Drawing.Point(48, 280);
            this.AddNewTeamBTN.Name = "AddNewTeamBTN";
            this.AddNewTeamBTN.Size = new System.Drawing.Size(200, 23);
            this.AddNewTeamBTN.TabIndex = 17;
            this.AddNewTeamBTN.Text = "Add ";
            this.AddNewTeamBTN.UseVisualStyleBackColor = true;
            this.AddNewTeamBTN.Click += new System.EventHandler(this.AddNewTeamBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PrimaryContactTxt);
            this.panel2.Controls.Add(this.ContactEmail);
            this.panel2.Controls.Add(this.PointsTxt);
            this.panel2.Controls.Add(this.AddNewTeamBTN);
            this.panel2.Controls.Add(this.TeamNameTxt);
            this.panel2.Location = new System.Drawing.Point(895, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 355);
            this.panel2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Points";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Contact Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Primary Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Team Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Add New Team";
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(349, 631);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(56, 20);
            this.DeleteID.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 634);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID:";
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(411, 631);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 21);
            this.DeleteBTN.TabIndex = 23;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.UpdateBTN);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ReturnName);
            this.panel3.Controls.Add(this.ReturnID);
            this.panel3.Controls.Add(this.ReturnPoints);
            this.panel3.Controls.Add(this.ReturnEmail);
            this.panel3.Controls.Add(this.ReturnContact);
            this.panel3.Location = new System.Drawing.Point(31, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 236);
            this.panel3.TabIndex = 27;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(115, 193);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateBTN.TabIndex = 10;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Points";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Contact Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Primary Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Team Name";
            // 
            // ReturnName
            // 
            this.ReturnName.Location = new System.Drawing.Point(90, 34);
            this.ReturnName.Name = "ReturnName";
            this.ReturnName.Size = new System.Drawing.Size(100, 20);
            this.ReturnName.TabIndex = 4;
            // 
            // ReturnID
            // 
            this.ReturnID.Enabled = false;
            this.ReturnID.Location = new System.Drawing.Point(69, 195);
            this.ReturnID.Name = "ReturnID";
            this.ReturnID.Size = new System.Drawing.Size(40, 20);
            this.ReturnID.TabIndex = 3;
            // 
            // ReturnPoints
            // 
            this.ReturnPoints.Location = new System.Drawing.Point(90, 134);
            this.ReturnPoints.Name = "ReturnPoints";
            this.ReturnPoints.Size = new System.Drawing.Size(100, 20);
            this.ReturnPoints.TabIndex = 2;
            // 
            // ReturnEmail
            // 
            this.ReturnEmail.Location = new System.Drawing.Point(90, 102);
            this.ReturnEmail.Name = "ReturnEmail";
            this.ReturnEmail.Size = new System.Drawing.Size(100, 20);
            this.ReturnEmail.TabIndex = 1;
            // 
            // ReturnContact
            // 
            this.ReturnContact.Location = new System.Drawing.Point(90, 69);
            this.ReturnContact.Name = "ReturnContact";
            this.ReturnContact.Size = new System.Drawing.Size(100, 20);
            this.ReturnContact.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1004, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reports";
            // 
            // PointsSortBTN
            // 
            this.PointsSortBTN.Location = new System.Drawing.Point(895, 142);
            this.PointsSortBTN.Name = "PointsSortBTN";
            this.PointsSortBTN.Size = new System.Drawing.Size(294, 23);
            this.PointsSortBTN.TabIndex = 25;
            this.PointsSortBTN.Text = "Points";
            this.PointsSortBTN.UseVisualStyleBackColor = true;
            this.PointsSortBTN.Click += new System.EventHandler(this.PointsSortBTN_Click);
            // 
            // AlphabeticalSortBTN
            // 
            this.AlphabeticalSortBTN.Location = new System.Drawing.Point(895, 174);
            this.AlphabeticalSortBTN.Name = "AlphabeticalSortBTN";
            this.AlphabeticalSortBTN.Size = new System.Drawing.Size(294, 23);
            this.AlphabeticalSortBTN.TabIndex = 26;
            this.AlphabeticalSortBTN.Text = "Alphabetical";
            this.AlphabeticalSortBTN.UseVisualStyleBackColor = true;
            this.AlphabeticalSortBTN.Click += new System.EventHandler(this.AlphabeticalSortBTN_Click);
            // 
            // ExportByPoints
            // 
            this.ExportByPoints.Location = new System.Drawing.Point(895, 203);
            this.ExportByPoints.Name = "ExportByPoints";
            this.ExportByPoints.Size = new System.Drawing.Size(294, 23);
            this.ExportByPoints.TabIndex = 28;
            this.ExportByPoints.Text = "Export - Points";
            this.ExportByPoints.UseVisualStyleBackColor = true;
            this.ExportByPoints.Click += new System.EventHandler(this.ExportByPoints_Click);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1224, 691);
            this.Controls.Add(this.ExportByPoints);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.AlphabeticalSortBTN);
            this.Controls.Add(this.PointsSortBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.panel2);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kiddEsportsDataBindingSource;
        private ClassLibrary.KiddEsportsDataSet kiddEsportsData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource teamInfoBindingSource;
        private ClassLibrary.KiddEsportsDataSetTableAdapters.TeamInfoTableAdapter teamInfoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox TeamNameTxt;
        private System.Windows.Forms.TextBox PrimaryContactTxt;
        private System.Windows.Forms.TextBox ContactEmail;
        private System.Windows.Forms.TextBox PointsTxt;
        private System.Windows.Forms.Button AddNewTeamBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ReturnID;
        private System.Windows.Forms.TextBox ReturnPoints;
        private System.Windows.Forms.TextBox ReturnEmail;
        private System.Windows.Forms.TextBox ReturnContact;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ReturnName;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryContactColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PointsSortBTN;
        private System.Windows.Forms.Button AlphabeticalSortBTN;
        private System.Windows.Forms.Button ExportByPoints;
    }
}