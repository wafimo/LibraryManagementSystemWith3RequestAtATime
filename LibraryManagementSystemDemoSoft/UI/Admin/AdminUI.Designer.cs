namespace LibraryManagementSystemDemoSoft.UI.Admin
{
    partial class AdminUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.readerListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveReaderButton = new System.Windows.Forms.Button();
            this.readerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.readerNameTextBox = new System.Windows.Forms.TextBox();
            this.readerIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.bookListGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.bookCopyTextBox = new System.Windows.Forms.TextBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.denyRequestButton = new System.Windows.Forms.Button();
            this.approveRequestButton = new System.Windows.Forms.Button();
            this.requestedBookIDTextBox = new System.Windows.Forms.TextBox();
            this.requestedReaderIDTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.requestListForAdminGridView = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerListDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestListForAdminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.readerListDataGridView);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Reader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reader List";
            // 
            // readerListDataGridView
            // 
            this.readerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readerListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.readerListDataGridView.Location = new System.Drawing.Point(44, 235);
            this.readerListDataGridView.Name = "readerListDataGridView";
            this.readerListDataGridView.Size = new System.Drawing.Size(446, 184);
            this.readerListDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Si. No.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Reader ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BookName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveReaderButton);
            this.groupBox1.Controls.Add(this.readerPasswordTextBox);
            this.groupBox1.Controls.Add(this.readerNameTextBox);
            this.groupBox1.Controls.Add(this.readerIDTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Reader";
            // 
            // saveReaderButton
            // 
            this.saveReaderButton.Location = new System.Drawing.Point(154, 117);
            this.saveReaderButton.Name = "saveReaderButton";
            this.saveReaderButton.Size = new System.Drawing.Size(75, 23);
            this.saveReaderButton.TabIndex = 3;
            this.saveReaderButton.Text = "Save";
            this.saveReaderButton.UseVisualStyleBackColor = true;
            this.saveReaderButton.Click += new System.EventHandler(this.saveReaderButton_Click);
            // 
            // readerPasswordTextBox
            // 
            this.readerPasswordTextBox.Location = new System.Drawing.Point(103, 91);
            this.readerPasswordTextBox.Name = "readerPasswordTextBox";
            this.readerPasswordTextBox.Size = new System.Drawing.Size(194, 20);
            this.readerPasswordTextBox.TabIndex = 2;
            // 
            // readerNameTextBox
            // 
            this.readerNameTextBox.Location = new System.Drawing.Point(103, 64);
            this.readerNameTextBox.Name = "readerNameTextBox";
            this.readerNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.readerNameTextBox.TabIndex = 1;
            // 
            // readerIDTextBox
            // 
            this.readerIDTextBox.Location = new System.Drawing.Point(103, 37);
            this.readerIDTextBox.Name = "readerIDTextBox";
            this.readerIDTextBox.Size = new System.Drawing.Size(194, 20);
            this.readerIDTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BookName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.bookListGridView);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 3;
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
            this.bookListGridView.Location = new System.Drawing.Point(19, 218);
            this.bookListGridView.Name = "bookListGridView";
            this.bookListGridView.ReadOnly = true;
            this.bookListGridView.Size = new System.Drawing.Size(446, 201);
            this.bookListGridView.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveBookButton);
            this.groupBox2.Controls.Add(this.bookCopyTextBox);
            this.groupBox2.Controls.Add(this.bookIDTextBox);
            this.groupBox2.Controls.Add(this.bookNameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(19, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Book";
            // 
            // saveBookButton
            // 
            this.saveBookButton.Location = new System.Drawing.Point(151, 133);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(75, 23);
            this.saveBookButton.TabIndex = 3;
            this.saveBookButton.Text = "Save";
            this.saveBookButton.UseVisualStyleBackColor = true;
            this.saveBookButton.Click += new System.EventHandler(this.saveBookButton_Click);
            // 
            // bookCopyTextBox
            // 
            this.bookCopyTextBox.Location = new System.Drawing.Point(100, 107);
            this.bookCopyTextBox.Name = "bookCopyTextBox";
            this.bookCopyTextBox.Size = new System.Drawing.Size(194, 20);
            this.bookCopyTextBox.TabIndex = 2;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(100, 54);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(194, 20);
            this.bookIDTextBox.TabIndex = 1;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(100, 80);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.bookNameTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Copy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Book BookName";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(813, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Request";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.denyRequestButton);
            this.groupBox4.Controls.Add(this.approveRequestButton);
            this.groupBox4.Controls.Add(this.requestedBookIDTextBox);
            this.groupBox4.Controls.Add(this.requestedReaderIDTextBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(558, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 186);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accept Panel";
            // 
            // denyRequestButton
            // 
            this.denyRequestButton.Location = new System.Drawing.Point(123, 126);
            this.denyRequestButton.Name = "denyRequestButton";
            this.denyRequestButton.Size = new System.Drawing.Size(75, 37);
            this.denyRequestButton.TabIndex = 2;
            this.denyRequestButton.Text = "Deny";
            this.denyRequestButton.UseVisualStyleBackColor = true;
            this.denyRequestButton.Click += new System.EventHandler(this.denyRequestButton_Click);
            // 
            // approveRequestButton
            // 
            this.approveRequestButton.Location = new System.Drawing.Point(42, 126);
            this.approveRequestButton.Name = "approveRequestButton";
            this.approveRequestButton.Size = new System.Drawing.Size(75, 37);
            this.approveRequestButton.TabIndex = 2;
            this.approveRequestButton.Text = "Approve";
            this.approveRequestButton.UseVisualStyleBackColor = true;
            this.approveRequestButton.Click += new System.EventHandler(this.approveRequestButton_Click);
            // 
            // requestedBookIDTextBox
            // 
            this.requestedBookIDTextBox.Location = new System.Drawing.Point(56, 91);
            this.requestedBookIDTextBox.Name = "requestedBookIDTextBox";
            this.requestedBookIDTextBox.ReadOnly = true;
            this.requestedBookIDTextBox.Size = new System.Drawing.Size(125, 20);
            this.requestedBookIDTextBox.TabIndex = 1;
            // 
            // requestedReaderIDTextBox
            // 
            this.requestedReaderIDTextBox.Location = new System.Drawing.Point(56, 41);
            this.requestedReaderIDTextBox.Name = "requestedReaderIDTextBox";
            this.requestedReaderIDTextBox.ReadOnly = true;
            this.requestedReaderIDTextBox.Size = new System.Drawing.Size(125, 20);
            this.requestedReaderIDTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Book ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Reader ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.requestListForAdminGridView);
            this.groupBox3.Location = new System.Drawing.Point(8, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 328);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request List";
            // 
            // requestListForAdminGridView
            // 
            this.requestListForAdminGridView.AllowUserToAddRows = false;
            this.requestListForAdminGridView.AllowUserToDeleteRows = false;
            this.requestListForAdminGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestListForAdminGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.requestListForAdminGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestListForAdminGridView.Location = new System.Drawing.Point(3, 16);
            this.requestListForAdminGridView.Name = "requestListForAdminGridView";
            this.requestListForAdminGridView.ReadOnly = true;
            this.requestListForAdminGridView.Size = new System.Drawing.Size(538, 309);
            this.requestListForAdminGridView.TabIndex = 0;
            this.requestListForAdminGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestListForAdminGridView_CellClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Si. No.";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Reader ID";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Book ID";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Status";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminUI_FormClosing);
            this.Load += new System.EventHandler(this.AdminUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readerListDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestListForAdminGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView readerListDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveReaderButton;
        private System.Windows.Forms.TextBox readerPasswordTextBox;
        private System.Windows.Forms.TextBox readerNameTextBox;
        private System.Windows.Forms.TextBox readerIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveBookButton;
        private System.Windows.Forms.TextBox bookCopyTextBox;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView bookListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView requestListForAdminGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button denyRequestButton;
        private System.Windows.Forms.Button approveRequestButton;
        private System.Windows.Forms.TextBox requestedBookIDTextBox;
        private System.Windows.Forms.TextBox requestedReaderIDTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}