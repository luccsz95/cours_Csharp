using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CryptSharp; // Ajout de l'utilisation de la bibliothèque CryptSharp
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace e_proejct_F_4_7_2
{
    public partial class Inscription : Form
    {
        //string mySqlConnection = "server=127.0.0.1;uid=userdb; pwd=265656;database=e_commerce_project";
        string mySqlConnection = "server=127.0.0.1;uid=root;database=e_commerce_project";

        public Inscription()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Créer un nouveau Form D'authentification
            FormAuthent authent = new FormAuthent();
            //ouvre un formaulaire d'authentification
            authent.Show();
            //ferme cette page
            //this.Close();

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //Variable permettant la récupération de se qui a été écrit dans les txtBoxs
            string lastname = lastnameTxtBox.Text;
            string firstname = firstnameTxtBox.Text;
            string email = emailTxtBox.Text;
            string password = pswTxtBox.Text;
            string confirmPassword = confirmPswTxtBox.Text;
            string phone = PhoneNbTxtBox.Text;

            //Stock dans une variable le résultat que retourne la méthode verifUser
            var result = AllMethodes.verifUser(email);

            //Création d'une instance du formulaire Main
            Main main = new Main();

            //Création d'une instance du formulaire Inscription
            Inscription inscription = new Inscription();

            //Stock dans un b
            bool verif = AllMethodes.verifChampSignin(lastname, firstname, email, password, confirmPassword, phone);

            //Condition qui vérifie si l'utilisateur à bien renseigné toutes ses informations dans les champs
            if (verif == true)
            {
                //Condition vérifiant si l'utilisateur a entrer le même mot de passe dans les champs
                if (AllMethodes.verifPassword(password, confirmPassword))
                {
                    //Condition vérifiant si un utilisateur existe déjà ou non via son email
                    if (result != null)
                    {
                        //Afficher que le compte existe déjà
                        MessageBox.Show("Already existing account !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Si la condition est remplis, alors 
                    else
                    {
                        // Hachage du mot de passe avant de l'insérer dans la base de données
                        string hashedPassword = Crypter.Blowfish.Crypt(password); // Utilisation de CryptSharp pour hacher le mot de passe

                        //afficher un message indiquant à l'utilisateur 
                        MessageBox.Show("Account created", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Hashed password : " + hashedPassword); // Affiche le mot de passe haché dans un message box
                        // Fait appel à la méthode addUser avec le mot de passe haché
                        AllMethodes.addUser(lastname, firstname, email, hashedPassword, phone); // Utilisation du mot de passe haché
                        //fait apparaitre le formulaire principale
                        main.Show();
                        //cache cette fenètre
                        this.Hide();
                    }
                }
            }
            //Si la condition n'est pas remplis
            else
            {
                //afficher une erreur
                MessageBox.Show("At least one of the fields is empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Vérifie que l'on ne peut mettre que des chiffres dans la case pour entrer son numéro de téléphone
        private void PhoneNbTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condition permettant d'empecher certain caractères d'être utilisé
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (!(e.KeyChar.Equals('.'))) && (!(e.KeyChar.Equals(','))))
            {
                e.Handled = true;
                //affiche une erreur à l'utilisateur
                MessageBox.Show("This fields can only contain numbers !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); //peut mettre des points d'arrêt pour voir ce qu'il se passe, on peut aussi faire ça avec le même MessageBox
            }

            else if (PhoneNbTxtBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Can't containt more than ten charcters !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Vérifie que l'on ne puisse pas mettre de chiffre ou de caractères spéciaux dans pour son prénom
        private void firstnameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condition permettant d'empecher l'insertion de chiffres ou de caractères spéciaux
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                //Affiche un message d'erreu à l'utilisateur
                MessageBox.Show("This fields can only contain letters !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Vérifie que l'on ne puisse pas mettre de chiffre ou de caractères spéciaux dans pour son nom
        private void lastnameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Condition permettant d'empecher l'insertion de chiffres ou de caractères spéciaux
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                //Affiche un message d'erreu à l'utilisateur
                MessageBox.Show("This fields can only contain letters !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmPswTxtBox_TextChanged(object sender, EventArgs e)
        {
            confirmPswTxtBox.Visible = true;
            confirmPswLbl.Visible = true;
        }

        private void pswTxtBox_TextChanged(object sender, EventArgs e)
        {
            confirmPswTxtBox.Visible = true;
            confirmPswLbl.Visible = true;
        }
    }
}
