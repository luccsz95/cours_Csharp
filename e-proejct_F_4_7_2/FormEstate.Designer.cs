namespace e_proejct_F_4_7_2
{
    partial class FormEstate
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
            this.openDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePropretyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePropretyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProprety = new System.Windows.Forms.Label();
            this.lblConstrucYrs = new System.Windows.Forms.Label();
            this.lblNbRoom = new System.Windows.Forms.Label();
            this.lblNbBedrooms = new System.Windows.Forms.Label();
            this.lblSurface = new System.Windows.Forms.Label();
            this.txtBoxProprety = new System.Windows.Forms.TextBox();
            this.txtBoxConstrucYrs = new System.Windows.Forms.TextBox();
            this.txtBoxNbRooms = new System.Windows.Forms.TextBox();
            this.txtBoxNbBedrooms = new System.Windows.Forms.TextBox();
            this.txtBoxSurface = new System.Windows.Forms.TextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblIdProprety = new System.Windows.Forms.Label();
            this.comboBoxProprety = new System.Windows.Forms.ComboBox();
            this.txtBoxIdProprety = new System.Windows.Forms.TextBox();
            this.addPropretyBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.researchBtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testBtnResearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxLinkImage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV.Location = new System.Drawing.Point(19, 43);
            this.DGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.Size = new System.Drawing.Size(1035, 185);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDataBaseToolStripMenuItem,
            this.updatePropretyToolStripMenuItem,
            this.deletePropretyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 104);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // openDataBaseToolStripMenuItem
            // 
            this.openDataBaseToolStripMenuItem.Name = "openDataBaseToolStripMenuItem";
            this.openDataBaseToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.openDataBaseToolStripMenuItem.Text = "Refresh the informations";
            this.openDataBaseToolStripMenuItem.Click += new System.EventHandler(this.openDataBaseToolStripMenuItem_Click);
            // 
            // updatePropretyToolStripMenuItem
            // 
            this.updatePropretyToolStripMenuItem.Name = "updatePropretyToolStripMenuItem";
            this.updatePropretyToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.updatePropretyToolStripMenuItem.Text = "Modify Proprety";
            this.updatePropretyToolStripMenuItem.Click += new System.EventHandler(this.updatePropretyToolStripMenuItem_Click);
            // 
            // deletePropretyToolStripMenuItem
            // 
            this.deletePropretyToolStripMenuItem.Name = "deletePropretyToolStripMenuItem";
            this.deletePropretyToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.deletePropretyToolStripMenuItem.Text = "Delete Proprety";
            this.deletePropretyToolStripMenuItem.Click += new System.EventHandler(this.deletePropretyToolStripMenuItem_Click);
            // 
            // lblProprety
            // 
            this.lblProprety.AutoSize = true;
            this.lblProprety.Location = new System.Drawing.Point(908, 275);
            this.lblProprety.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProprety.Name = "lblProprety";
            this.lblProprety.Size = new System.Drawing.Size(44, 16);
            this.lblProprety.TabIndex = 1;
            this.lblProprety.Text = "Name";
            // 
            // lblConstrucYrs
            // 
            this.lblConstrucYrs.AutoSize = true;
            this.lblConstrucYrs.Location = new System.Drawing.Point(908, 307);
            this.lblConstrucYrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConstrucYrs.Name = "lblConstrucYrs";
            this.lblConstrucYrs.Size = new System.Drawing.Size(117, 16);
            this.lblConstrucYrs.TabIndex = 2;
            this.lblConstrucYrs.Text = "Construction years";
            // 
            // lblNbRoom
            // 
            this.lblNbRoom.AutoSize = true;
            this.lblNbRoom.Location = new System.Drawing.Point(908, 339);
            this.lblNbRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbRoom.Name = "lblNbRoom";
            this.lblNbRoom.Size = new System.Drawing.Size(110, 16);
            this.lblNbRoom.TabIndex = 3;
            this.lblNbRoom.Text = "Number of rooms";
            // 
            // lblNbBedrooms
            // 
            this.lblNbBedrooms.AutoSize = true;
            this.lblNbBedrooms.Location = new System.Drawing.Point(908, 371);
            this.lblNbBedrooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbBedrooms.Name = "lblNbBedrooms";
            this.lblNbBedrooms.Size = new System.Drawing.Size(134, 16);
            this.lblNbBedrooms.TabIndex = 4;
            this.lblNbBedrooms.Text = "Number of bedrooms";
            // 
            // lblSurface
            // 
            this.lblSurface.AutoSize = true;
            this.lblSurface.Location = new System.Drawing.Point(908, 403);
            this.lblSurface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurface.Name = "lblSurface";
            this.lblSurface.Size = new System.Drawing.Size(53, 16);
            this.lblSurface.TabIndex = 5;
            this.lblSurface.Text = "Surface";
            // 
            // txtBoxProprety
            // 
            this.txtBoxProprety.Location = new System.Drawing.Point(15, 366);
            this.txtBoxProprety.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxProprety.Name = "txtBoxProprety";
            this.txtBoxProprety.Size = new System.Drawing.Size(132, 22);
            this.txtBoxProprety.TabIndex = 6;
            this.txtBoxProprety.Visible = false;
            // 
            // txtBoxConstrucYrs
            // 
            this.txtBoxConstrucYrs.Location = new System.Drawing.Point(766, 300);
            this.txtBoxConstrucYrs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxConstrucYrs.Name = "txtBoxConstrucYrs";
            this.txtBoxConstrucYrs.Size = new System.Drawing.Size(132, 22);
            this.txtBoxConstrucYrs.TabIndex = 7;
            // 
            // txtBoxNbRooms
            // 
            this.txtBoxNbRooms.Location = new System.Drawing.Point(766, 332);
            this.txtBoxNbRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxNbRooms.Name = "txtBoxNbRooms";
            this.txtBoxNbRooms.Size = new System.Drawing.Size(132, 22);
            this.txtBoxNbRooms.TabIndex = 8;
            // 
            // txtBoxNbBedrooms
            // 
            this.txtBoxNbBedrooms.Location = new System.Drawing.Point(766, 364);
            this.txtBoxNbBedrooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxNbBedrooms.Name = "txtBoxNbBedrooms";
            this.txtBoxNbBedrooms.Size = new System.Drawing.Size(132, 22);
            this.txtBoxNbBedrooms.TabIndex = 9;
            // 
            // txtBoxSurface
            // 
            this.txtBoxSurface.Location = new System.Drawing.Point(766, 396);
            this.txtBoxSurface.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSurface.Name = "txtBoxSurface";
            this.txtBoxSurface.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSurface.TabIndex = 10;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(16, 475);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(100, 28);
            this.stopBtn.TabIndex = 12;
            this.stopBtn.Text = "STOP";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Visible = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(16, 511);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 28);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblIdProprety
            // 
            this.lblIdProprety.AutoSize = true;
            this.lblIdProprety.Location = new System.Drawing.Point(157, 343);
            this.lblIdProprety.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProprety.Name = "lblIdProprety";
            this.lblIdProprety.Size = new System.Drawing.Size(74, 16);
            this.lblIdProprety.TabIndex = 15;
            this.lblIdProprety.Text = "ID Proprety";
            this.lblIdProprety.Visible = false;
            // 
            // comboBoxProprety
            // 
            this.comboBoxProprety.FormattingEnabled = true;
            this.comboBoxProprety.Items.AddRange(new object[] {
            "House",
            "Appartement"});
            this.comboBoxProprety.Location = new System.Drawing.Point(766, 268);
            this.comboBoxProprety.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProprety.Name = "comboBoxProprety";
            this.comboBoxProprety.Size = new System.Drawing.Size(132, 24);
            this.comboBoxProprety.TabIndex = 17;
            // 
            // txtBoxIdProprety
            // 
            this.txtBoxIdProprety.Location = new System.Drawing.Point(16, 335);
            this.txtBoxIdProprety.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxIdProprety.Name = "txtBoxIdProprety";
            this.txtBoxIdProprety.Size = new System.Drawing.Size(132, 22);
            this.txtBoxIdProprety.TabIndex = 14;
            this.txtBoxIdProprety.Visible = false;
            // 
            // addPropretyBtn
            // 
            this.addPropretyBtn.Location = new System.Drawing.Point(766, 466);
            this.addPropretyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPropretyBtn.Name = "addPropretyBtn";
            this.addPropretyBtn.Size = new System.Drawing.Size(103, 28);
            this.addPropretyBtn.TabIndex = 18;
            this.addPropretyBtn.Text = "Add Proprety";
            this.addPropretyBtn.UseVisualStyleBackColor = true;
            this.addPropretyBtn.Click += new System.EventHandler(this.addPropretyBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(766, 500);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(103, 27);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Appartment",
            "House",
            "All"});
            this.comboBox1.Location = new System.Drawing.Point(239, 495);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // researchBtn
            // 
            this.researchBtn.Location = new System.Drawing.Point(516, 496);
            this.researchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.researchBtn.Name = "researchBtn";
            this.researchBtn.Size = new System.Drawing.Size(105, 25);
            this.researchBtn.TabIndex = 22;
            this.researchBtn.Text = "Research";
            this.researchBtn.UseVisualStyleBackColor = true;
            this.researchBtn.Visible = false;
            this.researchBtn.Click += new System.EventHandler(this.researchBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 14);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 20);
            this.radioButton1.TabIndex = 28;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Proprety";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 14);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 20);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Construction Years";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(251, 14);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 20);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Surface";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(521, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Visible = false;
            // 
            // testBtnResearch
            // 
            this.testBtnResearch.Location = new System.Drawing.Point(239, 402);
            this.testBtnResearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testBtnResearch.Name = "testBtnResearch";
            this.testBtnResearch.Size = new System.Drawing.Size(155, 70);
            this.testBtnResearch.TabIndex = 24;
            this.testBtnResearch.Text = "Test research button";
            this.testBtnResearch.UseVisualStyleBackColor = true;
            this.testBtnResearch.Visible = false;
            this.testBtnResearch.Click += new System.EventHandler(this.testBtnResearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 402);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 69);
            this.button2.TabIndex = 26;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtBoxLinkImage
            // 
            this.txtBoxLinkImage.Location = new System.Drawing.Point(766, 429);
            this.txtBoxLinkImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLinkImage.Name = "txtBoxLinkImage";
            this.txtBoxLinkImage.Size = new System.Drawing.Size(132, 22);
            this.txtBoxLinkImage.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(906, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Liens d\'accès des images";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxLinkImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.testBtnResearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.researchBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addPropretyBtn);
            this.Controls.Add(this.comboBoxProprety);
            this.Controls.Add(this.lblIdProprety);
            this.Controls.Add(this.txtBoxIdProprety);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.txtBoxSurface);
            this.Controls.Add(this.txtBoxNbBedrooms);
            this.Controls.Add(this.txtBoxNbRooms);
            this.Controls.Add(this.txtBoxConstrucYrs);
            this.Controls.Add(this.txtBoxProprety);
            this.Controls.Add(this.lblSurface);
            this.Controls.Add(this.lblNbBedrooms);
            this.Controls.Add(this.lblNbRoom);
            this.Controls.Add(this.lblConstrucYrs);
            this.Controls.Add(this.lblProprety);
            this.Controls.Add(this.DGV);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEstate";
            this.Text = "FormEstate";
            this.Load += new System.EventHandler(this.FormEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label lblProprety;
        private System.Windows.Forms.Label lblConstrucYrs;
        private System.Windows.Forms.Label lblNbRoom;
        private System.Windows.Forms.Label lblNbBedrooms;
        private System.Windows.Forms.Label lblSurface;
        private System.Windows.Forms.TextBox txtBoxProprety;
        private System.Windows.Forms.TextBox txtBoxConstrucYrs;
        private System.Windows.Forms.TextBox txtBoxNbRooms;
        private System.Windows.Forms.TextBox txtBoxNbBedrooms;
        private System.Windows.Forms.TextBox txtBoxSurface;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openDataBaseToolStripMenuItem;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolStripMenuItem updatePropretyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePropretyToolStripMenuItem;
        private System.Windows.Forms.Label lblIdProprety;
        private System.Windows.Forms.ComboBox comboBoxProprety;
        private System.Windows.Forms.TextBox txtBoxIdProprety;
        private System.Windows.Forms.Button addPropretyBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button researchBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button testBtnResearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxLinkImage;
        private System.Windows.Forms.Label label1;
    }
}