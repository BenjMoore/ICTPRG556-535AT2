using ICTPRG430AT2;

namespace ClassLibrary
{
    partial class Event
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
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddEventBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EventLocationTXT = new System.Windows.Forms.TextBox();
            this.EventNameTXT = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ReturnName = new System.Windows.Forms.TextBox();
            this.ReturnID = new System.Windows.Forms.TextBox();
            this.ReturnDate = new System.Windows.Forms.TextBox();
            this.ReturnLocation = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteID = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.EventBTN = new System.Windows.Forms.Button();
            this.NewGameBTN = new System.Windows.Forms.Button();
            this.TeamsBTN = new System.Windows.Forms.Button();
            this.ResultsBTN = new System.Windows.Forms.Button();
            this.DeteleBTN = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EventNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiddEsportsDataViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsDataViewBindingSource)).BeginInit();
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
            this.EventLocationColumn,
            this.EventDateColumn,
            this.IDColumn});
            this.dataGridView1.DataSource = this.eventBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(283, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(681, 631);
            this.dataGridView1.TabIndex = 0;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.kiddEsportsDataViewBindingSource;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DateTimePicker);
            this.panel2.Controls.Add(this.AddEventBTN);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.EventLocationTXT);
            this.panel2.Controls.Add(this.EventNameTXT);
            this.panel2.Location = new System.Drawing.Point(970, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 328);
            this.panel2.TabIndex = 19;
            // 
            // AddEventBTN
            // 
            this.AddEventBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEventBTN.Location = new System.Drawing.Point(48, 255);
            this.AddEventBTN.Name = "AddEventBTN";
            this.AddEventBTN.Size = new System.Drawing.Size(200, 23);
            this.AddEventBTN.TabIndex = 22;
            this.AddEventBTN.Text = "Add";
            this.AddEventBTN.UseVisualStyleBackColor = true;
            this.AddEventBTN.Click += new System.EventHandler(this.AddEventBTN_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Event Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Event Location";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Add New Event";
            // 
            // EventLocationTXT
            // 
            this.EventLocationTXT.Location = new System.Drawing.Point(48, 148);
            this.EventLocationTXT.Name = "EventLocationTXT";
            this.EventLocationTXT.Size = new System.Drawing.Size(200, 20);
            this.EventLocationTXT.TabIndex = 14;
            // 
            // EventNameTXT
            // 
            this.EventNameTXT.BackColor = System.Drawing.Color.White;
            this.EventNameTXT.Location = new System.Drawing.Point(48, 106);
            this.EventNameTXT.Name = "EventNameTXT";
            this.EventNameTXT.Size = new System.Drawing.Size(200, 20);
            this.EventNameTXT.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.UpdateBTN);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ReturnName);
            this.panel3.Controls.Add(this.ReturnID);
            this.panel3.Controls.Add(this.ReturnDate);
            this.panel3.Controls.Add(this.ReturnLocation);
            this.panel3.Location = new System.Drawing.Point(73, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 236);
            this.panel3.TabIndex = 30;
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(103, 172);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateBTN.TabIndex = 10;
            this.UpdateBTN.Text = "Update";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Event Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Event Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Event Name";
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
            this.ReturnID.Location = new System.Drawing.Point(44, 172);
            this.ReturnID.Name = "ReturnID";
            this.ReturnID.Size = new System.Drawing.Size(40, 20);
            this.ReturnID.TabIndex = 3;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(90, 102);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(100, 20);
            this.ReturnDate.TabIndex = 1;
            // 
            // ReturnLocation
            // 
            this.ReturnLocation.Location = new System.Drawing.Point(90, 69);
            this.ReturnLocation.Name = "ReturnLocation";
            this.ReturnLocation.Size = new System.Drawing.Size(100, 20);
            this.ReturnLocation.TabIndex = 0;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(154, 440);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(123, 20);
            this.SearchTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Events";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 724);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "ID:";
            // 
            // DeleteID
            // 
            this.DeleteID.Location = new System.Drawing.Point(320, 721);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(56, 20);
            this.DeleteID.TabIndex = 37;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(73, 439);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(75, 23);
            this.SearchBTN.TabIndex = 40;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.Location = new System.Drawing.Point(118, 84);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(121, 61);
            this.HomeBTN.TabIndex = 41;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = true;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // EventBTN
            // 
            this.EventBTN.Location = new System.Drawing.Point(118, 218);
            this.EventBTN.Name = "EventBTN";
            this.EventBTN.Size = new System.Drawing.Size(121, 61);
            this.EventBTN.TabIndex = 42;
            this.EventBTN.Text = "Events";
            this.EventBTN.UseVisualStyleBackColor = true;
            // 
            // NewGameBTN
            // 
            this.NewGameBTN.Location = new System.Drawing.Point(118, 285);
            this.NewGameBTN.Name = "NewGameBTN";
            this.NewGameBTN.Size = new System.Drawing.Size(121, 61);
            this.NewGameBTN.TabIndex = 43;
            this.NewGameBTN.Text = "New Game";
            this.NewGameBTN.UseVisualStyleBackColor = true;
            this.NewGameBTN.Click += new System.EventHandler(this.NewGameBTN_Click);
            // 
            // TeamsBTN
            // 
            this.TeamsBTN.Location = new System.Drawing.Point(118, 352);
            this.TeamsBTN.Name = "TeamsBTN";
            this.TeamsBTN.Size = new System.Drawing.Size(121, 61);
            this.TeamsBTN.TabIndex = 44;
            this.TeamsBTN.Text = "Teams";
            this.TeamsBTN.UseVisualStyleBackColor = true;
            this.TeamsBTN.Click += new System.EventHandler(this.TeamsBTN_Click);
            // 
            // ResultsBTN
            // 
            this.ResultsBTN.Location = new System.Drawing.Point(118, 151);
            this.ResultsBTN.Name = "ResultsBTN";
            this.ResultsBTN.Size = new System.Drawing.Size(121, 61);
            this.ResultsBTN.TabIndex = 45;
            this.ResultsBTN.Text = "Results";
            this.ResultsBTN.UseVisualStyleBackColor = true;
            this.ResultsBTN.Click += new System.EventHandler(this.ResultsBTN_Click);
            // 
            // DeteleBTN
            // 
            this.DeteleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeteleBTN.Location = new System.Drawing.Point(382, 719);
            this.DeteleBTN.Name = "DeteleBTN";
            this.DeteleBTN.Size = new System.Drawing.Size(75, 23);
            this.DeteleBTN.TabIndex = 46;
            this.DeteleBTN.Text = "Delete";
            this.DeteleBTN.UseVisualStyleBackColor = true;
            this.DeteleBTN.Click += new System.EventHandler(this.DeteleBTN_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(48, 189);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 23;
            // 
            // EventNameColumn
            // 
            this.EventNameColumn.DataPropertyName = "EventName";
            this.EventNameColumn.HeaderText = "EventName";
            this.EventNameColumn.Name = "EventNameColumn";
            this.EventNameColumn.ReadOnly = true;
            // 
            // EventLocationColumn
            // 
            this.EventLocationColumn.DataPropertyName = "EventLocation";
            this.EventLocationColumn.HeaderText = "EventLocation";
            this.EventLocationColumn.Name = "EventLocationColumn";
            this.EventLocationColumn.ReadOnly = true;
            // 
            // EventDateColumn
            // 
            this.EventDateColumn.DataPropertyName = "EventDate";
            this.EventDateColumn.HeaderText = "EventDate";
            this.EventDateColumn.Name = "EventDateColumn";
            this.EventDateColumn.ReadOnly = true;
            this.EventDateColumn.Width = 200;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // kiddEsportsDataViewBindingSource
            // 
            this.kiddEsportsDataViewBindingSource.DataSource = this.kiddEsportsData_View;
            this.kiddEsportsDataViewBindingSource.Position = 0;
            // 
            // kiddEsportsData_View
            // 
            this.kiddEsportsData_View.DataSetName = "KiddEsportsData_View";
            this.kiddEsportsData_View.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 792);
            this.Controls.Add(this.DeteleBTN);
            this.Controls.Add(this.ResultsBTN);
            this.Controls.Add(this.TeamsBTN);
            this.Controls.Add(this.NewGameBTN);
            this.Controls.Add(this.EventBTN);
            this.Controls.Add(this.HomeBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Event";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsDataViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiddEsportsData_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EventLocationTXT;
        private System.Windows.Forms.TextBox EventNameTXT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ReturnName;
        private System.Windows.Forms.TextBox ReturnID;
        private System.Windows.Forms.TextBox ReturnDate;
        private System.Windows.Forms.TextBox ReturnLocation;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DeleteID;
        private System.Windows.Forms.BindingSource kiddEsportsDataViewBindingSource;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button EventBTN;
        private System.Windows.Forms.Button NewGameBTN;
        private System.Windows.Forms.Button TeamsBTN;
        private System.Windows.Forms.Button ResultsBTN;
        private System.Windows.Forms.Button AddEventBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Button DeteleBTN;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventLocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
    }
}