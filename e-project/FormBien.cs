using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace e_project
{
    public partial class FormBien : Form
    {
        public FormBien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBien_Load(object sender, EventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void locationPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn columnLocation = new DataGridViewTextBoxColumn();

            columnLocation.HeaderText = "Location price";
            columnLocation.Name = "price of location";
            dgv.Columns.Add(columnLocation);

        }

        private void housePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn columnSelling = new DataGridViewTextBoxColumn();

            columnSelling.Name = "price of the House";
            columnSelling.HeaderText = "House price";
            dgv.Columns.Add(columnSelling);

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertInfoBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv.CurrentCell.RowIndex;
            int columnIndex = dgv.CurrentCell.RowIndex;

            dgv.Rows[rowIndex].Cells[0].Value = txtBProprety.Text;
            dgv.Rows[rowIndex].Cells[1].Value = txtBYearsConstr.Text;
            dgv.Rows[rowIndex].Cells[2].Value = txtBNbRoom.Text;
            dgv.Rows[rowIndex].Cells[3].Value = txtBNbBedroom.Text;
            dgv.Rows[rowIndex].Cells[4].Value = txtBSurface.Text;
        }

        private void txtBSurface_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBSurface_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (!(e.KeyChar.Equals('.'))) && (!(e.KeyChar.Equals(','))))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ ne doit contenir que des chiffres"); //peut mettre des points d'arrêt pour voir ce qu'il se passe, on peut aussi faire ça avec le même MessageBox
            }
        }

        private void txtBYearsConstr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ ne doit contenir que des chiffres sans point ou virgule!").ToString(); //<- le message est déjà en ToString, donc pas nécessaire (je le laisse pour l'expliquation)
            }
        }

        private void openDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*//permet de séléctionner toute la ligne 
             dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //créer un objet de connexion
            SqlConnection conn = new SqlConnection(str);

            //structure de donnée qui permet de recuperer toutes les données dans la table client
            DataSet ds = new DataSet();

            //créer une requete SQL qui récupère tout les éléments de la table client
            string sql = "select * from client";

            //créer un objet permettant d'acceder à la base de donnée
            //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            //va permettre de remplir le dateset avec la table clinex 
            adapter.Fill(ds, "Client");

            //va afficher les données qui se trouve dans le dataset 
            dgv.DataSource = ds.Tables["Client"].DefaultView;*/
        }
    }
}
