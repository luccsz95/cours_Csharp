using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormE_project
{
    public partial class VirguleOuNon : Form
    {
        public VirguleOuNon()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permet de vérifié s'il n'y a que des chiffres, et ne prends pas en compte les virgules et les points 
            //On ne peut pas mettre de lettre et quand on entre une quantité avec virgule ou point ça affiche une erreur
            if (!char.IsControl(e.KeyChar) && (!char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ ne doit contenir que des chiffres sans point ou virgule!").ToString(); //<- le message est déjà en ToString, donc pas nécessaire (je le laisse pour l'expliquation)
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permet de vérifié s'il n'y a que des chiffres, et prends en compte les virgules et les points
            //On ne peut pas mettre de lettre et quand on entre une quantité avec virgule et point, ça fonctionne et pas d'erreur 
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (!(e.KeyChar.Equals('.'))) && (!(e.KeyChar.Equals(','))))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ ne doit contenir que des chiffres"); //peut mettre des points d'arrêt pour voir ce qu'il se passe, on peut aussi faire ça avec le même MessageBox
            }
        }

        private void resetTxt_Click(object sender, EventArgs e)
        {
            //supprime ce qu'il y a dans les textBox
            //ClearAllText(this); //fonctionne pas et à voir pourquoi
            textBox1.Clear();
            textBox2.Clear();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void directStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
