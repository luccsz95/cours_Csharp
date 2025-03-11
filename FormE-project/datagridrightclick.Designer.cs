namespace FormE_project
{
    partial class datagridrightclick
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            afficherToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            DGV = new DataGridView();
            StopBtn = new Button();
            btnSTOP = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            copierToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem = new ToolStripMenuItem();
            imprimmerToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem1 = new ToolStripMenuItem();
            ligne1ToolStripMenuItem = new ToolStripMenuItem();
            ligne2ToolStripMenuItem = new ToolStripMenuItem();
            addBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            insertBtn = new Button();
            modifyBtn = new Button();
            add2Lines = new Button();
            add4Lines = new Button();
            clearAllLines = new Button();
            clearTxtBox = new Button();
            addcmb = new Button();
            addChBox = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { afficherToolStripMenuItem, modifierToolStripMenuItem, supprimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(148, 76);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
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
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(147, 24);
            supprimerToolStripMenuItem.Text = "Supprimer";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.ContextMenuStrip = contextMenuStrip1;
            DGV.Location = new Point(11, 12);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 51;
            DGV.RowTemplate.Height = 29;
            DGV.Size = new Size(714, 273);
            DGV.TabIndex = 1;
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.Lime;
            StopBtn.Location = new Point(11, 485);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(98, 35);
            StopBtn.TabIndex = 3;
            StopBtn.Text = "Arrêt";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // btnSTOP
            // 
            btnSTOP.BackColor = Color.DarkRed;
            btnSTOP.ForeColor = Color.White;
            btnSTOP.Location = new Point(11, 525);
            btnSTOP.Name = "btnSTOP";
            btnSTOP.Size = new Size(98, 35);
            btnSTOP.TabIndex = 4;
            btnSTOP.Text = "STOP";
            btnSTOP.UseVisualStyleBackColor = false;
            btnSTOP.Click += btnSTOP_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { copierToolStripMenuItem, collerToolStripMenuItem, imprimmerToolStripMenuItem, modifierToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(153, 100);
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(152, 24);
            copierToolStripMenuItem.Text = "Copier";
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(152, 24);
            collerToolStripMenuItem.Text = "Coller";
            // 
            // imprimmerToolStripMenuItem
            // 
            imprimmerToolStripMenuItem.Name = "imprimmerToolStripMenuItem";
            imprimmerToolStripMenuItem.Size = new Size(152, 24);
            imprimmerToolStripMenuItem.Text = "Imprimmer";
            // 
            // modifierToolStripMenuItem1
            // 
            modifierToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ligne1ToolStripMenuItem, ligne2ToolStripMenuItem });
            modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            modifierToolStripMenuItem1.Size = new Size(152, 24);
            modifierToolStripMenuItem1.Text = "Modifier";
            // 
            // ligne1ToolStripMenuItem
            // 
            ligne1ToolStripMenuItem.Name = "ligne1ToolStripMenuItem";
            ligne1ToolStripMenuItem.Size = new Size(140, 26);
            ligne1ToolStripMenuItem.Text = "Ligne 1";
            // 
            // ligne2ToolStripMenuItem
            // 
            ligne2ToolStripMenuItem.Name = "ligne2ToolStripMenuItem";
            ligne2ToolStripMenuItem.Size = new Size(140, 26);
            ligne2ToolStripMenuItem.Text = "ligne 2";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(112, 451);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add 1 line";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += modifyBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(843, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(843, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(843, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(843, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(843, 144);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 13;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(843, 177);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(94, 29);
            insertBtn.TabIndex = 14;
            insertBtn.Text = "Inserer";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += button1_Click;
            // 
            // modifyBtn
            // 
            modifyBtn.Location = new Point(11, 451);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(94, 29);
            modifyBtn.TabIndex = 15;
            modifyBtn.Text = "Modifier";
            modifyBtn.UseVisualStyleBackColor = true;
            modifyBtn.Click += modifyBtn_Click_1;
            // 
            // add2Lines
            // 
            add2Lines.Location = new Point(112, 485);
            add2Lines.Name = "add2Lines";
            add2Lines.Size = new Size(94, 29);
            add2Lines.TabIndex = 16;
            add2Lines.Text = "Add 2 lines";
            add2Lines.UseVisualStyleBackColor = true;
            add2Lines.Click += add2Lines_Click;
            // 
            // add4Lines
            // 
            add4Lines.Location = new Point(112, 520);
            add4Lines.Name = "add4Lines";
            add4Lines.Size = new Size(94, 29);
            add4Lines.TabIndex = 17;
            add4Lines.Text = "Add 4 lines";
            add4Lines.UseVisualStyleBackColor = true;
            add4Lines.Click += add4Lines_Click;
            // 
            // clearAllLines
            // 
            clearAllLines.Location = new Point(213, 451);
            clearAllLines.Name = "clearAllLines";
            clearAllLines.Size = new Size(117, 29);
            clearAllLines.TabIndex = 18;
            clearAllLines.Text = "Clear all lines";
            clearAllLines.UseVisualStyleBackColor = true;
            clearAllLines.Click += button1_Click_1;
            // 
            // clearTxtBox
            // 
            clearTxtBox.Location = new Point(843, 212);
            clearTxtBox.Name = "clearTxtBox";
            clearTxtBox.Size = new Size(94, 48);
            clearTxtBox.TabIndex = 19;
            clearTxtBox.Text = "Clear TxtBox";
            clearTxtBox.UseVisualStyleBackColor = true;
            clearTxtBox.Click += clearTxtBox_Click;
            // 
            // addcmb
            // 
            addcmb.Location = new Point(843, 267);
            addcmb.Name = "addcmb";
            addcmb.Size = new Size(94, 56);
            addcmb.TabIndex = 20;
            addcmb.Text = "ajouter combobox";
            addcmb.UseVisualStyleBackColor = true;
            addcmb.Click += addcmb_Click;
            // 
            // addChBox
            // 
            addChBox.Location = new Point(843, 328);
            addChBox.Name = "addChBox";
            addChBox.Size = new Size(94, 56);
            addChBox.TabIndex = 21;
            addChBox.Text = "ajout checkbox";
            addChBox.UseVisualStyleBackColor = true;
            addChBox.Click += addChBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(731, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 22;
            label1.Text = "Désignation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(731, 45);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 23;
            label2.Text = "Quantité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(731, 77);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 24;
            label3.Text = "Prix d'achat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(731, 111);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 25;
            label4.Text = "Prix de vente ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(731, 144);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 26;
            label5.Text = "Remise";
            // 
            // datagridrightclick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 573);
            ContextMenuStrip = contextMenuStrip2;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addChBox);
            Controls.Add(addcmb);
            Controls.Add(clearTxtBox);
            Controls.Add(clearAllLines);
            Controls.Add(add4Lines);
            Controls.Add(add2Lines);
            Controls.Add(modifyBtn);
            Controls.Add(insertBtn);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(addBtn);
            Controls.Add(btnSTOP);
            Controls.Add(StopBtn);
            Controls.Add(DGV);
            Name = "datagridrightclick";
            Text = "datagridrightclick";
            Load += datagridrightclick_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private DataGridView DGV;
        private Button StopBtn;
        private Button btnSTOP;
        private ToolStripMenuItem afficherToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem;
        private ToolStripMenuItem imprimmerToolStripMenuItem;
        private Button addBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button insertBtn;
        private Button modifyBtn;
        private Button add2Lines;
        private Button add4Lines;
        private Button clearAllLines;
        private Button clearTxtBox;
        private Button addcmb;
        private Button addChBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem modifierToolStripMenuItem1;
        private ToolStripMenuItem ligne1ToolStripMenuItem;
        private ToolStripMenuItem ligne2ToolStripMenuItem;
    }
}