
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours_FrameWord_4._7._2
{
    public partial class Form1 : Form
    {

        public static string username ="";
        public static string userpassword ="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            userpassword = textBox2.Text;
            this.Hide();
            Form form = new Form2();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.form2username;
            textBox2.Text = Form2.form2userpassword;
        }
    }
}
