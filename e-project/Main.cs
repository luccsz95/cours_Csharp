﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBien propretyForm = new FormBien();
            propretyForm.Show();
        }
    }
}
