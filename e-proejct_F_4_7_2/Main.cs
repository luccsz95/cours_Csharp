using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_proejct_F_4_7_2
{
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            //Créer une instance du formulaire gérant les proprieters  (batiments)
            FormAnimals FormAnimals = new FormAnimals();
            //Va afficher le FormEstate dans le cadrant du Main
            FormAnimals.MdiParent = this;
            //Afficher le formulaire
            FormAnimals.Show();

            
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e) {
            //Créer une instance du formulaire 
            FormCheckUser formChekUser = new FormCheckUser();
            //Afficher le formulaire
            formChekUser.Show();
        }

        private void updateDataBaseToolStripMenuItem_Click(object sender, EventArgs e) {
            //Créer une instance du formulaire permettant la mise à jour d'un utilisateur
            FormUpdateUser formUpdateUser = new FormUpdateUser();
            //Va afficher le formUpdateUser dans le cadrant du Main
            formUpdateUser.MdiParent = this;
            //Afficher le formulaire
            formUpdateUser.Show();
        }
    }
}
