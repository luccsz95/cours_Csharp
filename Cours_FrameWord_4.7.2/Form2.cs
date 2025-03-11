using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cours_FrameWord_4._7._2
{
    public partial class Form2 : Form
    {

        public static string form2username = "";
        public static string form2userpassword = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.username;
            textBox2.Text = Form1.userpassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2username = textBox1.Text;
            form2userpassword = textBox2.Text;

            this.Hide();
            Form form = new Form1();
            form.ShowDialog();
        }
    }
}
