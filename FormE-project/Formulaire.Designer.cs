namespace FormE_project
{
    partial class Formulaire
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearchFile = new Button();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            labelNom = new Label();
            labelCouleur = new Label();
            txtBoxNom = new TextBox();
            comboBox1 = new ComboBox();
            radioButton2 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDirectStop = new Button();
            panel5 = new Panel();
            btnEmpty = new Button();
            btnFill = new Button();
            panel4 = new Panel();
            txtBoxImage = new TextBox();
            btnPrint = new Button();
            labelImage = new Label();
            txtBoxEmail = new TextBox();
            txtBoxPrenom = new TextBox();
            labelEmail = new Label();
            labelPrenom = new Label();
            button5 = new Button();
            btnStop = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearchFile
            // 
            btnSearchFile.Location = new Point(181, 152);
            btnSearchFile.Margin = new Padding(3, 4, 3, 4);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(86, 31);
            btnSearchFile.TabIndex = 0;
            btnSearchFile.Text = "Parcourir";
            btnSearchFile.UseVisualStyleBackColor = true;
            btnSearchFile.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 4);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 4);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(3, 24);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(42, 20);
            labelNom.TabIndex = 3;
            labelNom.Text = "Nom";
            // 
            // labelCouleur
            // 
            labelCouleur.AutoSize = true;
            labelCouleur.Location = new Point(3, 20);
            labelCouleur.Name = "labelCouleur";
            labelCouleur.Size = new Size(60, 20);
            labelCouleur.TabIndex = 4;
            labelCouleur.Text = "Couleur";
            // 
            // txtBoxNom
            // 
            txtBoxNom.Location = new Point(59, 20);
            txtBoxNom.Margin = new Padding(3, 4, 3, 4);
            txtBoxNom.Name = "txtBoxNom";
            txtBoxNom.Size = new Size(114, 27);
            txtBoxNom.TabIndex = 5;
            txtBoxNom.TextChanged += textBox1_TextChanged;
            txtBoxNom.KeyPress += txtBoxNom_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(59, 16);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 37);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 37);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(3, 71);
            checkBox3.Margin = new Padding(3, 4, 3, 4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(766, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 104);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox3);
            panel2.Location = new Point(766, 131);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 104);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDirectStop);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(14, 16);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 435);
            panel3.TabIndex = 11;
            // 
            // btnDirectStop
            // 
            btnDirectStop.BackColor = Color.DarkRed;
            btnDirectStop.Cursor = Cursors.Hand;
            btnDirectStop.ForeColor = Color.White;
            btnDirectStop.Location = new Point(334, 400);
            btnDirectStop.Margin = new Padding(3, 4, 3, 4);
            btnDirectStop.Name = "btnDirectStop";
            btnDirectStop.Size = new Size(133, 31);
            btnDirectStop.TabIndex = 18;
            btnDirectStop.Text = "Arrêt d'urgence";
            btnDirectStop.UseVisualStyleBackColor = false;
            btnDirectStop.Click += button6_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(btnEmpty);
            panel5.Controls.Add(labelCouleur);
            panel5.Controls.Add(btnFill);
            panel5.Location = new Point(3, 292);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(281, 100);
            panel5.TabIndex = 13;
            // 
            // btnEmpty
            // 
            btnEmpty.Location = new Point(144, 59);
            btnEmpty.Margin = new Padding(3, 4, 3, 4);
            btnEmpty.Name = "btnEmpty";
            btnEmpty.Size = new Size(98, 31);
            btnEmpty.TabIndex = 16;
            btnEmpty.Text = "vider combo";
            btnEmpty.UseVisualStyleBackColor = true;
            btnEmpty.Click += button4_Click;
            // 
            // btnFill
            // 
            btnFill.Location = new Point(18, 59);
            btnFill.Margin = new Padding(3, 4, 3, 4);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(120, 31);
            btnFill.TabIndex = 15;
            btnFill.Text = "remplir combo";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtBoxImage);
            panel4.Controls.Add(btnPrint);
            panel4.Controls.Add(labelImage);
            panel4.Controls.Add(btnSearchFile);
            panel4.Controls.Add(txtBoxEmail);
            panel4.Controls.Add(txtBoxPrenom);
            panel4.Controls.Add(labelEmail);
            panel4.Controls.Add(labelPrenom);
            panel4.Controls.Add(labelNom);
            panel4.Controls.Add(txtBoxNom);
            panel4.Location = new Point(3, 4);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 280);
            panel4.TabIndex = 12;
            // 
            // txtBoxImage
            // 
            txtBoxImage.Location = new Point(59, 152);
            txtBoxImage.Margin = new Padding(3, 4, 3, 4);
            txtBoxImage.Name = "txtBoxImage";
            txtBoxImage.Size = new Size(114, 27);
            txtBoxImage.TabIndex = 11;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(3, 191);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(89, 31);
            btnPrint.TabIndex = 14;
            btnPrint.Text = "Afficher";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += button2_Click;
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Location = new Point(3, 157);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(51, 20);
            labelImage.TabIndex = 10;
            labelImage.Text = "Image";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(59, 107);
            txtBoxEmail.Margin = new Padding(3, 4, 3, 4);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(114, 27);
            txtBoxEmail.TabIndex = 9;
            // 
            // txtBoxPrenom
            // 
            txtBoxPrenom.Location = new Point(59, 64);
            txtBoxPrenom.Margin = new Padding(3, 4, 3, 4);
            txtBoxPrenom.Name = "txtBoxPrenom";
            txtBoxPrenom.Size = new Size(114, 27);
            txtBoxPrenom.TabIndex = 8;
            txtBoxPrenom.TextChanged += textBox2_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(3, 111);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(3, 68);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(60, 20);
            labelPrenom.TabIndex = 6;
            labelPrenom.Text = "Prénom";
            // 
            // button5
            // 
            button5.Location = new Point(803, 243);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(99, 31);
            button5.TabIndex = 17;
            button5.Text = "Afficher Prod";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(816, 445);
            btnStop.Margin = new Padding(3, 4, 3, 4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(86, 31);
            btnStop.TabIndex = 18;
            btnStop.Text = "Arrêter";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 489);
            Controls.Add(btnStop);
            Controls.Add(panel3);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearchFile;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private Label labelNom;
        private Label labelCouleur;
        private TextBox txtBoxNom;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPrenom;
        private Label labelEmail;
        private Label labelPrenom;
        private Button btnPrint;
        private Button btnEmpty;
        private Button btnFill;
        private Button button5;
        private Button btnDirectStop;
        private TextBox txtBoxImage;
        private Label labelImage;
        private Button btnStop;
    }
}
