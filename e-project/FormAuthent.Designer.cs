namespace e_project
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
            btnConnexion = new Button();
            txtBEmail = new TextBox();
            txtBPwd = new TextBox();
            lblEmail = new Label();
            lblPwd = new Label();
            SuspendLayout();
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(211, 231);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 0;
            btnConnexion.Text = "Connect ";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new Point(196, 134);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(125, 27);
            txtBEmail.TabIndex = 1;
            // 
            // txtBPwd
            // 
            txtBPwd.Location = new Point(196, 167);
            txtBPwd.Name = "txtBPwd";
            txtBPwd.Size = new Size(125, 27);
            txtBPwd.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(109, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(109, 174);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(70, 20);
            lblPwd.TabIndex = 7;
            lblPwd.Text = "Password";
            // 
            // FormAuthent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 549);
            Controls.Add(lblPwd);
            Controls.Add(lblEmail);
            Controls.Add(txtBPwd);
            Controls.Add(txtBEmail);
            Controls.Add(btnConnexion);
            Name = "FormAuthent";
            Text = "Authentification";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnexion;
        private TextBox txtBEmail;
        private TextBox txtBPwd;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblEmail;
        private Label lblPwd;
        private Label label4;
        private Label label5;
    }
}