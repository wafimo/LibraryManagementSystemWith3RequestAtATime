namespace LibraryManagementSystemDemoSoft.UI.Login
{
    partial class ReaderLoginUI
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
            this.readerLoginButton = new System.Windows.Forms.Button();
            this.readerIdTextBox = new System.Windows.Forms.TextBox();
            this.readerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.readerLoginButton);
            this.groupBox1.Controls.Add(this.readerIdTextBox);
            this.groupBox1.Controls.Add(this.readerPasswordTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(176, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader";
            // 
            // readerLoginButton
            // 
            this.readerLoginButton.Location = new System.Drawing.Point(170, 110);
            this.readerLoginButton.Name = "readerLoginButton";
            this.readerLoginButton.Size = new System.Drawing.Size(75, 23);
            this.readerLoginButton.TabIndex = 2;
            this.readerLoginButton.Text = "Login";
            this.readerLoginButton.UseVisualStyleBackColor = true;
            this.readerLoginButton.Click += new System.EventHandler(this.readerLoginButton_Click);
            // 
            // readerIdTextBox
            // 
            this.readerIdTextBox.Location = new System.Drawing.Point(127, 38);
            this.readerIdTextBox.Name = "readerIdTextBox";
            this.readerIdTextBox.Size = new System.Drawing.Size(156, 20);
            this.readerIdTextBox.TabIndex = 0;
            // 
            // readerPasswordTextBox
            // 
            this.readerPasswordTextBox.Location = new System.Drawing.Point(127, 73);
            this.readerPasswordTextBox.Name = "readerPasswordTextBox";
            this.readerPasswordTextBox.Size = new System.Drawing.Size(156, 20);
            this.readerPasswordTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reader ID";
            // 
            // ReaderLoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReaderLoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader Login UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReaderLoginUI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button readerLoginButton;
        private System.Windows.Forms.TextBox readerIdTextBox;
        private System.Windows.Forms.TextBox readerPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}