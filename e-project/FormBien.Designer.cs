namespace e_project
{
    partial class FormBien
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
            components = new System.ComponentModel.Container();
            dgv = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            locationPriceToolStripMenuItem = new ToolStripMenuItem();
            housePriceToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            exitBtn = new Button();
            txtBProprety = new TextBox();
            txtBYearsConstr = new TextBox();
            txtBNbRoom = new TextBox();
            txtBNbBedroom = new TextBox();
            txtBSurface = new TextBox();
            stopBtn = new Button();
            lblProprety = new Label();
            lblYrsConstruction = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            insertInfoBtn = new Button();
            openDataBaseToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ContextMenuStrip = contextMenuStrip1;
            dgv.Location = new Point(10, 9);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(876, 171);
            dgv.TabIndex = 0;
            dgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { openDataBaseToolStripMenuItem, addToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(230, 92);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locationPriceToolStripMenuItem, housePriceToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(229, 22);
            addToolStripMenuItem.Text = "Add ";
            // 
            // locationPriceToolStripMenuItem
            // 
            locationPriceToolStripMenuItem.Name = "locationPriceToolStripMenuItem";
            locationPriceToolStripMenuItem.Size = new Size(180, 22);
            locationPriceToolStripMenuItem.Text = "Location Price";
            locationPriceToolStripMenuItem.Click += locationPriceToolStripMenuItem_Click;
            // 
            // housePriceToolStripMenuItem
            // 
            housePriceToolStripMenuItem.Name = "housePriceToolStripMenuItem";
            housePriceToolStripMenuItem.Size = new Size(180, 22);
            housePriceToolStripMenuItem.Text = "House Price";
            housePriceToolStripMenuItem.Click += housePriceToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(229, 22);
            deleteToolStripMenuItem.Text = "Delete (not implemented yet)";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(10, 371);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(82, 22);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // txtBProprety
            // 
            txtBProprety.Location = new Point(800, 184);
            txtBProprety.Margin = new Padding(3, 2, 3, 2);
            txtBProprety.Name = "txtBProprety";
            txtBProprety.Size = new Size(87, 23);
            txtBProprety.TabIndex = 2;
            // 
            // txtBYearsConstr
            // 
            txtBYearsConstr.Location = new Point(800, 209);
            txtBYearsConstr.Margin = new Padding(3, 2, 3, 2);
            txtBYearsConstr.Name = "txtBYearsConstr";
            txtBYearsConstr.Size = new Size(87, 23);
            txtBYearsConstr.TabIndex = 3;
            txtBYearsConstr.KeyPress += txtBYearsConstr_KeyPress;
            // 
            // txtBNbRoom
            // 
            txtBNbRoom.Location = new Point(800, 234);
            txtBNbRoom.Margin = new Padding(3, 2, 3, 2);
            txtBNbRoom.Name = "txtBNbRoom";
            txtBNbRoom.Size = new Size(87, 23);
            txtBNbRoom.TabIndex = 4;
            // 
            // txtBNbBedroom
            // 
            txtBNbBedroom.Location = new Point(800, 259);
            txtBNbBedroom.Margin = new Padding(3, 2, 3, 2);
            txtBNbBedroom.Name = "txtBNbBedroom";
            txtBNbBedroom.Size = new Size(87, 23);
            txtBNbBedroom.TabIndex = 5;
            // 
            // txtBSurface
            // 
            txtBSurface.Location = new Point(800, 284);
            txtBSurface.Margin = new Padding(3, 2, 3, 2);
            txtBSurface.Name = "txtBSurface";
            txtBSurface.Size = new Size(87, 23);
            txtBSurface.TabIndex = 6;
            txtBSurface.TextChanged += txtBSurface_TextChanged;
            txtBSurface.KeyPress += txtBSurface_KeyPress;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(10, 345);
            stopBtn.Margin = new Padding(3, 2, 3, 2);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(82, 22);
            stopBtn.TabIndex = 7;
            stopBtn.Text = "STOP";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // lblProprety
            // 
            lblProprety.AutoSize = true;
            lblProprety.Location = new Point(661, 190);
            lblProprety.Name = "lblProprety";
            lblProprety.Size = new Size(52, 15);
            lblProprety.TabIndex = 8;
            lblProprety.Text = "Proprety";
            // 
            // lblYrsConstruction
            // 
            lblYrsConstruction.AutoSize = true;
            lblYrsConstruction.Location = new Point(661, 214);
            lblYrsConstruction.Name = "lblYrsConstruction";
            lblYrsConstruction.Size = new Size(106, 15);
            lblYrsConstruction.TabIndex = 9;
            lblYrsConstruction.Text = "Construction Years";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(661, 239);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 10;
            label3.Text = "Number of rooms";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(661, 264);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 11;
            label4.Text = "Number of Bedrooms";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 289);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "Surface";
            // 
            // insertInfoBtn
            // 
            insertInfoBtn.Location = new Point(800, 329);
            insertInfoBtn.Margin = new Padding(3, 2, 3, 2);
            insertInfoBtn.Name = "insertInfoBtn";
            insertInfoBtn.Size = new Size(82, 22);
            insertInfoBtn.TabIndex = 13;
            insertInfoBtn.Text = "Inserer";
            insertInfoBtn.UseVisualStyleBackColor = true;
            insertInfoBtn.Click += insertInfoBtn_Click;
            // 
            // openDataBaseToolStripMenuItem
            // 
            openDataBaseToolStripMenuItem.Name = "openDataBaseToolStripMenuItem";
            openDataBaseToolStripMenuItem.Size = new Size(229, 22);
            openDataBaseToolStripMenuItem.Text = "Open DataBase";
            openDataBaseToolStripMenuItem.Click += openDataBaseToolStripMenuItem_Click;
            // 
            // FormBien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 402);
            Controls.Add(insertInfoBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblYrsConstruction);
            Controls.Add(lblProprety);
            Controls.Add(stopBtn);
            Controls.Add(txtBSurface);
            Controls.Add(txtBNbBedroom);
            Controls.Add(txtBNbRoom);
            Controls.Add(txtBYearsConstr);
            Controls.Add(txtBProprety);
            Controls.Add(exitBtn);
            Controls.Add(dgv);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBien";
            Text = "FormBien";
            Load += FormBien_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Button exitBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem locationPriceToolStripMenuItem;
        private ToolStripMenuItem housePriceToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private TextBox txtBProprety;
        private TextBox txtBYearsConstr;
        private TextBox txtBNbRoom;
        private TextBox txtBNbBedroom;
        private TextBox txtBSurface;
        private Button stopBtn;
        private Label lblProprety;
        private Label lblYrsConstruction;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button insertInfoBtn;
        private ToolStripMenuItem openDataBaseToolStripMenuItem;
    }
}