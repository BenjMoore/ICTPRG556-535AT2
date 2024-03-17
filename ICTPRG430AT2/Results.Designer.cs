namespace ClassLibrary
{
    partial class Results
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opposingTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiddEsportsData = new ClassLibrary.KiddEsportsDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teamResultsTableAdapter = new ClassLibrary.KiddEsportsDataSetTableAdapters.TeamResultsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.Resulttxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GamePlayedtxt = new System.Windows.Forms.TextBox();
            this.Teamtxt = new System.Windows.Forms.TextBox();
            this.OpposingTeamtxt = new System.Windows.Forms.TextBox();
            this.AddNewTeamBTN = new System.Windows.Forms.Button();
            this.EventNametxt = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnID = new System.Windows.Forms.TextBox();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchTxtResults = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ReturnResult = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ReturnGamePlayed = new System.Windows.Forms.TextBox();
            this.ReturnTeam = new System.Windows.Forms.TextBox();
            this.ReturnOpposingTeam = new System.Windows.Forms.TextBox();
            this.ReturnEventName = new System.Windows.Forms.TextBox();
            this.SortByEventResults = new System.Windows.Forms.Button();
            this.SortByTeamNameResults = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ExportBTNResults = new System.Windows.Forms.Button();
            this.ExportTeamName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventNameDataGridViewTextBoxColumn,
            this.gamePlayedDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.opposingTeamDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamResultsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // gamePlayedDataGridViewTextBoxColumn
            // 
            this.gamePlayedDataGridViewTextBoxColumn.DataPropertyName = "GamePlayed";
            this.gamePlayedDataGridViewTextBoxColumn.HeaderText = "GamePlayed";
            this.gamePlayedDataGridViewTextBoxColumn.Name = "gamePlayedDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // opposingTeamDataGridViewTextBoxColumn
            // 
            this.opposingTeamDataGridViewTextBoxColumn.DataPropertyName = "OpposingTeam";
            this.opposingTeamDataGridViewTextBoxColumn.HeaderText = "OpposingTeam";
            this.opposingTeamDataGridViewTextBoxColumn.Name = "opposingTeamDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // teamResultsBindingSource
            // 
            this.teamResultsBindingSource.DataMember = "TeamResults";
            this.teamResultsBindingSource.DataSource = this.kiddEsportsData;
            // 
            // kiddEsportsData
            // 
            this.kiddEsportsData.DataSetName = "KiddEsportsData";
            this.kiddEsportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(306, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 564);
            this.panel1.TabIndex = 1;
            // 
            // teamResultsTableAdapter
            // 
            this.teamResultsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Results";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "Results";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "New Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Teams";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(34, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 46);
            this.button5.TabIndex = 9;
            this.button5.Text = "Events";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.Location = new System.Drawing.Point(34, 12);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(114, 46);
            this.Homebtn.TabIndex = 8;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.Resulttxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.GamePlayedtxt);
            this.panel2.Controls.Add(this.Teamtxt);
            this.panel2.Controls.Add(this.OpposingTeamtxt);
            this.panel2.Controls.Add(this.AddNewTeamBTN);
            this.panel2.Controls.Add(this.EventNametxt);
            this.panel2.Location = new System.Drawing.Point(958, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 355);
            this.panel2.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Result";
            // 
            // Resulttxt
            // 
            this.Resulttxt.Location = new System.Drawing.Point(48, 278);
            this.Resulttxt.Name = "Resulttxt";
            this.Resulttxt.Size = new System.Drawing.Size(200, 20);
            this.Resulttxt.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Opposing Team";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Game Played";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Event Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Add New Result";
            // 
            // GamePlayedtxt
            // 
            this.GamePlayedtxt.Location = new System.Drawing.Point(48, 148);
            this.GamePlayedtxt.Name = "GamePlayedtxt";
            this.GamePlayedtxt.Size = new System.Drawing.Size(200, 20);
            this.GamePlayedtxt.TabIndex = 14;
            // 
            // Teamtxt
            // 
            this.Teamtxt.Location = new System.Drawing.Point(48, 193);
            this.Teamtxt.Name = "Teamtxt";
            this.Teamtxt.Size = new System.Drawing.Size(200, 20);
            this.Teamtxt.TabIndex = 15;
            // 
            // OpposingTeamtxt
            // 
            this.OpposingTeamtxt.Location = new System.Drawing.Point(48, 238);
            this.OpposingTeamtxt.Name = "OpposingTeamtxt";
            this.OpposingTeamtxt.Size = new System.Drawing.Size(200, 20);
            this.OpposingTeamtxt.TabIndex = 16;
            // 
            // AddNewTeamBTN
            // 
            this.AddNewTeamBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewTeamBTN.Location = new System.Drawing.Point(48, 319);
            this.AddNewTeamBTN.Name = "AddNewTeamBTN";
            this.AddNewTeamBTN.Size = new System.Drawing.Size(200, 23);
            this.AddNewTeamBTN.TabIndex = 17;
            this.AddNewTeamBTN.Text = "Add ";
            this.AddNewTeamBTN.UseVisualStyleBackColor = true;
            this.AddNewTeamBTN.Click += new System.EventHandler(this.AddNewTeamBTN_Click);
            // 
            // EventNametxt
            // 
            this.EventNametxt.BackColor = System.Drawing.Color.White;
            this.EventNametxt.Location = new System.Drawing.Point(48, 106);
            this.EventNametxt.Name = "EventNametxt";
            this.EventNametxt.Size = new System.Drawing.Size(200, 20);
            this.EventNametxt.TabIndex = 13;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(397, 660);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 21);
            this.DeleteBTN.TabIndex = 36;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID:";
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(335, 660);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(56, 20);
            this.DeleteID.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.ReturnID);
            this.panel4.Controls.Add(this.UpdateBTN);
            this.panel4.Controls.Add(this.SearchBTN);
            this.panel4.Controls.Add(this.SearchTxtResults);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.ReturnResult);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.ReturnGamePlayed);
            this.panel4.Controls.Add(this.ReturnTeam);
            this.panel4.Controls.Add(this.ReturnOpposingTeam);
            this.panel4.Controls.Add(this.ReturnEventName);
            this.panel4.Location = new System.Drawing.Point(6, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 355);
            this.panel4.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "ID";
            // 
            // ReturnID
            // 
            this.ReturnID.Location = new System.Drawing.Point(89, 318);
            this.ReturnID.Name = "ReturnID";
            this.ReturnID.Size = new System.Drawing.Size(59, 20);
            this.ReturnID.TabIndex = 36;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(154, 316);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateBTN.TabIndex = 35;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(44, 46);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 34;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SearchTxtResults
            // 
            this.SearchTxtResults.Location = new System.Drawing.Point(125, 48);
            this.SearchTxtResults.Name = "SearchTxtResults";
            this.SearchTxtResults.Size = new System.Drawing.Size(123, 20);
            this.SearchTxtResults.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Result";
            // 
            // ReturnResult
            // 
            this.ReturnResult.Location = new System.Drawing.Point(48, 278);
            this.ReturnResult.Name = "ReturnResult";
            this.ReturnResult.Size = new System.Drawing.Size(200, 20);
            this.ReturnResult.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Opposing Team";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Team";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Game Played";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 90);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Event Name";
            // 
            // ReturnGamePlayed
            // 
            this.ReturnGamePlayed.Location = new System.Drawing.Point(48, 148);
            this.ReturnGamePlayed.Name = "ReturnGamePlayed";
            this.ReturnGamePlayed.Size = new System.Drawing.Size(200, 20);
            this.ReturnGamePlayed.TabIndex = 14;
            // 
            // ReturnTeam
            // 
            this.ReturnTeam.Location = new System.Drawing.Point(48, 193);
            this.ReturnTeam.Name = "ReturnTeam";
            this.ReturnTeam.Size = new System.Drawing.Size(200, 20);
            this.ReturnTeam.TabIndex = 15;
            // 
            // ReturnOpposingTeam
            // 
            this.ReturnOpposingTeam.Location = new System.Drawing.Point(48, 238);
            this.ReturnOpposingTeam.Name = "ReturnOpposingTeam";
            this.ReturnOpposingTeam.Size = new System.Drawing.Size(200, 20);
            this.ReturnOpposingTeam.TabIndex = 16;
            // 
            // ReturnEventName
            // 
            this.ReturnEventName.BackColor = System.Drawing.Color.White;
            this.ReturnEventName.Location = new System.Drawing.Point(48, 106);
            this.ReturnEventName.Name = "ReturnEventName";
            this.ReturnEventName.Size = new System.Drawing.Size(200, 20);
            this.ReturnEventName.TabIndex = 13;
            // 
            // SortByEventResults
            // 
            this.SortByEventResults.Location = new System.Drawing.Point(711, 61);
            this.SortByEventResults.Name = "SortByEventResults";
            this.SortByEventResults.Size = new System.Drawing.Size(241, 23);
            this.SortByEventResults.TabIndex = 37;
            this.SortByEventResults.Text = "Event";
            this.SortByEventResults.UseVisualStyleBackColor = true;
            this.SortByEventResults.Click += new System.EventHandler(this.SortByEventResults_Click);
            // 
            // SortByTeamNameResults
            // 
            this.SortByTeamNameResults.Location = new System.Drawing.Point(306, 61);
            this.SortByTeamNameResults.Name = "SortByTeamNameResults";
            this.SortByTeamNameResults.Size = new System.Drawing.Size(241, 23);
            this.SortByTeamNameResults.TabIndex = 38;
            this.SortByTeamNameResults.Text = "Team Name";
            this.SortByTeamNameResults.UseVisualStyleBackColor = true;
            this.SortByTeamNameResults.Click += new System.EventHandler(this.SortByTeamNameResults_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1073, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Reports";
            // 
            // ExportBTNResults
            // 
            this.ExportBTNResults.Location = new System.Drawing.Point(1037, 95);
            this.ExportBTNResults.Name = "ExportBTNResults";
            this.ExportBTNResults.Size = new System.Drawing.Size(141, 23);
            this.ExportBTNResults.TabIndex = 40;
            this.ExportBTNResults.Text = "Export - Event Name";
            this.ExportBTNResults.UseVisualStyleBackColor = true;
            this.ExportBTNResults.Click += new System.EventHandler(this.ExportBTNResults_Click);
            // 
            // ExportTeamName
            // 
            this.ExportTeamName.Location = new System.Drawing.Point(1037, 134);
            this.ExportTeamName.Name = "ExportTeamName";
            this.ExportTeamName.Size = new System.Drawing.Size(141, 23);
            this.ExportTeamName.TabIndex = 41;
            this.ExportTeamName.Text = "Export - Team Name";
            this.ExportTeamName.UseVisualStyleBackColor = true;
            this.ExportTeamName.Click += new System.EventHandler(this.ExportTeamName_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 741);
            this.Controls.Add(this.ExportTeamName);
            this.Controls.Add(this.ExportBTNResults);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SortByTeamNameResults);
            this.Controls.Add(this.SortByEventResults);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private ClassLibrary.KiddEsportsDataSet kiddEsportsData;
        private System.Windows.Forms.BindingSource teamResultsBindingSource;
        private ClassLibrary.KiddEsportsDataSetTableAdapters.TeamResultsTableAdapter teamResultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opposingTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GamePlayedtxt;
        private System.Windows.Forms.TextBox Teamtxt;
        private System.Windows.Forms.TextBox OpposingTeamtxt;
        private System.Windows.Forms.Button AddNewTeamBTN;
        private System.Windows.Forms.TextBox EventNametxt;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Resulttxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox SearchTxtResults;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ReturnResult;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ReturnGamePlayed;
        private System.Windows.Forms.TextBox ReturnTeam;
        private System.Windows.Forms.TextBox ReturnOpposingTeam;
        private System.Windows.Forms.TextBox ReturnEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReturnID;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button SortByEventResults;
        private System.Windows.Forms.Button SortByTeamNameResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExportBTNResults;
        private System.Windows.Forms.Button ExportTeamName;
    }
}