namespace ICTPRG430AT2
{
    partial class Menu
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
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teamInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kiddEsportsData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiddEsportsData1 = new ClassLibrary.KiddEsportsDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamePlayedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamInfoTableAdapter1 = new ClassLibrary.KiddEsportsDataSetTableAdapters.TeamInfoTableAdapter();
            this.eventTableAdapter = new ClassLibrary.KiddEsportsDataSetTableAdapters.EventsTableAdapter();
            this.teamInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.AutoScroll = true;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.Exit);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.Results);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.button4);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(1242, 614);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(1242, 614);
            this.toolStripContainer2.TabIndex = 5;
            this.toolStripContainer2.Text = "toolStripContainer2";
            this.toolStripContainer2.TopToolStripPanelVisible = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1164, 588);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(891, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Menu";
            // 
            // Results
            // 
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(920, 348);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(224, 132);
            this.Results.TabIndex = 11;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = true;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(920, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 128);
            this.button4.TabIndex = 10;
            this.button4.Text = "Events";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(711, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 132);
            this.button2.TabIndex = 8;
            this.button2.Text = "Games";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teams";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(711, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 128);
            this.button1.TabIndex = 6;
            this.button1.Text = "Teams";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kidd Esports";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teamInfoDataGridView);
            this.panel1.Location = new System.Drawing.Point(4, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 451);
            this.panel1.TabIndex = 0;
            // 
            // teamInfoDataGridView
            // 
            this.teamInfoDataGridView.AllowUserToOrderColumns = true;
            this.teamInfoDataGridView.AutoGenerateColumns = false;
            this.teamInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamNameDataGridViewTextBoxColumn,
            this.primaryContactDataGridViewTextBoxColumn,
            this.contactEmailDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.teamInfoDataGridView.DataSource = this.teamInfoBindingSource2;
            this.teamInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamInfoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.teamInfoDataGridView.Name = "teamInfoDataGridView";
            this.teamInfoDataGridView.Size = new System.Drawing.Size(544, 451);
            this.teamInfoDataGridView.TabIndex = 0;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // primaryContactDataGridViewTextBoxColumn
            // 
            this.primaryContactDataGridViewTextBoxColumn.DataPropertyName = "PrimaryContact";
            this.primaryContactDataGridViewTextBoxColumn.HeaderText = "PrimaryContact";
            this.primaryContactDataGridViewTextBoxColumn.Name = "primaryContactDataGridViewTextBoxColumn";
            // 
            // contactEmailDataGridViewTextBoxColumn
            // 
            this.contactEmailDataGridViewTextBoxColumn.DataPropertyName = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.HeaderText = "ContactEmail";
            this.contactEmailDataGridViewTextBoxColumn.Name = "contactEmailDataGridViewTextBoxColumn";
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamInfoBindingSource2
            // 
            this.teamInfoBindingSource2.DataMember = "TeamInfo";
            this.teamInfoBindingSource2.DataSource = this.kiddEsportsData1BindingSource;
            // 
            // kiddEsportsData1BindingSource
            // 
            this.kiddEsportsData1BindingSource.DataSource = this.kiddEsportsData1;
            this.kiddEsportsData1BindingSource.Position = 0;
            // 
            // kiddEsportsData1
            // 
            this.kiddEsportsData1.DataSetName = "KiddEsportsData";
            this.kiddEsportsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamsToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.resultsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 70);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.resultsToolStripMenuItem.Text = "Results";
            // 
            // teamInfoBindingSource1
            // 
            this.teamInfoBindingSource1.DataMember = "TeamInfo";
            this.teamInfoBindingSource1.DataSource = this.kiddEsportsData1BindingSource;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.kiddEsportsData1BindingSource;
            // 
            // gamePlayedBindingSource
            // 
            this.gamePlayedBindingSource.DataMember = "GamePlayed";
            this.gamePlayedBindingSource.DataSource = this.kiddEsportsData1BindingSource;
            // 
            // teamInfoTableAdapter1
            // 
            this.teamInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1242, 614);
            this.Controls.Add(this.toolStripContainer2);
            this.Name = "Menu";
            this.Text = "Kidd Esports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ContentPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlayedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ClassLibrary.KiddEsportsDataSet kiddEsportsData;
        private System.Windows.Forms.BindingSource teamInfoBindingSource;
        private ClassLibrary.KiddEsportsDataSetTableAdapters.TeamInfoTableAdapter teamInfoTableAdapter;
        private ClassLibrary.KiddEsportsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teamInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.BindingSource kiddEsportsData1BindingSource;
        private ClassLibrary.KiddEsportsDataSet kiddEsportsData1;
        private System.Windows.Forms.BindingSource teamInfoBindingSource1;
        private ClassLibrary.KiddEsportsDataSetTableAdapters.TeamInfoTableAdapter teamInfoTableAdapter1;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private ClassLibrary.KiddEsportsDataSetTableAdapters.EventsTableAdapter eventTableAdapter;
        private System.Windows.Forms.BindingSource gamePlayedBindingSource;
        private System.Windows.Forms.BindingSource teamInfoBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

