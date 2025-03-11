namespace e_proejct_F_4_7_2
{
    partial class FormAnimals
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
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbNameAnimals = new System.Windows.Forms.TextBox();
            this.tbTypeAnimals = new System.Windows.Forms.TextBox();
            this.tbWeightAnimals = new System.Windows.Forms.TextBox();
            this.tbColorAnimals = new System.Windows.Forms.TextBox();
            this.tbPriceAnimals = new System.Windows.Forms.TextBox();
            this.tbImageAnimals = new System.Windows.Forms.TextBox();
            this.lbNameAnimals = new System.Windows.Forms.Label();
            this.lbTypeAnimals = new System.Windows.Forms.Label();
            this.lbWeightAnimals = new System.Windows.Forms.Label();
            this.lbColorAnimals = new System.Windows.Forms.Label();
            this.lbPriceAnimals = new System.Windows.Forms.Label();
            this.lbImageAnimals = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.deleteAnimal = new System.Windows.Forms.Button();
            this.updateAnimal = new System.Windows.Forms.Button();
            this.addAnimal = new System.Windows.Forms.Button();
            this.btnClearTb = new System.Windows.Forms.Button();
            this.modifyAnAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV.Location = new System.Drawing.Point(46, 1);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(971, 282);
            this.DGV.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.modifyAnAnimalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 52);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // tbNameAnimals
            // 
            this.tbNameAnimals.Location = new System.Drawing.Point(546, 357);
            this.tbNameAnimals.Name = "tbNameAnimals";
            this.tbNameAnimals.Size = new System.Drawing.Size(100, 22);
            this.tbNameAnimals.TabIndex = 1;
            // 
            // tbTypeAnimals
            // 
            this.tbTypeAnimals.Location = new System.Drawing.Point(546, 385);
            this.tbTypeAnimals.Name = "tbTypeAnimals";
            this.tbTypeAnimals.Size = new System.Drawing.Size(100, 22);
            this.tbTypeAnimals.TabIndex = 2;
            // 
            // tbWeightAnimals
            // 
            this.tbWeightAnimals.Location = new System.Drawing.Point(546, 413);
            this.tbWeightAnimals.Name = "tbWeightAnimals";
            this.tbWeightAnimals.Size = new System.Drawing.Size(100, 22);
            this.tbWeightAnimals.TabIndex = 3;
            // 
            // tbColorAnimals
            // 
            this.tbColorAnimals.Location = new System.Drawing.Point(546, 441);
            this.tbColorAnimals.Name = "tbColorAnimals";
            this.tbColorAnimals.Size = new System.Drawing.Size(100, 22);
            this.tbColorAnimals.TabIndex = 4;
            // 
            // tbPriceAnimals
            // 
            this.tbPriceAnimals.Location = new System.Drawing.Point(546, 469);
            this.tbPriceAnimals.Name = "tbPriceAnimals";
            this.tbPriceAnimals.Size = new System.Drawing.Size(100, 22);
            this.tbPriceAnimals.TabIndex = 5;
            // 
            // tbImageAnimals
            // 
            this.tbImageAnimals.Location = new System.Drawing.Point(546, 497);
            this.tbImageAnimals.Name = "tbImageAnimals";
            this.tbImageAnimals.Size = new System.Drawing.Size(100, 22);
            this.tbImageAnimals.TabIndex = 6;
            // 
            // lbNameAnimals
            // 
            this.lbNameAnimals.AutoSize = true;
            this.lbNameAnimals.Location = new System.Drawing.Point(416, 363);
            this.lbNameAnimals.Name = "lbNameAnimals";
            this.lbNameAnimals.Size = new System.Drawing.Size(95, 16);
            this.lbNameAnimals.TabIndex = 7;
            this.lbNameAnimals.Text = "Name Animals";
            // 
            // lbTypeAnimals
            // 
            this.lbTypeAnimals.AutoSize = true;
            this.lbTypeAnimals.Location = new System.Drawing.Point(416, 391);
            this.lbTypeAnimals.Name = "lbTypeAnimals";
            this.lbTypeAnimals.Size = new System.Drawing.Size(90, 16);
            this.lbTypeAnimals.TabIndex = 8;
            this.lbTypeAnimals.Text = "Type Animals";
            // 
            // lbWeightAnimals
            // 
            this.lbWeightAnimals.AutoSize = true;
            this.lbWeightAnimals.Location = new System.Drawing.Point(416, 419);
            this.lbWeightAnimals.Name = "lbWeightAnimals";
            this.lbWeightAnimals.Size = new System.Drawing.Size(100, 16);
            this.lbWeightAnimals.TabIndex = 9;
            this.lbWeightAnimals.Text = "Weight Animals";
            // 
            // lbColorAnimals
            // 
            this.lbColorAnimals.AutoSize = true;
            this.lbColorAnimals.Location = new System.Drawing.Point(416, 447);
            this.lbColorAnimals.Name = "lbColorAnimals";
            this.lbColorAnimals.Size = new System.Drawing.Size(90, 16);
            this.lbColorAnimals.TabIndex = 10;
            this.lbColorAnimals.Text = "Color Animals";
            // 
            // lbPriceAnimals
            // 
            this.lbPriceAnimals.AutoSize = true;
            this.lbPriceAnimals.Location = new System.Drawing.Point(416, 475);
            this.lbPriceAnimals.Name = "lbPriceAnimals";
            this.lbPriceAnimals.Size = new System.Drawing.Size(89, 16);
            this.lbPriceAnimals.TabIndex = 11;
            this.lbPriceAnimals.Text = "Price Animals";
            // 
            // lbImageAnimals
            // 
            this.lbImageAnimals.AutoSize = true;
            this.lbImageAnimals.Location = new System.Drawing.Point(416, 503);
            this.lbImageAnimals.Name = "lbImageAnimals";
            this.lbImageAnimals.Size = new System.Drawing.Size(123, 16);
            this.lbImageAnimals.TabIndex = 12;
            this.lbImageAnimals.Text = "Link Image Animals";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(2, 503);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 26);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // deleteAnimal
            // 
            this.deleteAnimal.BackColor = System.Drawing.Color.Red;
            this.deleteAnimal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAnimal.Location = new System.Drawing.Point(203, 289);
            this.deleteAnimal.Name = "deleteAnimal";
            this.deleteAnimal.Size = new System.Drawing.Size(134, 28);
            this.deleteAnimal.TabIndex = 14;
            this.deleteAnimal.Text = "Delete an animal";
            this.deleteAnimal.UseVisualStyleBackColor = false;
            this.deleteAnimal.Click += new System.EventHandler(this.deleteAnimal_Click);
            // 
            // updateAnimal
            // 
            this.updateAnimal.Location = new System.Drawing.Point(463, 289);
            this.updateAnimal.Name = "updateAnimal";
            this.updateAnimal.Size = new System.Drawing.Size(134, 28);
            this.updateAnimal.TabIndex = 15;
            this.updateAnimal.Text = "Update an animal";
            this.updateAnimal.UseVisualStyleBackColor = true;
            this.updateAnimal.Click += new System.EventHandler(this.updateAnimal_Click);
            // 
            // addAnimal
            // 
            this.addAnimal.BackColor = System.Drawing.Color.LimeGreen;
            this.addAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addAnimal.Location = new System.Drawing.Point(720, 289);
            this.addAnimal.Name = "addAnimal";
            this.addAnimal.Size = new System.Drawing.Size(134, 27);
            this.addAnimal.TabIndex = 16;
            this.addAnimal.Text = "Add Animal";
            this.addAnimal.UseVisualStyleBackColor = false;
            this.addAnimal.Click += new System.EventHandler(this.addAnimal_Click);
            // 
            // btnClearTb
            // 
            this.btnClearTb.Location = new System.Drawing.Point(478, 323);
            this.btnClearTb.Name = "btnClearTb";
            this.btnClearTb.Size = new System.Drawing.Size(104, 28);
            this.btnClearTb.TabIndex = 17;
            this.btnClearTb.Text = "Clear TextBox";
            this.btnClearTb.UseVisualStyleBackColor = true;
            this.btnClearTb.Click += new System.EventHandler(this.btnClearTb_Click);
            // 
            // modifyAnAnimalToolStripMenuItem
            // 
            this.modifyAnAnimalToolStripMenuItem.Name = "modifyAnAnimalToolStripMenuItem";
            this.modifyAnAnimalToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modifyAnAnimalToolStripMenuItem.Text = "Modify an Animal";
            this.modifyAnAnimalToolStripMenuItem.Click += new System.EventHandler(this.modifyAnAnimalToolStripMenuItem_Click);
            // 
            // FormAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 537);
            this.Controls.Add(this.btnClearTb);
            this.Controls.Add(this.addAnimal);
            this.Controls.Add(this.updateAnimal);
            this.Controls.Add(this.deleteAnimal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbImageAnimals);
            this.Controls.Add(this.lbPriceAnimals);
            this.Controls.Add(this.lbColorAnimals);
            this.Controls.Add(this.lbWeightAnimals);
            this.Controls.Add(this.lbTypeAnimals);
            this.Controls.Add(this.lbNameAnimals);
            this.Controls.Add(this.tbImageAnimals);
            this.Controls.Add(this.tbPriceAnimals);
            this.Controls.Add(this.tbColorAnimals);
            this.Controls.Add(this.tbWeightAnimals);
            this.Controls.Add(this.tbTypeAnimals);
            this.Controls.Add(this.tbNameAnimals);
            this.Controls.Add(this.DGV);
            this.Name = "FormAnimals";
            this.Text = "FormAnimals";
            this.Load += new System.EventHandler(this.FormAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox tbNameAnimals;
        private System.Windows.Forms.TextBox tbTypeAnimals;
        private System.Windows.Forms.TextBox tbWeightAnimals;
        private System.Windows.Forms.TextBox tbColorAnimals;
        private System.Windows.Forms.TextBox tbPriceAnimals;
        private System.Windows.Forms.TextBox tbImageAnimals;
        private System.Windows.Forms.Label lbNameAnimals;
        private System.Windows.Forms.Label lbTypeAnimals;
        private System.Windows.Forms.Label lbWeightAnimals;
        private System.Windows.Forms.Label lbColorAnimals;
        private System.Windows.Forms.Label lbPriceAnimals;
        private System.Windows.Forms.Label lbImageAnimals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button deleteAnimal;
        private System.Windows.Forms.Button updateAnimal;
        private System.Windows.Forms.Button addAnimal;
        private System.Windows.Forms.Button btnClearTb;
        private System.Windows.Forms.ToolStripMenuItem modifyAnAnimalToolStripMenuItem;
    }
}