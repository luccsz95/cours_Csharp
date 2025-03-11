using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptSharp; // Ajout de l'utilisation de CryptSharp

namespace e_proejct_F_4_7_2
{
    public partial class FormAuthent : Form
    {

        string mySqlConnection = "server=127.0.0.1;uid=root;database=e_commerce_project";

        public FormAuthent()
        {
            InitializeComponent();
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Hide();
        }

        private void connectionBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text;
            string password = pswTxtBox.Text;
            Main main = new Main();
            FormAuthent formAuthent = new FormAuthent();
            string querySqlSelect = "SELECT email, password FROM users WHERE email = @Email";

            MySqlConnection conn = new MySqlConnection(mySqlConnection);
            MySqlCommand cmd = new MySqlCommand(querySqlSelect, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (AllMethodes.verifChampLogin(email, password))
            {
                if (reader.Read())
                {
                    string dbPassword = reader["password"].ToString();

                    // Utiliser CryptSharp pour vérifier le mot de passe haché
                    if (Crypter.CheckPassword(password, dbPassword))
                    { // Comparaison du mot de passe haché avec le mot de passe entré
                        // Les identifiants sont corrects
                        MessageBox.Show("Connection approved", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        // Mot de passe incorrect
                        MessageBox.Show("Password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Email non trouvé dans la base de données
                    MessageBox.Show("No email found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["Mycn"].ConnectionString;
            MySqlConnection conn = new MySqlConnection(str);
            conn.Open();
            MessageBox.Show(conn.State.ToString());
        }
    }
}
