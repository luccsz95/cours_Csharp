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
    public partial class datagrid : Form
    {
        public datagrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void StopBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printFormBtn_Click(object sender, EventArgs e)
        {
            DGV.Rows[0].Cells[0].Value = disignationTxtBox.Text;
            DGV.Rows[0].Cells[1].Value = qteTxtBox.Text;
            DGV.Rows[0].Cells[2].Value = buyTxtBox.Text;
            DGV.Rows[0].Cells[3].Value = sellTxtBox.Text;
            DGV.Rows[0].Cells[4].Value = remiseTxtBox.Text;
        }

        private void datagrid_Load(object sender, EventArgs e)
        {
            //définir le nb de colone datagrid
            DGV.ColumnCount = 5;

            //Créer les colones
            DGV.Columns[0].Name = "name of product";
            DGV.Columns[0].HeaderText = "Désignation"; //va écraser le name de base, ici "name of product"
                                                       //DGV.Columns[0].Width = 20; //change la taille de la colone désigné
            DGV.Columns[1].Name = "Qte";
            DGV.Columns[2].Name = "Prix achat";
            DGV.Columns[3].Name = "Prix Vente";
            DGV.Columns[4].Name = "Remise";


        }
    }
}
