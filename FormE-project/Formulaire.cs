using Microsoft.VisualBasic;

namespace FormE_project
{
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(label1.Text + " - " + textBox1.Text);
            MessageBox.Show(label3.Text + " - " + textBox2.Text);
            MessageBox.Show(label4.Text + " - " + textBox3.Text);*/

            MessageBox.Show(txtBoxNom.Text + " " + txtBoxPrenom.Text + " " + txtBoxEmail.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("rouge");
            comboBox1.Items.Add("blue");
            comboBox1.Items.Add("vert");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pour aller chercher des fichiers
            OpenFileDialog v1 = new OpenFileDialog();
            v1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBoxNom.Text = "marque";
            txtBoxPrenom.Text = "tomates";

            Produit prod = new Produit();
            prod.idProd = 1;
            prod.Description = "toto";
            prod.Name = "Test";

            MessageBox.Show(prod.Name + " - " + prod.Description);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Close();
            }
            /*     
             *     var MessageBoxResult = MessageBox(MsgBoxStyle.YesNo, "form1")
             Dim i As MsgBoxResult = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo + vbDefaultButton2, "Form")
             If i = MsgBoxResult.Yes Then
                 Close()
             End If*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (!(e.KeyChar.Equals('.'))) && (!(e.KeyChar.Equals(','))))
            {
                e.Handled = true;
                MessageBox.Show("ce champ doit contenir des chiffres").ToString();
            }
        }

        public void getBtnStopDirect()
        {
            this.Close();
        }
    }
}
