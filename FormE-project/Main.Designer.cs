namespace FormE_project
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            produitToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            listeProduitToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            nouveauClientToolStripMenuItem = new ToolStripMenuItem();
            listeClientToolStripMenuItem = new ToolStripMenuItem();
            fournisseurToolStripMenuItem = new ToolStripMenuItem();
            nouveauFournisseurToolStripMenuItem = new ToolStripMenuItem();
            listeFournisseurToolStripMenuItem = new ToolStripMenuItem();
            btnStop = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { produitToolStripMenuItem, clientToolStripMenuItem, fournisseurToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(791, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // produitToolStripMenuItem
            // 
            produitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, listeProduitToolStripMenuItem });
            produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            produitToolStripMenuItem.Size = new Size(71, 24);
            produitToolStripMenuItem.Text = "Produit";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(204, 26);
            nouveauToolStripMenuItem.Text = "Nouveau produit";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // listeProduitToolStripMenuItem
            // 
            listeProduitToolStripMenuItem.Name = "listeProduitToolStripMenuItem";
            listeProduitToolStripMenuItem.Size = new Size(204, 26);
            listeProduitToolStripMenuItem.Text = "Liste produit";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauClientToolStripMenuItem, listeClientToolStripMenuItem });
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(61, 24);
            clientToolStripMenuItem.Text = "Client";
            // 
            // nouveauClientToolStripMenuItem
            // 
            nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            nouveauClientToolStripMenuItem.Size = new Size(191, 26);
            nouveauClientToolStripMenuItem.Text = "Nouveau client";
            // 
            // listeClientToolStripMenuItem
            // 
            listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            listeClientToolStripMenuItem.Size = new Size(191, 26);
            listeClientToolStripMenuItem.Text = "Liste client";
            // 
            // fournisseurToolStripMenuItem
            // 
            fournisseurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauFournisseurToolStripMenuItem, listeFournisseurToolStripMenuItem });
            fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            fournisseurToolStripMenuItem.Size = new Size(97, 24);
            fournisseurToolStripMenuItem.Text = "Fournisseur";
            // 
            // nouveauFournisseurToolStripMenuItem
            // 
            nouveauFournisseurToolStripMenuItem.Name = "nouveauFournisseurToolStripMenuItem";
            nouveauFournisseurToolStripMenuItem.Size = new Size(229, 26);
            nouveauFournisseurToolStripMenuItem.Text = "Nouveau Fournisseur";
            // 
            // listeFournisseurToolStripMenuItem
            // 
            listeFournisseurToolStripMenuItem.Name = "listeFournisseurToolStripMenuItem";
            listeFournisseurToolStripMenuItem.Size = new Size(229, 26);
            listeFournisseurToolStripMenuItem.Text = "Liste fournisseur";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(693, 34);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(86, 31);
            btnStop.TabIndex = 3;
            btnStop.Text = "Arrêter";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 443);
            Controls.Add(btnStop);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem produitToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem listeProduitToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem nouveauClientToolStripMenuItem;
        private ToolStripMenuItem fournisseurToolStripMenuItem;
        private ToolStripMenuItem nouveauFournisseurToolStripMenuItem;
        private ToolStripMenuItem listeFournisseurToolStripMenuItem;
        private ToolStripMenuItem listeClientToolStripMenuItem;
        private Button btnStop;
    }
}