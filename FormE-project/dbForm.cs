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


namespace FormE_project
{
    public partial class dbForm : Form
    {
        public dbForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chaineCo = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lucas\\Desktop\\BTS\\Informatique\\newInfo\\projet\\cours_csharp\\FormE-project\\data\\InstaDB.mdf;Integrated Security=True";

            /*SqlConnection conn = new SqlConnection(chaineCo);
            
            conn.Open();
            MessageBox.Show(conn.State.ToString());*/
        }
    }
}
