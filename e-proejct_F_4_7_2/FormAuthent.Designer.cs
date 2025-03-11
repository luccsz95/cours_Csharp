namespace e_proejct_F_4_7_2
{
    partial class FormAuthent
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
            this.connectionBtn = new System.Windows.Forms.Button();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.pswTxtBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.PwdLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionBtn
            // 
            this.connectionBtn.Location = new System.Drawing.Point(189, 169);
            this.connectionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.Size = new System.Drawing.Size(77, 34);
            this.connectionBtn.TabIndex = 0;
            this.connectionBtn.Text = "Connect";
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.connectionBtn_Click);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(51, 210);
            this.createAccountBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(369, 34);
            this.createAccountBtn.TabIndex = 1;
            this.createAccountBtn.Text = "Don\'t have an account ? Create one !";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(177, 90);
            this.emailTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(100, 22);
            this.emailTxtBox.TabIndex = 2;
            // 
            // pswTxtBox
            // 
            this.pswTxtBox.Location = new System.Drawing.Point(177, 130);
            this.pswTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pswTxtBox.Name = "pswTxtBox";
            this.pswTxtBox.PasswordChar = '*';
            this.pswTxtBox.Size = new System.Drawing.Size(100, 22);
            this.pswTxtBox.TabIndex = 3;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(104, 96);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(41, 16);
            this.emailLbl.TabIndex = 4;
            this.emailLbl.Text = "Email";
            // 
            // PwdLbl
            // 
            this.PwdLbl.AutoSize = true;
            this.PwdLbl.Location = new System.Drawing.Point(104, 137);
            this.PwdLbl.Name = "PwdLbl";
            this.PwdLbl.Size = new System.Drawing.Size(67, 16);
            this.PwdLbl.TabIndex = 5;
            this.PwdLbl.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAuthent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PwdLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.pswTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.connectionBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAuthent";
            this.Text = "FormAuthent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.TextBox pswTxtBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label PwdLbl;
        private System.Windows.Forms.Button button1;
    }
}