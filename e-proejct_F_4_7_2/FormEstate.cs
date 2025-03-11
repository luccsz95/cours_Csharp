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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mysqlx.Crud;

namespace e_proejct_F_4_7_2 {
    public partial class FormEstate : Form {
        //private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\Desktop\\BTS\\Informatique\\newInfo\\projet\\cours_csharp\\e-proejct_F_4_7_2\\DB\\DBProject.mdf;Integrated Security=True";
        //string mySqlConnection = "server=127.0.0.1;uid=userdb; pwd=265656;database=e_commerce_project";
        string mySqlConnection = "server=127.0.0.1;uid=root;database=e_commerce_project";

        public FormEstate() {
            InitializeComponent();

        }
        //déclaration des méthodes

        public  void researchAll()
        {
            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //structure de donnée qui permet de recuperer toutes les données dans la table client
            DataSet ds = new DataSet();

            //créer une requete SQL qui récupère tout les éléments de la table client
            string sql = "select * from animals";

            //créer un objet permettant d'acceder à la base de donnée
            //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            //va permettre de remplir le dateset avec la table animals 
            adapter.Fill(ds, "animals");

            //va afficher les données qui se trouve dans le dataset 
            DGV.DataSource = ds.Tables["animals"].DefaultView;

        }

        private void exitBtn_Click(object sender, EventArgs e) {
            //Stockage de l'affichage de demande de fermeture du formulaire
            DialogResult result = MessageBox.Show("Are you sure you want to leave ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //Condition pour permettre la fermeture du formulaire
            if (result == DialogResult.Yes) {
                //ferme le formulaire
                this.Close();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            //Ferme le formulaire
            this.Close();
        }

        private void openDataBaseToolStripMenuItem_Click(object sender, EventArgs e) {
            //avec SQL Serveur
            /*
            //permet de séléctionner toute la ligne
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //créer un objet de connexion
            SqlConnection conn = new SqlConnection(str);

            //structure de donnée qui permet de recuperer toutes les données dans la table client
            DataSet ds = new DataSet();

            //créer une requete SQL qui récupère tout les éléments de la table client
            string sql = "select * from proprety";

            //créer un objet permettant d'acceder à la base de donnée
            //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            //va permettre de remplir le dateset avec la table clinex 
            adapter.Fill(ds, "Proprety");

            //va afficher les données qui se trouve dans le dataset 
            DGV.DataSource = ds.Tables["Proprety"].DefaultView;*/

            
            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //structure de donnée qui permet de recuperer toutes les données dans la table client
            DataSet ds = new DataSet();

            //créer une requete SQL qui récupère tout les éléments de la table client
            string sql = "select * from animals";

            //créer un objet permettant d'acceder à la base de donnée
            //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            //va permettre de remplir le dateset avec la table clinex 
            adapter.Fill(ds, "animals");

            //va afficher les données qui se trouve dans le dataset 
            DGV.DataSource = ds.Tables["animals"].DefaultView;
            DGV.Columns["idAnimals"].Visible = false;
        }

        private void updatePropretyToolStripMenuItem_Click(object sender, EventArgs e) {
            //rowIndex, permet de sélectionner la cellule de la ligne dans laquelle on se trouve (moi)
            int rowIndex = DGV.CurrentCell.RowIndex;

            //rowIndex, permet de sélectionner la cellure de la colonne dans laquelle on se trouve (moi)
            int columnIndex = DGV.CurrentCell.ColumnIndex;

            //Va afficher dans les textBox, tout ce qu'il se trouve dans chaque cellule de la ligne grace a rowIndex
            comboBoxProprety.Text = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxConstrucYrs.Text = DGV.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxNbRooms.Text = DGV.Rows[rowIndex].Cells[3].Value.ToString();
            txtBoxNbBedrooms.Text = DGV.Rows[rowIndex].Cells[4].Value.ToString();
            txtBoxSurface.Text = DGV.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void deletePropretyToolStripMenuItem_Click(object sender, EventArgs e) {
            // Obtient l'ID de la ligne sélectionnée dans le DataGridView
            int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["idAnimals"].Value);

            // Crée un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            // Requête SQL de suppression de la ligne sélectionnée idAnimals c'est la colonne dans la DB et le @idAnimals peut prendre le nom voulu
            string sql = "delete from animals where idAnimals = @idAnimals";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute le paramètre à la commande
            cmd.Parameters.AddWithValue("@idAnimals", id);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();
        }

        private void addPropretyToolStripMenuItem_Click(object sender, EventArgs e) {
            // Convertit le contenu de txtBoxIdProprety en entier
            //int idProprety = Int32.Parse(txtBoxIdProprety.Text);

            // Récupère le contenu de txtBoxProprety dans une variable proprety
            string nameAnimals = comboBoxProprety.Text;

            // Récupère le contenu de txtBoxConstrucYrs dans une variable construcYrs
            int typeAnimals = Int32.Parse(txtBoxConstrucYrs.Text);

            // Récupère le contenu de txtBoxNbRoom dans une variable nbRoom
            int weightAnimals = Int32.Parse(txtBoxNbRooms.Text);

            // Récupère le contenu de txtBoxNbBedRooms dans une variable nbBedRoom
            int colorAnimals = Int32.Parse(txtBoxNbBedrooms.Text);

            int priceAnimals = Int32.Parse(txtBoxSurface.Text);

            int imageAnimals = Int32.Parse(txtBoxLinkImage.Text);

            //Créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);


            //requête SQL
            string sql = "insert into animals (nameAnimals, typeAnimals, weightAnimals, colorAnimals, priceAnimals, ) values (@nameAnimals, @nameAnimals, @weightAnimals, @colorAnimals, @colorAnimals, @priceAnimals, @imageAnimals)";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute les paramètres à la commande
            //cmd.Parameters.AddWithValue("@idProprety", idProprety);
            cmd.Parameters.AddWithValue("@nameAnimals", nameAnimals);
            cmd.Parameters.AddWithValue("@typeAnimals", typeAnimals);
            cmd.Parameters.AddWithValue("@weightAnimals", weightAnimals);
            cmd.Parameters.AddWithValue("@colorAnimals", colorAnimals);
            cmd.Parameters.AddWithValue("@priceAnimals", priceAnimals);
            cmd.Parameters.AddWithValue("@imageAnimals", imageAnimals);

            //Il va ouvrir la connexion
            conn.Open();

            //Exécute une requete sur la connexion, et retourne le nombre de ligne affecté
            //Va permettre de faire de un Insert, un Delete et un Update 
            cmd.ExecuteNonQuery();

            //Libère les ressources utilisées par la commande
            cmd.Dispose();

            //Ferme la base de donnée
            conn.Close();
            DGV.Refresh();
        }

        private void FormEstate_Load(object sender, EventArgs e) {
            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //structure de donnée qui permet de recuperer toutes les données dans la table client
            DataSet ds = new DataSet();

            //créer une requete SQL qui récupère tout les éléments de la table client
            string sql = "select * from animals";

            //créer un objet permettant d'acceder à la base de donnée
            //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            //va permettre de remplir le dateset avec la table clinex 
            adapter.Fill(ds, "animals");

            //va afficher les données qui se trouve dans le dataset 
            
            DGV.DataSource = ds.Tables["animals"].DefaultView;
            DGV.Columns["idAnimals"].Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            // Convertit le contenu de txtBoxIdProprety en entier
            int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["idAnimals"].Value);

            // Récupère le contenu de txtBoxProprety dans une variable proprety
            string proprety = comboBoxProprety.Text;

            // Récupère le contenu de txtBoxConstrucYrs dans une variable construcYrs
            int construcYrs = Int32.Parse(txtBoxConstrucYrs.Text);

            // Récupère le contenu de txtBoxNbRoom dans une variable nbRoom
            int nbRoom = Int32.Parse(txtBoxNbRooms.Text);

            // Récupère le contenu de txtBoxNbBedRooms dans une variable nbBedRoom
            int nbBedRoom = Int32.Parse(txtBoxNbBedrooms.Text);

            int surface = Int32.Parse(txtBoxSurface.Text);

            // Crée un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            // Requête SQL d'update
            string sql = "update proprety set proprety = @proprety, constructionYear = @construcYrs, nbRoom = @nbRoom, nbBedRoom = @nbBedRoom, surface = @surface  where idProprety = @idProprety";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute les paramètres à la commande
            cmd.Parameters.AddWithValue("@idProprety", id);
            cmd.Parameters.AddWithValue("@proprety", proprety);
            cmd.Parameters.AddWithValue("@construcYrs", construcYrs);
            cmd.Parameters.AddWithValue("@nbRoom", nbRoom);
            cmd.Parameters.AddWithValue("@nbBedRoom", nbBedRoom);
            cmd.Parameters.AddWithValue("@surface", surface);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();

            DGV.Refresh();
        }

        private void addPropretyBtn_Click(object sender, EventArgs e) {
            // Récupère le contenu de txtBoxProprety dans une variable proprety
            string proprety = comboBoxProprety.Text;

            // Récupère le contenu de txtBoxConstrucYrs dans une variable construcYrs
            int construcYrs = Int32.Parse(txtBoxConstrucYrs.Text);

            // Récupère le contenu de txtBoxNbRoom dans une variable nbRoom
            int nbRoom = Int32.Parse(txtBoxNbRooms.Text);

            // Récupère le contenu de txtBoxNbBedRooms dans une variable nbBedRoom
            int nbBedRoom = Int32.Parse(txtBoxNbBedrooms.Text);

            int surface = Int32.Parse(txtBoxSurface.Text);

            //Créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);


            //requête SQL
            string sql = "insert into proprety (proprety, constructionYear, nbRoom, nbBedRoom, surface) values (@proprety, @construcYrs, @nbRoom, @nbBedRoom, @surface)";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute les paramètres à la commande
            cmd.Parameters.AddWithValue("@proprety", proprety);
            cmd.Parameters.AddWithValue("@construcYrs", construcYrs);
            cmd.Parameters.AddWithValue("@nbRoom", nbRoom);
            cmd.Parameters.AddWithValue("@nbBedRoom", nbBedRoom);
            cmd.Parameters.AddWithValue("@surface", surface);

            //Il va ouvrir la connexion
            conn.Open();

            //Exécute une requete sur la connexion, et retourne le nombre de ligne affecté
            //Va permettre de faire de un Insert, un Delete et un Update 
            cmd.ExecuteNonQuery();

            //Libère les ressources utilisées par la commande
            cmd.Dispose();

            //Ferme la base de donnée
            conn.Close();
        }

        private void researchBtn_Click(object sender, EventArgs e) {
            /* //permet de séléctionner toute la ligne 
             DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

             //créer un objet de connexion
             MySqlConnection conn = new MySqlConnection(mySqlConnection);

             //structure de donnée qui permet de recuperer toutes les données dans la table client
             DataSet ds = new DataSet();

             //créer une requete SQL qui récupère tout les éléments de la table client
             string sql = "select * from proprety";

             //créer un objet permettant d'acceder à la base de donnée
             //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
             MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

             //va permettre de remplir le dateset avec la table clinex 
             adapter.Fill(ds, "Proprety");

             //va afficher les données qui se trouve dans le dataset 
             DGV.DataSource = ds.Tables["Proprety"].DefaultView;*/
            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (comboBox1.Text == "House") {
                DGV.DataSource = AllMethodes.researchHouse();
                DGV.Columns["IdProprety"].Visible = false;
                DGV.Refresh();
            }

            else if (comboBox1.Text == "Appartment") {
                DGV.DataSource = AllMethodes.researchAppartment();
                DGV.Columns["IdProprety"].Visible = false;
                DGV.Refresh();
            }

            else if (comboBox1.Text == "All") {
                DGV.DataSource = AllMethodes.researchAll();
                DGV.Columns["IdProprety"].Visible = false;
                DGV.Refresh();
            }
        }

        private void testBtnResearch_Click(object sender, EventArgs e) {
            MySqlConnection conn = new MySqlConnection(mySqlConnection);
            DataSet ds = new DataSet();
            string test = "SELECT * FROM proprety where proprety like 'A%';";
            MySqlDataAdapter adapter = new MySqlDataAdapter(test, conn);
            //va permettre de remplir le dateset avec la table clinex 
            adapter.Fill(ds, "Proprety");

            //va afficher les données qui se trouve dans le dataset 
            dataGridView1.DataSource = ds.Tables["Proprety"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }

        private void button2_Click(object sender, EventArgs e) {
            MySqlConnection conn = new MySqlConnection(mySqlConnection);
            DataSet ds = new DataSet();
            string test = "SELECT * FROM proprety where proprety like 'H%';";
            MySqlDataAdapter adapter = new MySqlDataAdapter(test, conn);
            //va permettre de remplir le dateset avec la table clinex 
            adapter.Fill(ds, "Proprety");

            //va afficher les données qui se trouve dans le dataset 
            dataGridView1.DataSource = ds.Tables["Proprety"].DefaultView;
        }

        private void button1_Click_1(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (comboBox1.Text == "House")
            {
                DGV.DataSource = AllMethodes.researchHouse();
                DGV.Refresh();
            }

            else if (comboBox1.Text == "Appartment")
            {
                DGV.DataSource = AllMethodes.researchAppartment();
                DGV.Refresh();
            }

            else if (comboBox1.Text == "All")
            {
                DGV.DataSource = AllMethodes.researchAll();
                DGV.Refresh();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            //if(radioButton1.Checked) {
            //    DGV.DataSource = AllMethodes.researchAll();
            //    DGV.Refresh();
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                DGV.DataSource = AllMethodes.researchByType(textBox1.Text); 
                DGV.Refresh();
            }

            else if (radioButton2.Checked) {
                DGV.DataSource = AllMethodes.researchByYear(textBox1.Text);
                DGV.Refresh();
            }

            else if(radioButton3.Checked) { 
                DGV.DataSource = AllMethodes.researchBySurface(textBox1.Text);
                DGV.Refresh();  
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
