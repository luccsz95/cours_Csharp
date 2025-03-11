using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace e_proejct_F_4_7_2 {
        public partial class FormAnimals : Form {
            string mySqlConnection = "server=127.0.0.1;uid=root;database=e_commerce_project";

            public FormAnimals() {
                InitializeComponent();
            }

            private void FormAnimals_Load(object sender, EventArgs e) {
                LoadAnimals();
            }

            private void LoadAnimals() {
                //permet de séléctionner toute la ligne 
                DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //créer un objet de connexion
                MySqlConnection conn = new MySqlConnection(mySqlConnection);

                //structure de donnée qui permet de recuperer toutes les données dans la table animals
                DataSet ds = new DataSet();

                //créer une requete SQL qui récupère tout les éléments de la table animals
                string sql = "select * from animals";

                //créer un objet permettant d'acceder à la base de donnée
                //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                //va permettre de remplir le dataset avec la table animals 
                adapter.Fill(ds, "animals");

                //va afficher les données qui se trouve dans le dataset 
                DGV.DataSource = ds.Tables["animals"].DefaultView;
                DGV.Columns["idAnimals"].Visible = false;
            }

            private void addAnimal_Click(object sender, EventArgs e) {
                string nameAnimals = tbNameAnimals.Text;
                string typeAnimals = tbTypeAnimals.Text;
                string weightAnimals = tbWeightAnimals.Text;
                string colorAnimals = tbColorAnimals.Text;
                string priceAnimals = tbPriceAnimals.Text;
                string imageAnimals = tbImageAnimals.Text;

                MySqlConnection conn = new MySqlConnection(mySqlConnection);
                string sql = "insert into animals (idAnimals ,nameAnimals, typeAnimals, weightAnimals, colorAnimals, priceAnimals, imageAnimals) values (@idAnimals ,@nameAnimals, @typeAnimals, @weightAnimals, @colorAnimals, @priceAnimals, @imageAnimals)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idAnimals", 0);
                cmd.Parameters.AddWithValue("@nameAnimals", nameAnimals);
                cmd.Parameters.AddWithValue("@typeAnimals", typeAnimals);
                cmd.Parameters.AddWithValue("@weightAnimals", weightAnimals);
                cmd.Parameters.AddWithValue("@colorAnimals", colorAnimals);
                cmd.Parameters.AddWithValue("@priceAnimals", priceAnimals);
                cmd.Parameters.AddWithValue("@imageAnimals", imageAnimals);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                LoadAnimals();
            }

            private void deleteAnimal_Click(object sender, EventArgs e) {
                int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["idAnimals"].Value);
                MySqlConnection conn = new MySqlConnection(mySqlConnection);
                string sql = "delete from animals where idAnimals = @idAnimals";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idAnimals", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                LoadAnimals();
            }

            private void updateAnimal_Click(object sender, EventArgs e) {
                int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["idAnimals"].Value);
                string nameAnimals = tbNameAnimals.Text;
                string typeAnimals = tbTypeAnimals.Text;
                string weightAnimals =tbWeightAnimals.Text;
                string colorAnimals = tbColorAnimals.Text;
                string priceAnimals = tbPriceAnimals.Text;
                string imageAnimals = tbImageAnimals.Text;

                MySqlConnection conn = new MySqlConnection(mySqlConnection);
                string sql = "update animals set nameAnimals = @nameAnimals, typeAnimals = @typeAnimals, weightAnimals = @weightAnimals, colorAnimals = @colorAnimals, priceAnimals = @priceAnimals, imageAnimals = @imageAnimals where idAnimals = @idAnimals";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idAnimals", id);
                cmd.Parameters.AddWithValue("@nameAnimals", nameAnimals);
                cmd.Parameters.AddWithValue("@typeAnimals", typeAnimals);
                cmd.Parameters.AddWithValue("@weightAnimals", weightAnimals);
                cmd.Parameters.AddWithValue("@colorAnimals", colorAnimals);
                cmd.Parameters.AddWithValue("@priceAnimals", priceAnimals);
                cmd.Parameters.AddWithValue("@imageAnimals", imageAnimals);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                LoadAnimals();
            }

            private void btnExit_Click(object sender, EventArgs e) {
                //Stockage de l'affichage de demande de fermeture du formulaire
                DialogResult result = MessageBox.Show("Are you sure you want to leave ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                //Condition pour permettre la fermeture du formulaire
                if (result == DialogResult.Yes) {
                    //ferme le formulaire
                    this.Close();
                }
            }

        private void btnClearTb_Click(object sender, EventArgs e) {
            //Permet de supprimer tout ce qu'il se trouve dans les textBoxs
            tbNameAnimals.Clear();
            tbTypeAnimals.Clear();
            tbWeightAnimals.Clear();
            tbColorAnimals.Clear();
            tbPriceAnimals.Clear();
            tbImageAnimals.Clear();
        }

        private void modifyAnAnimalToolStripMenuItem_Click(object sender, EventArgs e) {
            if (DGV.SelectedRows.Count > 0) {
                int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["idAnimals"].Value);
                MySqlConnection conn = new MySqlConnection(mySqlConnection);
                string sql = "select * from animals where idAnimals = @idAnimals";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idAnimals", id);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    tbNameAnimals.Text = reader["nameAnimals"].ToString();
                    tbTypeAnimals.Text = reader["typeAnimals"].ToString();
                    tbWeightAnimals.Text = reader["weightAnimals"].ToString();
                    tbColorAnimals.Text = reader["colorAnimals"].ToString();
                    tbPriceAnimals.Text = reader["priceAnimals"].ToString();
                    tbImageAnimals.Text = reader["imageAnimals"].ToString();
                }
                reader.Close();
                cmd.Dispose();
                conn.Close();
            }
        }
    }
    }

