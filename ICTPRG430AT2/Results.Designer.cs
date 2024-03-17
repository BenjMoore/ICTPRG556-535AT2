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
            this.Result = new System.Windows.Forms.ComboBox();
            this.OpposingTeam = new System.Windows.Forms.ComboBox();
            this.teamInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiddEsportsData_View = new ICTPRG430AT2.KiddEsportsData_View();
            this.GamePlayed = new System.Windows.Forms.ComboBox();
            this.gamePlayedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Team = new System.Windows.Forms.ComboBox();
            this.EventName = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddNewTeamBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IDCombo = new System.Windows.Forms.ComboBox();
            this.ResultsCombo = new System.Windows.Forms.ComboBox();
            this.OpposingTeamCombo = new System.Windows.Forms.ComboBox();
            this.TeamNameCombo = new System.Windows.Forms.ComboBox();
            this.GamePlayedCombo = new System.Windows.Forms.ComboBox();
            this.EventNameCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchTxtResults = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.teamInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SortByEventResults = new System.Windows.Forms.Button();
            this.SortByTeamNameResults = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ExportBTNResults = new System.Windows.Forms.Button();
            this.ExportTeamName = new System.Windows.Forms.Button();
            this.eventTableAdapter = new ICTPRG430AT2.KiddEsportsData_ViewTableAdapters.EventTableAdapter();
            this.gamePlayedTableAdapter = new ICTPRG430AT2.KiddEsportsData_ViewTableAdapters.GamePlayedTableAdapter();
            this.teamInfoTableAdapter = new ICTPRG430AT2.KiddEsportsData_ViewTableAdapters.TeamInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource1)).BeginInit();
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
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.panel2.Controls.Add(this.Result);
            this.panel2.Controls.Add(this.OpposingTeam);
            this.panel2.Controls.Add(this.GamePlayed);
            this.panel2.Controls.Add(this.Team);
            this.panel2.Controls.Add(this.EventName);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.AddNewTeamBTN);
            this.panel2.Location = new System.Drawing.Point(958, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 355);
            this.panel2.TabIndex = 28;
            // 
            // Result
            // 
            this.Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(78, 279);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(121, 21);
            this.Result.TabIndex = 29;
            // 
            // OpposingTeam
            // 
            this.OpposingTeam.DataSource = this.teamInfoBindingSource1;
            this.OpposingTeam.DisplayMember = "TeamName";
            this.OpposingTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpposingTeam.FormattingEnabled = true;
            this.OpposingTeam.Location = new System.Drawing.Point(78, 238);
            this.OpposingTeam.Name = "OpposingTeam";
            this.OpposingTeam.Size = new System.Drawing.Size(121, 21);
            this.OpposingTeam.TabIndex = 28;
            this.OpposingTeam.ValueMember = "TeamName";
            // 
            // teamInfoBindingSource
            // 
            this.teamInfoBindingSource.DataMember = "TeamInfo";
            this.teamInfoBindingSource.DataSource = this.kiddEsportsData_View;
            // 
            // kiddEsportsData_View
            // 
            this.kiddEsportsData_View.DataSetName = "KiddEsportsData_View";
            this.kiddEsportsData_View.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GamePlayed
            // 
            this.GamePlayed.DataSource = this.gamePlayedBindingSource;
            this.GamePlayed.DisplayMember = "GameName";
            this.GamePlayed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamePlayed.FormattingEnabled = true;
            this.GamePlayed.Location = new System.Drawing.Point(78, 150);
            this.GamePlayed.Name = "GamePlayed";
            this.GamePlayed.Size = new System.Drawing.Size(121, 21);
            this.GamePlayed.TabIndex = 27;
            this.GamePlayed.ValueMember = "GameName";
            // 
            // gamePlayedBindingSource
            // 
            this.gamePlayedBindingSource.DataMember = "GamePlayed";
            this.gamePlayedBindingSource.DataSource = this.kiddEsportsData_View;
            // 
            // Team
            // 
            this.Team.DataSource = this.teamInfoBindingSource;
            this.Team.DisplayMember = "TeamName";
            this.Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Team.FormattingEnabled = true;
            this.Team.Location = new System.Drawing.Point(78, 193);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(121, 21);
            this.Team.TabIndex = 26;
            this.Team.ValueMember = "TeamName";
            // 
            // EventName
            // 
            this.EventName.DataSource = this.eventBindingSource;
            this.EventName.DisplayMember = "EventName";
            this.EventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventName.FormattingEnabled = true;
            this.EventName.Location = new System.Drawing.Point(78, 110);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(121, 21);
            this.EventName.TabIndex = 25;
            this.EventName.ValueMember = "EventName";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.kiddEsportsData_View;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Opposing Team";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Game Played";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 90);
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
            this.panel4.Controls.Add(this.IDCombo);
            this.panel4.Controls.Add(this.ResultsCombo);
            this.panel4.Controls.Add(this.OpposingTeamCombo);
            this.panel4.Controls.Add(this.TeamNameCombo);
            this.panel4.Controls.Add(this.GamePlayedCombo);
            this.panel4.Controls.Add(this.EventNameCombo);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.UpdateBTN);
            this.panel4.Controls.Add(this.SearchBTN);
            this.panel4.Controls.Add(this.SearchTxtResults);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(6, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 355);
            this.panel4.TabIndex = 29;
            // 
            // IDCombo
            // 
            this.IDCombo.DataSource = this.teamResultsBindingSource;
            this.IDCombo.DisplayMember = "ID";
            this.IDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDCombo.FormattingEnabled = true;
            this.IDCombo.Location = new System.Drawing.Point(64, 317);
            this.IDCombo.Name = "IDCombo";
            this.IDCombo.Size = new System.Drawing.Size(63, 21);
            this.IDCombo.TabIndex = 43;
            this.IDCombo.ValueMember = "ID";
            // 
            // ResultsCombo
            // 
            this.ResultsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResultsCombo.FormattingEnabled = true;
            this.ResultsCombo.Location = new System.Drawing.Point(48, 278);
            this.ResultsCombo.Name = "ResultsCombo";
            this.ResultsCombo.Size = new System.Drawing.Size(79, 21);
            this.ResultsCombo.TabIndex = 42;
            // 
            // OpposingTeamCombo
            // 
            this.OpposingTeamCombo.DataSource = this.teamResultsBindingSource;
            this.OpposingTeamCombo.DisplayMember = "OpposingTeam";
            this.OpposingTeamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OpposingTeamCombo.FormattingEnabled = true;
            this.OpposingTeamCombo.Location = new System.Drawing.Point(48, 238);
            this.OpposingTeamCombo.Name = "OpposingTeamCombo";
            this.OpposingTeamCombo.Size = new System.Drawing.Size(121, 21);
            this.OpposingTeamCombo.TabIndex = 41;
            this.OpposingTeamCombo.ValueMember = "OpposingTeam";
            // 
            // TeamNameCombo
            // 
            this.TeamNameCombo.DataSource = this.teamResultsBindingSource;
            this.TeamNameCombo.DisplayMember = "Team";
            this.TeamNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamNameCombo.FormattingEnabled = true;
            this.TeamNameCombo.Location = new System.Drawing.Point(48, 193);
            this.TeamNameCombo.Name = "TeamNameCombo";
            this.TeamNameCombo.Size = new System.Drawing.Size(121, 21);
            this.TeamNameCombo.TabIndex = 40;
            this.TeamNameCombo.ValueMember = "Team";
            // 
            // GamePlayedCombo
            // 
            this.GamePlayedCombo.DataSource = this.teamResultsBindingSource;
            this.GamePlayedCombo.DisplayMember = "GamePlayed";
            this.GamePlayedCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamePlayedCombo.FormattingEnabled = true;
            this.GamePlayedCombo.Location = new System.Drawing.Point(48, 154);
            this.GamePlayedCombo.Name = "GamePlayedCombo";
            this.GamePlayedCombo.Size = new System.Drawing.Size(121, 21);
            this.GamePlayedCombo.TabIndex = 39;
            this.GamePlayedCombo.ValueMember = "GamePlayed";
            // 
            // EventNameCombo
            // 
            this.EventNameCombo.DataSource = this.teamResultsBindingSource;
            this.EventNameCombo.DisplayMember = "EventName";
            this.EventNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventNameCombo.FormattingEnabled = true;
            this.EventNameCombo.Location = new System.Drawing.Point(48, 107);
            this.EventNameCombo.Name = "EventNameCombo";
            this.EventNameCombo.Size = new System.Drawing.Size(121, 21);
            this.EventNameCombo.TabIndex = 38;
            this.EventNameCombo.ValueMember = "EventName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "ID";
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
            // teamInfoBindingSource1
            // 
            this.teamInfoBindingSource1.DataMember = "TeamInfo";
            this.teamInfoBindingSource1.DataSource = this.kiddEsportsData_View;
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
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // gamePlayedTableAdapter
            // 
            this.gamePlayedTableAdapter.ClearBeforeFill = true;
            // 
            // teamInfoTableAdapter
            // 
            this.teamInfoTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button AddNewTeamBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox SearchTxtResults;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button SortByEventResults;
        private System.Windows.Forms.Button SortByTeamNameResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ExportBTNResults;
        private System.Windows.Forms.Button ExportTeamName;
        private System.Windows.Forms.ComboBox OpposingTeam;
        private System.Windows.Forms.ComboBox GamePlayed;
        private System.Windows.Forms.ComboBox Team;
        private System.Windows.Forms.ComboBox EventName;
        private ICTPRG430AT2.KiddEsportsData_View kiddEsportsData_View;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private ICTPRG430AT2.KiddEsportsData_ViewTableAdapters.EventTableAdapter eventTableAdapter;
        private System.Windows.Forms.BindingSource gamePlayedBindingSource;
        private ICTPRG430AT2.KiddEsportsData_ViewTableAdapters.GamePlayedTableAdapter gamePlayedTableAdapter;
        private System.Windows.Forms.BindingSource teamInfoBindingSource;
        private ICTPRG430AT2.KiddEsportsData_ViewTableAdapters.TeamInfoTableAdapter teamInfoTableAdapter;
        private System.Windows.Forms.ComboBox Result;
        private System.Windows.Forms.ComboBox ResultsCombo;
        private System.Windows.Forms.ComboBox OpposingTeamCombo;
        private System.Windows.Forms.ComboBox TeamNameCombo;
        private System.Windows.Forms.ComboBox GamePlayedCombo;
        private System.Windows.Forms.ComboBox EventNameCombo;
        private System.Windows.Forms.BindingSource teamInfoBindingSource1;
        private System.Windows.Forms.ComboBox IDCombo;
    }
}