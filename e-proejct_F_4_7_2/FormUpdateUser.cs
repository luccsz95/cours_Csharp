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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace e_proejct_F_4_7_2 {
    public partial class FormUpdateUser : Form {
        //recuperer la chaine de connexion via le chemin de la BD
        string mySqlConnection = "server=127.0.0.1;uid=root;database=e_commerce_project";

        //récupere la chaine de connexion à partir du fichier de configuration app.config
        string str = ConfigurationManager.ConnectionStrings["Mycn"].ConnectionString;

        public FormUpdateUser() {
            InitializeComponent();
        }

        private void stopBtn_Click(object sender, EventArgs e) {
            //ferme la page
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e) {
            //Permet de convertir l'id qui est en string en int
            int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["idUser"].Value);
            //Varraibles permettant de stocker ce qu'il se trouve dans les textBoxs
            string lastname = lastNameTxtBox.Text;
            string firstname = firstNameTxtBox.Text;
            string email = emailTxtBox.Text;
            string password = pwdTxtBox.Text;
            string phonenumber = phTxtBox.Text;

            // Crée un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            // Requête SQL d'update
            string sql = "update users set lastname = @lastname, firstname = @firstname, email = @email, password = @password, phonenumber = @phonenumber where idUser = @id";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute les paramètres à la commande
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();
        }

        private void modifiyToolStripMenuItem_Click(object sender, EventArgs e) {
            //rowIndex, permet de sélectionner la cellulre de la ligne dans laquelle on se trouve (moi)
            int rowIndex = DGV.CurrentCell.RowIndex;

            //rowIndex, permet de sélectionner la cellulre de la colonne dans laquelle on se trouve (moi)
            int columnIndex = DGV.CurrentCell.ColumnIndex;

            //Va afficher dans les textBox, tout ce qu'il se trouve dans chaque cellule de la ligne grace a rowIndex
            lastNameTxtBox.Text = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            firstNameTxtBox.Text = DGV.Rows[rowIndex].Cells[2].Value.ToString();
            emailTxtBox.Text = DGV.Rows[rowIndex].Cells[3].Value.ToString();
            pwdTxtBox.Text = DGV.Rows[rowIndex].Cells[4].Value.ToString();
            phTxtBox.Text = DGV.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void insertBtn_Click(object sender, EventArgs e) {
            //Varraibles permettant de stocker ce qu'il se trouve dans les textBoxs
            string lastname = lastNameTxtBox.Text;
            string firstname = firstNameTxtBox.Text;
            string email = emailTxtBox.Text;
            string password = pwdTxtBox.Text;
            string phonenumber = phTxtBox.Text;

            //Créer un objet de connexion / initialiser l'objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //requête SQL d'insertion d'utilisateur
            string querrySql = "insert into users (lastname, firstname, email, password, phonenumber) values (@lastname, @firstname, @email, @password, @phonenumber)";

            //Va exécuter la reqête SQL
            MySqlCommand cmd = new MySqlCommand(querrySql, conn);

            //On va rajouter les attribues a récuperer dans les textBox concerné et il va la rajouter à la base de donnée via le @variable
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);

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

        private void openDBToolStripMenuItem_Click(object sender, EventArgs e) {
            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //structure de donnée qui permet de recuperer toutes les données dans la table client
            DataSet ds = new DataSet();

            //créer une requete SQL qui récupère tout les éléments de la table client
            string querrySql = "select * from users";

            //créer un objet permettant d'acceder à la base de donnée
            //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
            MySqlDataAdapter adapter = new MySqlDataAdapter(querrySql, conn);

            //va permettre de remplir le dateset avec la table client
            adapter.Fill(ds, "User");

            //va afficher les données qui se trouve dans le dataset 
            DGV.DataSource = ds.Tables["User"].DefaultView;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            // Obtient l'ID de la ligne sélectionnée dans le DataGridView
            int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["idUser"].Value);

            // Crée un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            // Requête SQL de suppression de la ligne sélectionnée idProprety c'est la colonne dans la DB et le @idProprety peut prendre le nom voulu
            string sql = "delete from users where idUser= @idUser";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute le paramètre à la commande
            cmd.Parameters.AddWithValue("@idUser", id);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();
        }

        private void clearTxtBoxBtn_Click(object sender, EventArgs e) {
            //Permet de supprimer tout ce qu'il se trouve dans les textBoxs
            lastNameTxtBox.Clear();
            firstNameTxtBox.Clear();
            emailTxtBox.Clear();
            pwdTxtBox.Clear();
            phTxtBox.Clear();
        }

        private void FormUpdateUser_Load(object sender, EventArgs e) {
            //créer un nouvel objet de connexion
            MySqlConnection connection = new MySqlConnection(mySqlConnection);

            //ouvre la BD
            connection.Open();

            //Requête SQL qui selectionne tous ce qui se trouve dans la table user
            string query = "select * from users";

            //Permet d'effectuer une requête 
            MySqlCommand command = new MySqlCommand(query, connection);

            //Va faire la liaison entre la BD et le DataTable
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            //Créer une DataTable, qui contiendra des données
            DataTable table = new DataTable();

            //Rempli 
            adapter.Fill(table);

            //Affiche dans le datagridview le contenu de la table
            DGV.DataSource = table;

            //Ferme la connexion
            connection.Close();
        }
    }
}
