namespace FormE_project
{
    partial class dbForm
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
            connexionBtn = new Button();
            SuspendLayout();
            // 
            // connexionBtn
            // 
            connexionBtn.Location = new Point(221, 160);
            connexionBtn.Name = "connexionBtn";
            connexionBtn.Size = new Size(94, 29);
            connexionBtn.TabIndex = 0;
            connexionBtn.Text = "connexion";
            connexionBtn.UseVisualStyleBackColor = true;
            connexionBtn.Click += button1_Click;
            // 
            // dbForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connexionBtn);
            Name = "dbForm";
            Text = "dbForm";
            ResumeLayout(false);
        }

        #endregion

        private Button connexionBtn;
    }
}