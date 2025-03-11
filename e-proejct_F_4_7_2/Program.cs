using e_proejct_F_4_7_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours_FrameWord_4._7._2 {
    internal static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new dbForm());
            //Application.Run(new Main());
            //Application.Run(new FormAuthent());
            //Application.Run(new FormAnimals());
            //Application.Run(new FormCheckUser());
            //Application.Run(new FormCombo());
            //Application.Run(new FormUpdateUser());
            Application.Run(new Inscription());
        }
    }
}
