﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours_FrameWord_4._7._2
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dbForm());
            //Application.Run(new dgvRightClickCtrl());
            //Application.Run(new MySQLForm());
            //Application.Run(new DialogueBox());
            //Application.Run(new Form1());
            
        }
    }
}
