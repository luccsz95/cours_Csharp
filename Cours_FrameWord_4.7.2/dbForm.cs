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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cours_FrameWord_4._7._2
{
    public partial class dbForm : Form
    {

        string mySqlConnection = "server=127.0.0.1;uid=userdb; pwd=265656;database=insta_db";
        public dbForm()
        {
            InitializeComponent();
        }

        private void connectionBtn_Click(object sender, EventArgs e)
        {
            //Chaine de connexion
            string chaineCo = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\Desktop\\BTS\\Informatique\\newInfo\\projet\\cours_csharp\\FormE-project\\data\\InstaDB.mdf;Integrated Security=True";

            //Creer un objet de connexion
            SqlConnection conn = new SqlConnection(chaineCo);

            //Ouvre la connexion à la base de donnée
            conn.Open();

            //Affichage de l'état de connexion
            MessageBox.Show(conn.State.ToString());

            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter ?", "Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void closeDBBtn_Click(object sender, EventArgs e)
        {
            //Chaine de connexion
            string chaineCo = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\Desktop\\BTS\\Informatique\\newInfo\\projet\\cours_csharp\\FormE-project\\data\\InstaDB.mdf;Integrated Security=True";

            //Creer un objet de connexion
            SqlConnection conn = new SqlConnection(chaineCo);

            //Ferme la connexion à la base de donnée
            conn.Close();

            //Affichage de l'état de connexion
            MessageBox.Show(conn.State.ToString());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(mySqlConnection);
            cn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("GetAllEtu", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(ds, "etudiants");
            dataGridView1.DataSource = ds.Tables["etudiants"].DefaultView;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string email = textBox2.Text;
            MySqlConnection cn = new MySqlConnection(mySqlConnection);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("NewEtu", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nom", nom);
            cmd.Parameters.AddWithValue("email", email);
            cmd.ExecuteNonQuery();
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            MySqlConnection cn = new MySqlConnection(mySqlConnection);
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("nbreEtu", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nbre", MySqlDbType.Int32);
            cmd.Parameters["@nbre"].Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteScalar();
            MessageBox.Show("Nombre d'étudiants: " + Convert.ToInt32(cmd.Parameters["@nbre"].Value));
        }


        /*
         string pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
 
Regex rg = new Regex(pattern);
 
         
if (rg.IsMatch(textBox2.Text))
{
     MessageBox.Show("La chaîne correspond au motif");
}
else
{
     MessageBox.Show("La chaîne ne correspond pas au motif");
}
         */

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
