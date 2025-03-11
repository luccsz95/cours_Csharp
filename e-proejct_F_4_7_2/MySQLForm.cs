using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cours_FrameWord_4._7._2
{
    public partial class MySQLForm : Form
    {
        string mySqlConnection = "server=127.0.0.1;uid=userdb;" +
                "pwd=265656;database=e-commerce_project";

        public MySQLForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*//chaine de connexion vers la bd MySQL
            

            //Créer une connexion à la bd mysql
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //Va se connecter via la chaine de caractère fournis
            conn.ConnectionString = mySqlConnection;

            //Ouvre la bd
            conn.Open();

            //Affiche l'état de connexion dans une MessageBox
            MessageBox.Show(conn.State.ToString())*/

            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //structure de donnée qui permet de recuperer toutes les données dans la table client
            DataSet ds = new DataSet();

            //créer une requete SQL qui récupère tout les éléments de la table client
            string querrySql = "select * from user";

            //créer un objet permettant d'acceder à la base de donnée
            //Fait la liaison entre la base de donnée et le dataset via des commandes (requete SQL)
            MySqlDataAdapter adapter = new MySqlDataAdapter(querrySql, conn);

            //va permettre de remplir le dateset avec la table clinex 
            adapter.Fill(ds, "User");

            //va afficher les données qui se trouve dans le dataset 
            DGV.DataSource = ds.Tables["User"].DefaultView;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtient l'ID de la ligne sélectionnée dans le DataGridView
            int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["id_user"].Value);

            // Crée un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            // Requête SQL de suppression de la ligne sélectionnée idProprety c'est la colonne dans la DB et le @idProprety peut prendre le nom voulu
            string sql = "delete from user where id_user = @id_user";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute le paramètre à la commande
            cmd.Parameters.AddWithValue("@id_user", id);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rowIndex, permet de sélectionner la cellulre de la ligne dans laquelle on se trouve (moi)
            int rowIndex = DGV.CurrentCell.RowIndex;

            //rowIndex, permet de sélectionner la cellulre de la colonne dans laquelle on se trouve (moi)
            int columnIndex = DGV.CurrentCell.ColumnIndex;

            //Va afficher dans les textBox, tout ce qu'il se trouve dans chaque cellule de la ligne grace a rowIndex
            textBox2.Text = DGV.Rows[rowIndex].Cells[1].Value.ToString();
            textBox3.Text = DGV.Rows[rowIndex].Cells[2].Value.ToString();
            textBox4.Text = DGV.Rows[rowIndex].Cells[3].Value.ToString();
            textBox5.Text = DGV.Rows[rowIndex].Cells[4].Value.ToString();
            textBox6.Text = DGV.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //va transformer ce qu'il se trouve dans dans la textBox1 en Integer 

            //récupère dans une variable nom ce qu'il se trouve dans la textBox2 
            string lastname = textBox2.Text;

            //récupère dans une variable nom ce qu'il se trouve dans la textBox3
            string firstname = textBox3.Text;

            string email = textBox4.Text;

            string password = textBox5.Text;

            string role = textBox6.Text;

            string phone = textBox7.Text;


            //Créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);


            //requête SQL
            string querrySql = "insert into user (LastnameUser, FirstnameUser, EmailUser, PasswordUser, PhoneNumberUser, Role) values (@Lastname, @Firstname, @Email, @Password, @Phone, @Role)";

            //Va exécuter la reqête SQL
            MySqlCommand cmd = new MySqlCommand(querrySql, conn);

            //On va rajouter Id récuperer de la txtBox1 et il va la rajouter à la base de donnée via le @Id

            //On va rajouter le nom récuperer de la txtBox2 et il va la rajouter à la base de donnée via le @nom
            cmd.Parameters.AddWithValue("@Lastname", lastname);

            //On va rajouter prenom récuperer de la txtBox3 et il va la rajouter à la base de donnée via le @prenom
            cmd.Parameters.AddWithValue("@Firstname", firstname);

            cmd.Parameters.AddWithValue("@Email", email);

            cmd.Parameters.AddWithValue("@Password", password);

            cmd.Parameters.AddWithValue("@Phone", phone);

            cmd.Parameters.AddWithValue("@Role", role);


            //Il va ouvrir la connexion
            conn.Open();

            //Exécute une requete sur la connexion, et retourne le nombre de ligne affecté
            //Va permettre de faire de un Insert, un Delete et un Update 
            cmd.ExecuteNonQuery();

            //
            cmd.Dispose();

            //Ferme la base de donnée
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DGV.SelectedRows[0].Cells["id_user"].Value);

            string lastname = textBox2.Text;

            string firstname = textBox3.Text;

            string email = textBox4.Text;

            string password = textBox5.Text;

            string role = textBox6.Text;

            string phone = textBox7.Text;

            // Crée un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            // Requête SQL d'update
            string sql = "update user set LastnameUser = @lastname, FirstnameUser = @firstname, EmailUser = @email, PasswordUser = @password, PhoneNumberUser = @phone, Role = @role  where Id_user = @id";

            // Crée une commande SQL avec la requête et la connexion
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            // Ajoute les paramètres à la commande
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@role", role);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();

        }
    }
}
