using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_proejct_F_4_7_2
{
    public partial class FormCombo : Form
    {
        public FormCombo()
        {
            InitializeComponent();
        }

        private void comboBoxuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxuser.DataSource = AllMethodes.loadUser();
            comboBoxuser.ValueMember = "id_user";
            comboBoxuser.DisplayMember = "FirstNameUser";

            comboBoxuser.SelectedValue.ToString();
        }
    }
}
