namespace FormE_project
{
    partial class VirguleOuNon
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            resetTxt = new Button();
            button1 = new Button();
            stopBtn = new Button();
            directStop = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(274, 200);
            dataGridView1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1214, 719);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 16;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 79);
            label2.Name = "label2";
            label2.Size = new Size(706, 20);
            label2.TabIndex = 17;
            label2.Text = "On ne peut pas mettre de lettre et quand on entre une quantité sans virgule ou point ça affiche une erreur";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 166);
            label3.Name = "label3";
            label3.Size = new Size(765, 20);
            label3.TabIndex = 18;
            label3.Text = "On ne peut pas mettre de lettre et quand on entre une quantité avec virgule et point, ça fonctionne et pas d'erreur ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // resetTxt
            // 
            resetTxt.Location = new Point(14, 223);
            resetTxt.Name = "resetTxt";
            resetTxt.Size = new Size(94, 29);
            resetTxt.TabIndex = 20;
            resetTxt.Text = "reset";
            resetTxt.UseVisualStyleBackColor = true;
            resetTxt.Click += resetTxt_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 5);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(6, 641);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(94, 29);
            stopBtn.TabIndex = 22;
            stopBtn.Text = "Arrêter";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // directStop
            // 
            directStop.BackColor = Color.DarkRed;
            directStop.ForeColor = Color.White;
            directStop.Location = new Point(6, 676);
            directStop.Name = "directStop";
            directStop.Size = new Size(94, 29);
            directStop.TabIndex = 23;
            directStop.Text = "STOP";
            directStop.UseVisualStyleBackColor = false;
            directStop.Click += directStop_Click;
            // 
            // VirguleOuNon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 717);
            Controls.Add(directStop);
            Controls.Add(stopBtn);
            Controls.Add(button1);
            Controls.Add(resetTxt);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VirguleOuNon";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button resetTxt;
        private Button button1;
        private Button stopBtn;
        private Button directStop;
    }
}