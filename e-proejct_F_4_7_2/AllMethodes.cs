using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace e_proejct_F_4_7_2 {
    public static class AllMethodes {
        //Chaine de connexion
        //static string mySqlConnection = "server=127.0.0.1;uid=userdb;pwd=265656;database=e_commerce_project";
        static string mySqlConnection = "server=127.0.0.1;uid=root;database=e_commerce_project";

        //Méthode permettant de vérifier si au moins un des champs du login est vide ou non
        public static bool verifChampLogin(string email, string password) {
            //condition permettant de vérifier si l'email ou le password on un caractère null
            if (email == "" || password == "") {
                //Affiche un message d'erreur
                MessageBox.Show("At least one of the fields is empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //retourne faux si un des champs est vide
                return false;
            }

            //retourn vrai s'il n'y a pas de problème 
            return true;
        }

        //Méthode permettant de vérifier si au moins un des champs du singin est vide ou non
        public static bool verifChampSignin(string lastname, string firstname ,string email, string password, string confirmPassword, string phone) {
            //Condition permettant de vérifié si les champs sont vide ou non
            if (lastname == "" || firstname == "" || email == "" || password == "" || confirmPassword == "" || phone == "") {
                //retourne faux si un des champs est vide
                return false;
            }

            //retourn vrai s'il n'y a pas de problème 
            return true;
        }

        //Permet de confirmer si les champs entré par l'utilisateur est le même ou non
        public static bool verifPassword(string password, string confirmPassword) {
            //Condition vérifiant si les champs inserer par l'utilisateur sont les mêmes ou non
            if (password != confirmPassword) {
                //Affiche une erreur si la vérification des mots de passe n'est pas le même
                MessageBox.Show("The passwords are diffrent !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //retourne faux si un des champs n'est pas le même
                return false;
            }

            //Si la condition vérifiant les champs n'est pas utiliser
            else {
                //retourner vrai si toutes les conditions sont remplis
                return true;
            }
        }

        //Méthode vérifiant si un utilisateur existe déjà ou non.
        public static object verifUser(string email) {
            /*MySqlConnection cn = new MySqlConnection(mySqlConnection);

            string sql = "select * from user where EmailUser='" + email + "'";

            cn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            var result = cmd.ExecuteScalar();
            return result;*/

            //Chaine de connexion à la base de donnée via le dossier app.config
            //string str = ConfigurationManager.ConnectionStrings["Mycn"].ConnectionString;

            //Créer une nouvelle connexion
            MySqlConnection cn = new MySqlConnection(mySqlConnection);
            //Initialise une nouvelle commande
            MySqlCommand cmd = null;

            //Essaie
            try {
                //requête SQL permettant de récuperer l'email depuis la table user 
                string sql = "select * from users where email='" + email + "'";

                //ouvre la Base de Donnée (BD)
                cn.Open();
                //Créer une commande grâce a l'initialisation de la commande
                cmd = new MySqlCommand(sql, cn);
                //retourn la commande dans une variable
                return cmd.ExecuteScalar();
            }

            //Renvois
            catch {
                //???
                throw;
            }

            //En fin
            finally {
                //Va supprimer l'espace mémoire allouée pour la commande 
                cmd.Dispose();
                //Ferme la BD
                cn.Close();
            }
        }

        //addUser whiteout try catch
        /*public static void addUser(string lastname, string firstname, string email, string password, string phone)
        {
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //requête SQL
            string querrySql = "insert into user (LastnameUser, FirstnameUser, EmailUser, PasswordUser, PhoneNumberUser) values (@Lastname, @Firstname, @Email, @Password, @Phone)";

            //Va exécuter la reqête SQL
            MySqlCommand cmd = new MySqlCommand(querrySql, conn);

            //On va rajouter la valeur récuperer de la txtBox en question et il va la rajouter à la base de donnée via le @valeur
            cmd.Parameters.AddWithValue("@Lastname", lastname);
            cmd.Parameters.AddWithValue("@Firstname", firstname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Phone", phone);

            //Il va ouvrir la connexion
            conn.Open();

            //Exécute une requete sur la connexion, et retourne le nombre de ligne affecté
            //Va permettre de faire de un Insert, un Delete et un Update 
            cmd.ExecuteNonQuery();

            cmd.Dispose();

            //Ferme la base de donnée
            conn.Close();
        }*/

        //adduser with try catch
        public static void addUser(string lastname, string firstname, string email, string password, string phone) {
            //Créer une nouvelle connexion via grâce à la chaine de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);
            //Requête SQL permettant l'insertion d'un nouvel utilisateur
            string querrySql = "insert into users (lastname, firstname, email, password, phonenumber) values (@Lastname, @Firstname, @Email, @Password, @Phone)";
            //Créer une nouvelle commande
            MySqlCommand cmd = new MySqlCommand(querrySql, conn);

            //essaie
            try {
                //Il va ouvrir la connexion
                conn.Open();

                //On va rajouter la valeur récuperer de la txtBox en question et il va la rajouter à la base de donnée via le @valeur
                cmd.Parameters.AddWithValue("@Lastname", lastname);
                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Phone", phone);
                //Exécute une requete sur la connexion, et retourne le nombre de ligne affecté
                //Va permettre de faire de un Insert, un Delete et un Update 
                cmd.ExecuteNonQuery();
            }

            //Renvois
            catch {
                //Renvois une exception / erreur
                throw new Exception();
            }

            //En fin
            finally {
                //Ferme la base de donnée
                conn.Close();

                //Empty the allocated momory space for the command 
                cmd.Dispose();
            } 
        }

        //loadUser whiteout try catch
        /*public static DataTable loadUser() {
            //chaine de connexion
            string str = ConfigurationManager.ConnectionStrings["Mycn"].ConnectionString;

            //créer une connexion
            MySqlConnection cn = new MySqlConnection(str);

            //ouvrir la BD
            cn.Open();

            //affiche l'état de la BD
            MessageBox.Show(cn.State.ToString());

            //Requete SQL pour récupérer ce qu'il se trouve dans user
            string querystring = "SELECT * FROM user";

            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //Créer un commande récupérant la requete et le connexion
            adapter.SelectCommand = new MySqlCommand(querystring, cn);

            //remplis le BD
            adapter.Fill(dt);            

            //Ferme la connexion
            cn.Close();

            //Supprimer l'espace mémoire empreinter 
            adapter.Dispose();

            return dt;
        }*/

        public static DataTable loadUser() {
            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try {
                //chaine de connexion
                string str = ConfigurationManager.ConnectionStrings["Mycn"].ConnectionString;

                //créer une connexion
                MySqlConnection cn = new MySqlConnection(str);

                //ouvrir la BD
                cn.Open();

                //Requete SQL pour récupérer ce qu'il se trouve dans user
                string querystring = "select * from users";

                //Créer un commande récupérant la requete et le connexion
                adapter.SelectCommand = new MySqlCommand(querystring, cn);

                //remplis le BD
                adapter.Fill(dt);

                //Ferme la connexion
                cn.Close();
            }

            catch {
                //Envois un message d'erreur
                MessageBox.Show("Error");
            }            

            finally {
                //Libère l'espace mémoire alloué pour la commande
                adapter.Dispose();
            }

            //retourne ce qu'il se trouve dans la DataTable
            return dt;
        }

        public static void updateUser() {
            //Créer un objet de connexion
            MySqlConnection conn = new MySqlConnection(mySqlConnection);

            //requête SQL d'insertion d'utilisateur
            string querrySql = "insert into users (lastname, firstname, email, password, phonenumber) values (@Lastname, @Firstname, @Email, @Password, @Phone)";

            //Va exécuter la reqête SQL
            MySqlCommand cmd = new MySqlCommand(querrySql, conn);
        }

        public static DataTable researchAll() {
            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try {
                //chaine de connexion
                string str = ConfigurationManager.ConnectionStrings["Mycn2"].ConnectionString;

                //créer une connexion
                MySqlConnection cn = new MySqlConnection(str);

                //ouvrir la BD
                cn.Open();
                
                //Requete SQL pour récupérer ce qu'il se trouve dans user
                string querystring = "select * from aniamls";

                //Créer un commande récupérant la requete et le connexion
                adapter.SelectCommand = new MySqlCommand(querystring, cn);

                //remplis le BD
                adapter.Fill(dt);

                //Ferme la connexion
                cn.Close();
            }

            catch {
                //Envois un message d'erreur
                MessageBox.Show("Error");
            }

            finally {
                //Libère l'espace mémoire alloué pour la commande
                adapter.Dispose();
            }

            //retourne ce qu'il se trouve dans la DataTable
            return dt;
        }

        public static DataTable researchHouse() {
            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try {
                //chaine de connexion
                string str = ConfigurationManager.ConnectionStrings["Mycn2"].ConnectionString;

                //créer une connexion
                MySqlConnection cn = new MySqlConnection(str);

                //ouvrir la BD
                cn.Open();

                //Requete SQL pour récupérer ce qu'il se trouve dans user
                string querystring = "SELECT * FROM animals where typeAnimals like 'd%';";

                //Créer un commande récupérant la requete et le connexion
                adapter.SelectCommand = new MySqlCommand(querystring, cn);

                //remplis le BD
                adapter.Fill(dt);

                //Ferme la connexion
                cn.Close();
            }

            catch {
                //Envois un message d'erreur
                MessageBox.Show("Error");
            }

            finally {
                //Libère l'espace mémoire alloué pour la commande
                adapter.Dispose();
            }

            //retourne ce qu'il se trouve dans la DataTable
            return dt;
        }

        public static DataTable researchAppartment() {
            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try {
                //chaine de connexion
                string str = ConfigurationManager.ConnectionStrings["Mycn2"].ConnectionString;

                //créer une connexion
                MySqlConnection cn = new MySqlConnection(str);

                //ouvrir la BD
                cn.Open();

                //Requete SQL pour récupérer ce qu'il se trouve dans user
                string querystring = "select * from animals where typeAnimals like 'c%';";

                //Créer un commande récupérant la requete et le connexion
                adapter.SelectCommand = new MySqlCommand(querystring, cn);

                //remplis le BD
                adapter.Fill(dt);

                //Ferme la connexion
                cn.Close();
            }

            catch {
                //Envois un message d'erreur
                MessageBox.Show("Error");
            }

            finally {
                //Libère l'espace mémoire alloué pour la commande
                adapter.Dispose();
            }

            //retourne ce qu'il se trouve dans la DataTable
            return dt;
        }

        public static DataTable researchByType(string dataType)
        {
            //MessageBox.Show(dataYear);
            dataType = '%' + dataType + '%';

            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //chaine de connexion
            string str = ConfigurationManager.ConnectionStrings["Mycn2"].ConnectionString;

            //créer une connexion
            MySqlConnection cn = new MySqlConnection(str);

            //ouvrir la BD
            cn.Open();

            //Requete SQL pour récupérer la date de construction

            string sql = "select * from animals where typeAnimals like @dataType ;";

            MySqlCommand cmd = new MySqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@dataType", dataType);

            adapter.SelectCommand = cmd;

            //remplis le datagridview
            adapter.Fill(dt);

            //Ferme la connexion
            cn.Close();


            //Libère l'espace mémoire alloué pour la commande
            adapter.Dispose();

            //retourne ce qu'il se trouve dans la DataTable
            return dt;
        }

        public static DataTable researchByYear(string dataYear) {
            //MessageBox.Show(dataYear);
            dataYear = '%' + dataYear + '%';

            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //chaine de connexion
            string str = ConfigurationManager.ConnectionStrings["Mycn2"].ConnectionString;

            //créer une connexion
            MySqlConnection cn = new MySqlConnection(str);

            //ouvrir la BD
            cn.Open();

            //Requete SQL pour récupérer la date de construction

            string sql = "select * from animals where birthdayAnimals like @dataYear ;";
            
            MySqlCommand cmd = new MySqlCommand(sql, cn);
            
            cmd.Parameters.AddWithValue("@dataYear", dataYear);

            adapter.SelectCommand = cmd;

            //remplis le datagridview
            adapter.Fill(dt);

            //Ferme la connexion
            cn.Close();


            //Libère l'espace mémoire alloué pour la commande
            adapter.Dispose();
            
            //retourne ce qu'il se trouve dans la DataTable
            return dt;
        }

        public static DataTable researchBySurface(string dataSurface) {
            //MessageBox.Show(dataYear);
            dataSurface = '%' + dataSurface + '%';

            //Créer un nouveau dataTable
            DataTable dt = new DataTable();

            //Créer un dataAdaptateur
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //chaine de connexion
            string str = ConfigurationManager.ConnectionStrings["Mycn2"].ConnectionString;

            //créer une connexion
            MySqlConnection cn = new MySqlConnection(str);

            //ouvrir la BD
            cn.Open();

            //Requete SQL pour récupérer la date de construction

            string sql = "select * from animals where nameAnimals like @dataSurface ;";

            MySqlCommand cmd = new MySqlCommand(sql, cn);

            cmd.Parameters.AddWithValue("@dataSurface", dataSurface);

            adapter.SelectCommand = cmd;

            //remplis le datagridview
            adapter.Fill(dt);

            //Ferme la connexion
            cn.Close();


            //Libère l'espace mémoire alloué pour la commande
            adapter.Dispose();

            //retourne ce qu'il se trouve dans la DataTable
            return dt;

        }
    }
}
