namespace FormE_project
{
    partial class datagrid
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
            DGV = new DataGridView();
            StopBtn = new Button();
            btnSTOP = new Button();
            disignationTxtBox = new TextBox();
            qteTxtBox = new TextBox();
            buyTxtBox = new TextBox();
            remiseTxtBox = new TextBox();
            sellTxtBox = new TextBox();
            designationLabel = new Label();
            qteLabel = new Label();
            priceBuyLabel = new Label();
            priceSellLabel = new Label();
            remiseLabel = new Label();
            printFormBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            afficherToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.BackgroundColor = Color.Black;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.ContextMenuStrip = contextMenuStrip1;
            DGV.Location = new Point(292, 37);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 51;
            DGV.RowTemplate.Height = 29;
            DGV.Size = new Size(807, 316);
            DGV.TabIndex = 0;
            DGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.Lime;
            StopBtn.Location = new Point(12, 422);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(98, 35);
            StopBtn.TabIndex = 2;
            StopBtn.Text = "Arrêt";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // btnSTOP
            // 
            btnSTOP.BackColor = Color.DarkRed;
            btnSTOP.ForeColor = Color.White;
            btnSTOP.Location = new Point(12, 463);
            btnSTOP.Name = "btnSTOP";
            btnSTOP.Size = new Size(98, 35);
            btnSTOP.TabIndex = 3;
            btnSTOP.Text = "STOP";
            btnSTOP.UseVisualStyleBackColor = false;
            btnSTOP.Click += btnSTOP_Click;
            // 
            // disignationTxtBox
            // 
            disignationTxtBox.BackColor = Color.Magenta;
            disignationTxtBox.ForeColor = Color.White;
            disignationTxtBox.Location = new Point(128, 37);
            disignationTxtBox.Name = "disignationTxtBox";
            disignationTxtBox.Size = new Size(125, 27);
            disignationTxtBox.TabIndex = 4;
            // 
            // qteTxtBox
            // 
            qteTxtBox.BackColor = Color.Magenta;
            qteTxtBox.ForeColor = Color.White;
            qteTxtBox.Location = new Point(128, 70);
            qteTxtBox.Name = "qteTxtBox";
            qteTxtBox.Size = new Size(125, 27);
            qteTxtBox.TabIndex = 5;
            // 
            // buyTxtBox
            // 
            buyTxtBox.BackColor = Color.Magenta;
            buyTxtBox.ForeColor = Color.White;
            buyTxtBox.Location = new Point(128, 103);
            buyTxtBox.Name = "buyTxtBox";
            buyTxtBox.Size = new Size(125, 27);
            buyTxtBox.TabIndex = 6;
            // 
            // remiseTxtBox
            // 
            remiseTxtBox.BackColor = Color.Magenta;
            remiseTxtBox.ForeColor = Color.White;
            remiseTxtBox.Location = new Point(128, 169);
            remiseTxtBox.Name = "remiseTxtBox";
            remiseTxtBox.Size = new Size(125, 27);
            remiseTxtBox.TabIndex = 7;
            // 
            // sellTxtBox
            // 
            sellTxtBox.BackColor = Color.Magenta;
            sellTxtBox.ForeColor = Color.White;
            sellTxtBox.Location = new Point(128, 136);
            sellTxtBox.Name = "sellTxtBox";
            sellTxtBox.Size = new Size(125, 27);
            sellTxtBox.TabIndex = 8;
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new Point(33, 37);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new Size(89, 20);
            designationLabel.TabIndex = 9;
            designationLabel.Text = "Désignation";
            // 
            // qteLabel
            // 
            qteLabel.AutoSize = true;
            qteLabel.Location = new Point(56, 70);
            qteLabel.Name = "qteLabel";
            qteLabel.Size = new Size(66, 20);
            qteLabel.TabIndex = 10;
            qteLabel.Text = "Quantité";
            // 
            // priceBuyLabel
            // 
            priceBuyLabel.AutoSize = true;
            priceBuyLabel.Location = new Point(37, 103);
            priceBuyLabel.Name = "priceBuyLabel";
            priceBuyLabel.Size = new Size(85, 20);
            priceBuyLabel.TabIndex = 11;
            priceBuyLabel.Text = "Prix d'achat";
            // 
            // priceSellLabel
            // 
            priceSellLabel.AutoSize = true;
            priceSellLabel.Location = new Point(28, 136);
            priceSellLabel.Name = "priceSellLabel";
            priceSellLabel.Size = new Size(94, 20);
            priceSellLabel.TabIndex = 12;
            priceSellLabel.Text = "Prix de vente";
            // 
            // remiseLabel
            // 
            remiseLabel.AutoSize = true;
            remiseLabel.Location = new Point(65, 169);
            remiseLabel.Name = "remiseLabel";
            remiseLabel.Size = new Size(57, 20);
            remiseLabel.TabIndex = 13;
            remiseLabel.Text = "Remise";
            // 
            // printFormBtn
            // 
            printFormBtn.BackColor = Color.SkyBlue;
            printFormBtn.Location = new Point(128, 202);
            printFormBtn.Name = "printFormBtn";
            printFormBtn.Size = new Size(125, 50);
            printFormBtn.TabIndex = 14;
            printFormBtn.Text = "Afficher formulaire";
            printFormBtn.UseVisualStyleBackColor = false;
            printFormBtn.Click += printFormBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { afficherToolStripMenuItem, modifierToolStripMenuItem, supprimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 76);
            // 
            // afficherToolStripMenuItem
            // 
            afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            afficherToolStripMenuItem.Size = new Size(147, 24);
            afficherToolStripMenuItem.Text = "Afficher";
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(147, 24);
            modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(147, 24);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // datagrid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1111, 499);
            Controls.Add(printFormBtn);
            Controls.Add(remiseLabel);
            Controls.Add(priceSellLabel);
            Controls.Add(priceBuyLabel);
            Controls.Add(qteLabel);
            Controls.Add(designationLabel);
            Controls.Add(sellTxtBox);
            Controls.Add(remiseTxtBox);
            Controls.Add(buyTxtBox);
            Controls.Add(qteTxtBox);
            Controls.Add(disignationTxtBox);
            Controls.Add(btnSTOP);
            Controls.Add(StopBtn);
            Controls.Add(DGV);
            Name = "datagrid";
            Text = "datagrid";
            Load += datagrid_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private Button StopBtn;
        private Button btnSTOP;
        private TextBox disignationTxtBox;
        private TextBox qteTxtBox;
        private TextBox buyTxtBox;
        private TextBox remiseTxtBox;
        private TextBox sellTxtBox;
        private Label designationLabel;
        private Label qteLabel;
        private Label priceBuyLabel;
        private Label priceSellLabel;
        private Label remiseLabel;
        private Button printFormBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem afficherToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
    }
}