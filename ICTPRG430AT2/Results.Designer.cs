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
            this.teamResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiddEsportsData = new ClassLibrary.KiddEsportsDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.ComboBox();
            this.OpposingTeam = new System.Windows.Forms.ComboBox();
            this.teamInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Team = new System.Windows.Forms.ComboBox();
            this.GamePlayed = new System.Windows.Forms.ComboBox();
            this.gamePlayedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventName = new System.Windows.Forms.ComboBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.IDTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchTxtResults = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SortByEventResults = new System.Windows.Forms.Button();
            this.SortByTeamNameResults = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ExportBTNResults = new System.Windows.Forms.Button();
            this.ExportTeamName = new System.Windows.Forms.Button();
            this.teamResultsTableAdapter = new ClassLibrary.KiddEsportsDataSetTableAdapters.TeamResultsTableAdapter();
            this.teamInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.EventNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GamePlayedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpposingTeamColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamResultsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventNameColumn,
            this.GamePlayedColumn,
            this.TeamColumn,
            this.OpposingTeamColumn,
            this.ResultColumn,
            this.IDColumn});
            this.dataGridView1.DataSource = this.teamResultsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 564);
            this.dataGridView1.TabIndex = 0;
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
            this.button4.Location = new System.Drawing.Point(45, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "Results";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "New Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Teams";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(44, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 46);
            this.button5.TabIndex = 9;
            this.button5.Text = "Events";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.Location = new System.Drawing.Point(44, 196);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(114, 46);
            this.Homebtn.TabIndex = 8;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = true;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Result);
            this.panel4.Controls.Add(this.OpposingTeam);
            this.panel4.Controls.Add(this.Team);
            this.panel4.Controls.Add(this.GamePlayed);
            this.panel4.Controls.Add(this.EventName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.IDTXT);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.UpdateBTN);
            this.panel4.Controls.Add(this.SearchBTN);
            this.panel4.Controls.Add(this.SearchTxtResults);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(971, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 355);
            this.panel4.TabIndex = 29;
            // 
            // Result
            // 
            this.Result.DataSource = this.teamInfoBindingSource;
            this.Result.DisplayMember = "TeamName";
            this.Result.FormattingEnabled = true;
            this.Result.Location = new System.Drawing.Point(95, 283);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(121, 21);
            this.Result.TabIndex = 49;
            this.Result.ValueMember = "TeamName";
            // 
            // OpposingTeam
            // 
            this.OpposingTeam.DataSource = this.teamInfoBindingSource;
            this.OpposingTeam.DisplayMember = "TeamName";
            this.OpposingTeam.FormattingEnabled = true;
            this.OpposingTeam.Location = new System.Drawing.Point(95, 243);
            this.OpposingTeam.Name = "OpposingTeam";
            this.OpposingTeam.Size = new System.Drawing.Size(121, 21);
            this.OpposingTeam.TabIndex = 48;
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
            // Team
            // 
            this.Team.DataSource = this.teamInfoBindingSource;
            this.Team.DisplayMember = "TeamName";
            this.Team.FormattingEnabled = true;
            this.Team.Location = new System.Drawing.Point(95, 197);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(121, 21);
            this.Team.TabIndex = 47;
            this.Team.ValueMember = "TeamName";
            // 
            // GamePlayed
            // 
            this.GamePlayed.DataSource = this.gamePlayedBindingSource;
            this.GamePlayed.DisplayMember = "GameName";
            this.GamePlayed.FormattingEnabled = true;
            this.GamePlayed.Location = new System.Drawing.Point(95, 158);
            this.GamePlayed.Name = "GamePlayed";
            this.GamePlayed.Size = new System.Drawing.Size(121, 21);
            this.GamePlayed.TabIndex = 46;
            this.GamePlayed.ValueMember = "GameName";
            // 
            // gamePlayedBindingSource
            // 
            this.gamePlayedBindingSource.DataMember = "GamePlayed";
            this.gamePlayedBindingSource.DataSource = this.kiddEsportsData_View;
            // 
            // EventName
            // 
            this.EventName.DataSource = this.eventBindingSource;
            this.EventName.DisplayMember = "EventName";
            this.EventName.FormattingEnabled = true;
            this.EventName.Location = new System.Drawing.Point(95, 112);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(121, 21);
            this.EventName.TabIndex = 45;
            this.EventName.ValueMember = "EventName";
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.kiddEsportsData_View;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Search By Event Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // IDTXT
            // 
            this.IDTXT.Enabled = false;
            this.IDTXT.Location = new System.Drawing.Point(64, 317);
            this.IDTXT.Name = "IDTXT";
            this.IDTXT.Size = new System.Drawing.Size(63, 20);
            this.IDTXT.TabIndex = 43;
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
            this.label15.Location = new System.Drawing.Point(92, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Winner";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(92, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Opposing Team";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(92, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Team";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(92, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Game Played";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(92, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Event Name";
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
            // teamResultsTableAdapter
            // 
            this.teamResultsTableAdapter.ClearBeforeFill = true;
            // 
            // teamInfoBindingSource1
            // 
            this.teamInfoBindingSource1.DataMember = "TeamInfo";
            this.teamInfoBindingSource1.DataSource = this.kiddEsportsData_View;
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
            // teamResultsBindingSource1
            // 
            this.teamResultsBindingSource1.DataMember = "TeamResults";
            this.teamResultsBindingSource1.DataSource = this.kiddEsportsData_View;
            // 
            // teamResultsTableAdapter1
            // 
            this.teamResultsTableAdapter.ClearBeforeFill = true;
            //                               
            // EventNameColumn
            // 
            this.EventNameColumn.DataPropertyName = "EventName";
            this.EventNameColumn.HeaderText = "EventName";
            this.EventNameColumn.Name = "EventNameColumn";
            this.EventNameColumn.ReadOnly = true;
            // 
            // GamePlayedColumn
            // 
            this.GamePlayedColumn.DataPropertyName = "GamePlayed";
            this.GamePlayedColumn.HeaderText = "GamePlayed";
            this.GamePlayedColumn.Name = "GamePlayedColumn";
            this.GamePlayedColumn.ReadOnly = true;
            // 
            // TeamColumn
            // 
            this.TeamColumn.DataPropertyName = "Team";
            this.TeamColumn.HeaderText = "Team";
            this.TeamColumn.Name = "TeamColumn";
            this.TeamColumn.ReadOnly = true;
            // 
            // OpposingTeamColumn
            // 
            this.OpposingTeamColumn.DataPropertyName = "OpposingTeam";
            this.OpposingTeamColumn.HeaderText = "OpposingTeam";
            this.OpposingTeamColumn.Name = "OpposingTeamColumn";
            this.OpposingTeamColumn.ReadOnly = true;
            // 
            // ResultColumn
            // 
            this.ResultColumn.DataPropertyName = "Result";
            this.ResultColumn.HeaderText = "Winner";
            this.ResultColumn.Name = "ResultColumn";
            this.ResultColumn.ReadOnly = true;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamResultsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private ClassLibrary.KiddEsportsDataSet kiddEsportsData;
        private System.Windows.Forms.BindingSource teamResultsBindingSource;
        private ClassLibrary.KiddEsportsDataSetTableAdapters.TeamResultsTableAdapter teamResultsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Homebtn;
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
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource gamePlayedBindingSource;
        private System.Windows.Forms.BindingSource teamInfoBindingSource;
        private System.Windows.Forms.BindingSource teamInfoBindingSource1;
        private System.Windows.Forms.TextBox IDTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Result;
        private System.Windows.Forms.ComboBox OpposingTeam;
        private System.Windows.Forms.ComboBox Team;
        private System.Windows.Forms.ComboBox GamePlayed;
        private System.Windows.Forms.ComboBox EventName;
        private System.Windows.Forms.BindingSource teamResultsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GamePlayedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpposingTeamColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
    }
}