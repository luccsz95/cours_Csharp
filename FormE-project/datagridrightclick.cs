using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormE_project
{
    public partial class datagridrightclick : Form
    {
        public datagridrightclick()
        {
            InitializeComponent();
        }

        /*btn d'arrêt d'urgence*/
        private void btnSTOP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*btn demande d'arrêt*/
        private void StopBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        /*affichage du tableau directement au lancement*/
        private void datagridrightclick_Load(object sender, EventArgs e)
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
            DGV.Columns[4].Name = "Remise";



            //ajoute 4 lignes dans le tableau à sa création

            string[] ligne = new string[] { "Product 1", "1", "1", "1", "1%" };
            DGV.Rows.Add(ligne);

            string[] ligne2 = new string[] { "Product 2", "2", "2", "2", "2%" };
            DGV.Rows.Add(ligne2);

            string[] ligne3 = new string[] { "Product 3", "3", "3", "3", "3%" };
            DGV.Rows.Add(ligne3);

            string[] ligne4 = new string[] { "Product 4", "4", "4", "4", "4%" };
            DGV.Rows.Add(ligne4);
        }

        /*btn right click pour modifier les données*/
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rowIndex, permet de sélectionner la cellulre de la ligne dans laquelle on se trouve (moi)
            //récuperer l'index de la cellule sélectionnée (prof)
            int rowIndex = DGV.CurrentCell.RowIndex;
            //rowIndex, permet de sélectionner la cellulre de la colonne dans laquelle on se trouve (moi)
            //récupère la colonne de la cellule sélectionnée (prof)
            int columnIndex = DGV.CurrentCell.ColumnIndex;

            //Va afficher dans les textBox, tout ce qu'il se trouve dans chaque cellule de la ligne grace a rowIndex
            textBox1.Text = DGV.Rows[rowIndex].Cells[0].Value.ToString();
            textBox2.Text = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            textBox3.Text = DGV.Rows[rowIndex].Cells[2].Value.ToString();
            textBox4.Text = DGV.Rows[rowIndex].Cells[3].Value.ToString();
            textBox5.Text = DGV.Rows[rowIndex].Cells[4].Value.ToString();

        }

        /*btn modifier les données*/
        private void modifyBtn_Click_1(object sender, EventArgs e)
        {
            //rowIndex, permet de sélectionner la cellulre de la ligne dans laquelle on se trouve (moi)
            //récuperer l'index de la cellule sélectionnée (prof)
            int rowIndex = DGV.CurrentCell.RowIndex;
            //rowIndex, permet de sélectionner la cellulre de la colonne dans laquelle on se trouve (moi)
            //récupère la colonne de la cellule sélectionnée (prof)
            int columnIndex = DGV.CurrentCell.ColumnIndex;

            //Va afficher dans les textBox, tout ce qu'il se trouve dans chaque cellule de la ligne grace a rowIndex
            textBox1.Text = DGV.Rows[rowIndex].Cells[0].Value.ToString();
            textBox2.Text = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            textBox3.Text = DGV.Rows[rowIndex].Cells[2].Value.ToString();
            textBox4.Text = DGV.Rows[rowIndex].Cells[3].Value.ToString();
            textBox5.Text = DGV.Rows[rowIndex].Cells[4].Value.ToString();
        }


        /*btn inserer les données des textBox vers le tableau*/
        private void button1_Click(object sender, EventArgs e)
        {

            int rowindex = DGV.CurrentCell.RowIndex;
            int columnindex = DGV.CurrentCell.ColumnIndex;


            DGV.Rows[rowindex].Cells[0].Value = textBox1.Text;
            DGV.Rows[rowindex].Cells[1].Value = textBox2.Text;
            DGV.Rows[rowindex].Cells[2].Value = textBox3.Text;
            DGV.Rows[rowindex].Cells[3].Value = textBox4.Text;
            DGV.Rows[rowindex].Cells[4].Value = textBox5.Text;
        }


        /*btn add 1 line*/
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            string[] ligne = new string[] { "Product 1", "1", "1000", "1500", "5%" };
            DGV.Rows.Add(ligne);
        }

        /*btn add 2 lines*/
        private void add2Lines_Click(object sender, EventArgs e)
        {
            string[] ligne = new string[] { "Product 1", "1", "1000", "1500", "5%" };
            DGV.Rows.Add(ligne);

            string[] ligne2 = new string[] { "Product 2", "2", "2000", "2500", "2%" };
            DGV.Rows.Add(ligne2);
        }

        /*btn add 4 lines*/
        private void add4Lines_Click(object sender, EventArgs e)
        {
            string[] ligne = new string[] { "Product 1", "1", "1", "1", "1%" };
            DGV.Rows.Add(ligne);

            string[] ligne2 = new string[] { "Product 2", "2", "2", "2", "2%" };
            DGV.Rows.Add(ligne2);

            string[] ligne3 = new string[] { "Product 3", "3", "3", "3", "3%" };
            DGV.Rows.Add(ligne3);

            string[] ligne4 = new string[] { "Product 4", "4", "4", "4", "4%" };
            DGV.Rows.Add(ligne4);
        }

        /*btn qui supp le tableau*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
        }

        /*btn qui supp les 5 textBox*/
        private void clearTxtBox_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }


        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int rowindex = DGV.CurrentCell.RowIndex;
            //permet de retirer une ligne du tableau
            DGV.Rows.RemoveAt(DGV.SelectedRows[0].Index);

        }

        private void addcmb_Click(object sender, EventArgs e)
        {
            //la ligne va créer une colone ComboBox 
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();

            //cmb = ComboBox

            //Va changer le nom d'orgine "Combosaison" en "Saison"
            cmb.HeaderText = "Saison";
            //rajoute une ComboBox du nom "Combosaison"
            cmb.Name = "Combosaison";
            //Il peut y avoir seulement 5 items pouvant apparaitrent (5 et pas 4 car on commence de 0 à 4) (moi)
            //nombre d'items pouvant apparaitre (prof)
            //Mais ne change pas visiblement
            cmb.MaxDropDownItems = 4;
            //rajoute les saisons "été", "hiver" et "4Saisin"
            cmb.Items.Add("été");
            cmb.Items.Add("Hiver");
            cmb.Items.Add("4Saisons");
            //On va rajouter une colonne, plus spécifiquement cmb.
            DGV.Columns.Add(cmb);
        }

        private void addChBox_Click(object sender, EventArgs e)
        {
            //la ligne va créer une colone CheckBox 
            DataGridViewCheckBoxColumn dgvChb = new DataGridViewCheckBoxColumn();
            //Chb = CheckBox

            //remplace le nom par défaut et affichera l'entrée
            dgvChb.HeaderText = "Neuf/Occasion";
            //rajoute un nom par défaut
            dgvChb.Name = "chbPass";
            //Style de la checkBox
            dgvChb.FlatStyle = FlatStyle.Standard;
            //rajoute 3 états différents, un neutre (par défaut), un cocher et un décocher
            dgvChb.ThreeState = true;
            //Choisi la coleur du "check"
            dgvChb.CellTemplate.Style.BackColor = System.Drawing.Color.LightBlue;
            //On va rajouter une colonne, plus spécifiquement dgvChb.
            DGV.Columns.Add(dgvChb);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
