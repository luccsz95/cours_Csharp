namespace e_proejct_F_4_7_2
{
    partial class FormUpdateUser
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifiyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phNbLbl = new System.Windows.Forms.Label();
            this.phTxtBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.pwdTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.clearTxtBoxBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV.Location = new System.Drawing.Point(12, 12);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(985, 228);
            this.DGV.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDBToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.modifiyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 76);
            // 
            // openDBToolStripMenuItem
            // 
            this.openDBToolStripMenuItem.Name = "openDBToolStripMenuItem";
            this.openDBToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.openDBToolStripMenuItem.Text = "Refresh the information";
            this.openDBToolStripMenuItem.Click += new System.EventHandler(this.openDBToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.deleteToolStripMenuItem.Text = "Delete a User";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // modifiyToolStripMenuItem
            // 
            this.modifiyToolStripMenuItem.Name = "modifiyToolStripMenuItem";
            this.modifiyToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.modifiyToolStripMenuItem.Text = "Modify a User";
            this.modifiyToolStripMenuItem.Click += new System.EventHandler(this.modifiyToolStripMenuItem_Click);
            // 
            // phNbLbl
            // 
            this.phNbLbl.AutoSize = true;
            this.phNbLbl.Location = new System.Drawing.Point(127, 367);
            this.phNbLbl.Name = "phNbLbl";
            this.phNbLbl.Size = new System.Drawing.Size(97, 16);
            this.phNbLbl.TabIndex = 34;
            this.phNbLbl.Text = "Phone Number";
            // 
            // phTxtBox
            // 
            this.phTxtBox.Location = new System.Drawing.Point(12, 361);
            this.phTxtBox.Name = "phTxtBox";
            this.phTxtBox.Size = new System.Drawing.Size(109, 22);
            this.phTxtBox.TabIndex = 33;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 422);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 31);
            this.updateBtn.TabIndex = 32;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // pwdLbl
            // 
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Location = new System.Drawing.Point(127, 339);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(67, 16);
            this.pwdLbl.TabIndex = 29;
            this.pwdLbl.Text = "Password";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(127, 311);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(41, 16);
            this.emailLbl.TabIndex = 28;
            this.emailLbl.Text = "Email";
            // 
            // pwdTxtBox
            // 
            this.pwdTxtBox.Location = new System.Drawing.Point(12, 333);
            this.pwdTxtBox.Name = "pwdTxtBox";
            this.pwdTxtBox.PasswordChar = '*';
            this.pwdTxtBox.Size = new System.Drawing.Size(109, 22);
            this.pwdTxtBox.TabIndex = 26;
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(12, 305);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.Size = new System.Drawing.Size(109, 22);
            this.emailTxtBox.TabIndex = 25;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(127, 280);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(66, 16);
            this.firstNameLbl.TabIndex = 24;
            this.firstNameLbl.Text = "Firstname";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(127, 252);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(69, 16);
            this.lastNameLbl.TabIndex = 23;
            this.lastNameLbl.Text = "Lastname ";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(12, 482);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(90, 31);
            this.stopBtn.TabIndex = 22;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(12, 274);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(109, 22);
            this.firstNameTxtBox.TabIndex = 21;
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(12, 246);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(109, 22);
            this.lastNameTxtBox.TabIndex = 20;
            // 
            // clearTxtBoxBtn
            // 
            this.clearTxtBoxBtn.Location = new System.Drawing.Point(108, 422);
            this.clearTxtBoxBtn.Name = "clearTxtBoxBtn";
            this.clearTxtBoxBtn.Size = new System.Drawing.Size(108, 31);
            this.clearTxtBoxBtn.TabIndex = 36;
            this.clearTxtBoxBtn.Text = "Clear TextBox";
            this.clearTxtBoxBtn.UseVisualStyleBackColor = true;
            this.clearTxtBoxBtn.Click += new System.EventHandler(this.clearTxtBoxBtn_Click);
            // 
            // FormUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 567);
            this.Controls.Add(this.clearTxtBoxBtn);
            this.Controls.Add(this.phNbLbl);
            this.Controls.Add(this.phTxtBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.pwdLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.pwdTxtBox);
            this.Controls.Add(this.emailTxtBox);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.DGV);
            this.Name = "FormUpdateUser";
            this.Text = "FormUpdateUser";
            this.Load += new System.EventHandler(this.FormUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label phNbLbl;
        private System.Windows.Forms.TextBox phTxtBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox pwdTxtBox;
        private System.Windows.Forms.TextBox emailTxtBox;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifiyToolStripMenuItem;
        private System.Windows.Forms.Button clearTxtBoxBtn;
    }
}