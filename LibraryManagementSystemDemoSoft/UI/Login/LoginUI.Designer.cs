namespace LibraryManagementSystemDemoSoft
{
    partial class LoginUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.readerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO LIBRARY MANAGEMENT SYSTEM";
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(249, 75);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(162, 67);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // readerButton
            // 
            this.readerButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readerButton.Location = new System.Drawing.Point(249, 183);
            this.readerButton.Name = "readerButton";
            this.readerButton.Size = new System.Drawing.Size(162, 67);
            this.readerButton.TabIndex = 2;
            this.readerButton.Text = "Reader";
            this.readerButton.UseVisualStyleBackColor = true;
            this.readerButton.Click += new System.EventHandler(this.readerButton_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(647, 319);
            this.Controls.Add(this.readerButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.label1);
            this.Name = "LoginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button readerButton;
    }
}

