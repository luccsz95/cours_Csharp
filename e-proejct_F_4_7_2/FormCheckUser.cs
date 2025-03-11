using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_proejct_F_4_7_2 {
    public partial class FormCheckUser : Form {
        public FormCheckUser() {
            InitializeComponent();
        }

        private void CheckUserBtn_Click(object sender, EventArgs e) {
            //Utilisera la méthode loadUser, permettant l'affichage des utilisateurs.
            //La fonction se trouve dans le fichier AllMethodes
            dataGridView1.DataSource = AllMethodes.loadUser();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to leave ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //Condition pour permettre la fermeture du formulaire
            if (result == DialogResult.Yes)
            {
                //ferme le formulaire
                this.Close();
            }
        }
    }
}
