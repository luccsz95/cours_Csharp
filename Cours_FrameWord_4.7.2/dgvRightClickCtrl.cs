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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cours_FrameWord_4._7._2
{
    public partial class dgvRightClickCtrl : Form
    {
        private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\Desktop\\BTS\\Informatique\\newInfo\\projet\\cours_csharp\\FormE-project\\data\\InstaDB.mdf;Integrated Security=True";

        public dgvRightClickCtrl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //va transformer ce qu'il se trouve dans dans la textBox1 en Integer 
            int Id = Int32.Parse(textBox1.Text);

            //récupère dans une variable nom ce qu'il se trouve dans la textBox2 
            string nom = textBox2.Text;

            //récupère dans une variable nom ce qu'il se trouve dans la textBox3
            string prenom = textBox3.Text;

            //Créer un objet de connexion
            SqlConnection conn = new SqlConnection(str);


            //requête SQL
            string sql = "insert into client (Id, nom,prenom) values (@Id,@nom,@prenom)";

            //Va exécuter la reqête SQL
            SqlCommand cmd = new SqlCommand(sql, conn);

            //On va rajouter Id récuperer de la txtBox1 et il va la rajouter à la base de donnée via le @Id
            cmd.Parameters.AddWithValue("@Id", Id);

            //On va rajouter le nom récuperer de la txtBox2 et il va la rajouter à la base de donnée via le @nom
            cmd.Parameters.AddWithValue("@nom", nom);

            //On va rajouter prenom récuperer de la txtBox3 et il va la rajouter à la base de donnée via le @prenom
            cmd.Parameters.AddWithValue("@prenom", prenom);

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Ce champ ne doit contenir que des chiffres sans point ou virgule!").ToString(); //<- le message est déjà en ToString, donc pas nécessaire (je le laisse pour l'expliquation)
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permet d'empêcher l'entrer de chiffre, caractères spécials et de presser la touche <-- pour supprimer
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("ce champ ne doit pas contenir des chiffres, ni sperateur, ni symbole").ToString();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permet d'empêcher l'entrer de chiffre, caractères spécials et de presser la touche <-- pour supprimer
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsSeparator(e.KeyChar)) //j'ai retirer "char.IsControl(e.KeyChar) pour pouvoir effacer avec la touche Backspace
            {
                e.Handled = true;
                MessageBox.Show("ce champ ne doit pas contenir des chiffres, ni sperateur, ni symbole").ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Convertit le contenu de textBox1 en entier
            int Id = Int32.Parse(textBox1.Text);

            // Récupère le contenu de textBox2 dans une variable nom
            string nom = textBox2.Text;

            // Récupère le contenu de textBox3 dans une variable prenom
            string prenom = textBox3.Text;

            // Crée un objet de connexion
            SqlConnection conn = new SqlConnection(str);

            // Requête SQL d'update
            string sql = "update client set nom = @nom, prenom = @prenom where Id = @Id";

            // Crée une commande SQL avec la requête et la connexion
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Ajoute les paramètres à la commande
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();
        }

        private void suppressToolStripMenuItem_Click(object sender, EventArgs e)
        {
                // Obtient l'ID de la ligne sélectionnée dans le DataGridView
                int selectedId = Convert.ToInt32(DGV.SelectedRows[0].Cells["Id"].Value);

                // Crée un objet de connexion
                SqlConnection conn = new SqlConnection(str);

                // Requête SQL de suppression de la ligne sélectionnée
                string sql = "delete from client where Id = @Id";

                // Crée une commande SQL avec la requête et la connexion
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Ajoute le paramètre à la commande
                cmd.Parameters.AddWithValue("@Id", selectedId);

                // Ouvre la connexion à la base de données
                conn.Open();

                // Exécute la commande et retourne le nombre de lignes affectées
                cmd.ExecuteNonQuery();

                // Libère les ressources utilisées par la commande
                cmd.Dispose();

                // Ferme la connexion à la base de données
                conn.Close();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Convertit le contenu de textBox1 en entier
            int Id = Int32.Parse(textBox1.Text);

            // Récupère le contenu de textBox2 dans une variable nom
            string nom = textBox2.Text;

            // Récupère le contenu de textBox3 dans une variable prenom
            string prenom = textBox3.Text;

            // Crée un objet de connexion
            SqlConnection conn = new SqlConnection(str);

            // Requête SQL d'update
            string sql = "update client set nom = @nom, prenom = @prenom where Id = @Id";

            // Crée une commande SQL avec la requête et la connexion
            SqlCommand cmd = new SqlCommand(sql, conn);

            // Ajoute les paramètres à la commande
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);

            // Ouvre la connexion à la base de données
            conn.Open();

            // Exécute la commande et retourne le nombre de lignes affectées
            cmd.ExecuteNonQuery();

            // Libère les ressources utilisées par la commande
            cmd.Dispose();

            // Ferme la connexion à la base de données
            conn.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //permet de séléctionner toute la ligne 
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


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
            DGV.DataSource = ds.Tables["Client"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                // Obtient l'ID de la ligne sélectionnée dans le DataGridView
                int Id = Convert.ToInt32(DGV.SelectedRows[0].Cells["Id"].Value);

                // Crée un objet de connexion
                SqlConnection conn = new SqlConnection(str);

                // Requête SQL de suppression de la ligne sélectionnée
                string sql = "delete from client where Id = @Id";

                // Crée une commande SQL avec la requête et la connexion
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Ajoute le paramètre à la commande
                cmd.Parameters.AddWithValue("@Id", Id);

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
