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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaire f1 = new Formulaire();
            f1.MdiParent = this; //le this représente f1, donc le form1 va se retrouver dans MdiParent (le gris). Main est le parent et f1 le child
            f1.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
