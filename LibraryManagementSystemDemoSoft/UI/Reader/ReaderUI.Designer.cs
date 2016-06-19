namespace LibraryManagementSystemDemoSoft.UI
{
    partial class ReaderUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.readerNameTextBox = new System.Windows.Forms.TextBox();
            this.readerIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookListGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedBookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.approvedBookListGridView = new System.Windows.Forms.DataGridView();
            this.returnBookIDTextBox = new System.Windows.Forms.TextBox();
            this.clearRequestedBookTextBox = new System.Windows.Forms.TextBox();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.clearRequestedBookButton = new System.Windows.Forms.Button();
            this.AddBookToGridButton = new System.Windows.Forms.Button();
            this.temporaryRequestedBookGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvedBookListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryRequestedBookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.readerNameTextBox);
            this.groupBox1.Controls.Add(this.readerIDTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Today is";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // readerNameTextBox
            // 
            this.readerNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.readerNameTextBox.Location = new System.Drawing.Point(118, 64);
            this.readerNameTextBox.Name = "readerNameTextBox";
            this.readerNameTextBox.ReadOnly = true;
            this.readerNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.readerNameTextBox.TabIndex = 1;
            // 
            // readerIDTextBox
            // 
            this.readerIDTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.readerIDTextBox.Location = new System.Drawing.Point(118, 33);
            this.readerIDTextBox.Name = "readerIDTextBox";
            this.readerIDTextBox.ReadOnly = true;
            this.readerIDTextBox.Size = new System.Drawing.Size(167, 20);
            this.readerIDTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reader BookName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Book List";
            // 
            // bookListGridView
            // 
            this.bookListGridView.AllowUserToAddRows = false;
            this.bookListGridView.AllowUserToDeleteRows = false;
            this.bookListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.bookListGridView.Location = new System.Drawing.Point(170, 137);
            this.bookListGridView.Name = "bookListGridView";
            this.bookListGridView.ReadOnly = true;
            this.bookListGridView.Size = new System.Drawing.Size(446, 140);
            this.bookListGridView.TabIndex = 4;
            this.bookListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookListGridView_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Si. No.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Book ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Book BookName";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Copy";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // requestedBookID
            // 
            this.requestedBookID.Location = new System.Drawing.Point(77, 19);
            this.requestedBookID.Name = "requestedBookID";
            this.requestedBookID.ReadOnly = true;
            this.requestedBookID.Size = new System.Drawing.Size(100, 20);
            this.requestedBookID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Requested Book List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.feeTextBox);
            this.groupBox2.Controls.Add(this.approvedBookListGridView);
            this.groupBox2.Controls.Add(this.returnBookIDTextBox);
            this.groupBox2.Controls.Add(this.clearRequestedBookTextBox);
            this.groupBox2.Controls.Add(this.returnBookButton);
            this.groupBox2.Controls.Add(this.clearRequestedBookButton);
            this.groupBox2.Controls.Add(this.AddBookToGridButton);
            this.groupBox2.Controls.Add(this.temporaryRequestedBookGridView);
            this.groupBox2.Controls.Add(this.requestedBookID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(0, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 313);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Book Panel";
            // 
            // approvedBookListGridView
            // 
            this.approvedBookListGridView.AllowUserToAddRows = false;
            this.approvedBookListGridView.AllowUserToDeleteRows = false;
            this.approvedBookListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.approvedBookListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column9,
            this.Column10,
            this.Column11});
            this.approvedBookListGridView.Location = new System.Drawing.Point(409, 70);
            this.approvedBookListGridView.Name = "approvedBookListGridView";
            this.approvedBookListGridView.ReadOnly = true;
            this.approvedBookListGridView.Size = new System.Drawing.Size(447, 112);
            this.approvedBookListGridView.TabIndex = 11;
            this.approvedBookListGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.approvedBookListGridView_CellContentDoubleClick);
            // 
            // returnBookIDTextBox
            // 
            this.returnBookIDTextBox.Location = new System.Drawing.Point(481, 190);
            this.returnBookIDTextBox.Name = "returnBookIDTextBox";
            this.returnBookIDTextBox.ReadOnly = true;
            this.returnBookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.returnBookIDTextBox.TabIndex = 10;
            // 
            // clearRequestedBookTextBox
            // 
            this.clearRequestedBookTextBox.Location = new System.Drawing.Point(77, 193);
            this.clearRequestedBookTextBox.Name = "clearRequestedBookTextBox";
            this.clearRequestedBookTextBox.ReadOnly = true;
            this.clearRequestedBookTextBox.Size = new System.Drawing.Size(100, 20);
            this.clearRequestedBookTextBox.TabIndex = 10;
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(693, 185);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(78, 28);
            this.returnBookButton.TabIndex = 9;
            this.returnBookButton.Text = "Return";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // clearRequestedBookButton
            // 
            this.clearRequestedBookButton.Location = new System.Drawing.Point(183, 188);
            this.clearRequestedBookButton.Name = "clearRequestedBookButton";
            this.clearRequestedBookButton.Size = new System.Drawing.Size(78, 28);
            this.clearRequestedBookButton.TabIndex = 9;
            this.clearRequestedBookButton.Text = "Clear";
            this.clearRequestedBookButton.UseVisualStyleBackColor = true;
            this.clearRequestedBookButton.Click += new System.EventHandler(this.clearRequestedBookButton_Click);
            // 
            // AddBookToGridButton
            // 
            this.AddBookToGridButton.Location = new System.Drawing.Point(183, 14);
            this.AddBookToGridButton.Name = "AddBookToGridButton";
            this.AddBookToGridButton.Size = new System.Drawing.Size(78, 28);
            this.AddBookToGridButton.TabIndex = 9;
            this.AddBookToGridButton.Text = "Add";
            this.AddBookToGridButton.UseVisualStyleBackColor = true;
            this.AddBookToGridButton.Click += new System.EventHandler(this.AddBookToGridButton_Click);
            // 
            // temporaryRequestedBookGridView
            // 
            this.temporaryRequestedBookGridView.AllowUserToAddRows = false;
            this.temporaryRequestedBookGridView.AllowUserToDeleteRows = false;
            this.temporaryRequestedBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temporaryRequestedBookGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.temporaryRequestedBookGridView.Location = new System.Drawing.Point(21, 70);
            this.temporaryRequestedBookGridView.Name = "temporaryRequestedBookGridView";
            this.temporaryRequestedBookGridView.ReadOnly = true;
            this.temporaryRequestedBookGridView.Size = new System.Drawing.Size(345, 112);
            this.temporaryRequestedBookGridView.TabIndex = 8;
            this.temporaryRequestedBookGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.temporaryRequestedBookGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Si. No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Requested Book ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Approved Book List";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Si. No.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Approved Book ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Book BookName";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Date of Return";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(628, 188);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(59, 20);
            this.feeTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Book ID";
            // 
            // ReaderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 622);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bookListGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReaderUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReaderUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReaderUI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.approvedBookListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryRequestedBookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox readerNameTextBox;
        private System.Windows.Forms.TextBox readerIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView bookListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox requestedBookID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddBookToGridButton;
        private System.Windows.Forms.DataGridView temporaryRequestedBookGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox clearRequestedBookTextBox;
        private System.Windows.Forms.Button clearRequestedBookButton;
        private System.Windows.Forms.DataGridView approvedBookListGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox returnBookIDTextBox;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox feeTextBox;
    }
}