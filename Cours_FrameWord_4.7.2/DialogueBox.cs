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
    public partial class DialogueBox : Form
    {
        public DialogueBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //varriable string affichant du texte dans la MessageBox
            string message = " MessageBox Simple";

            //affiche le message
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //varriable string affichant du texte dans la MessageBox
            string message = "MessageBox Simple";

            //varriable string affichant un titre en haut à droite de la MessageBox
            string titre = "Titre";

            //affiche le message
            MessageBox.Show(message, titre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //varriable string affichant du texte
            string message3 = "MessageBox avec boutons Une MessageBox peut avoir différentes combinaisons de boutons,\r\n            telles que YesNo et OKCancel.L’énumération MessageBoxButtons\r\n           représente les boutons à afficher sur une MessageBox et comporte les valeurs suivantes.\r\n\r\n           OK\r\n           OKCancel\r\n          AbortRetryIgnorer\r\n         OuiNonAnnuler\r\n          OuiNon\r\n          RéessayerAnnuler\r\n\r\n           L’extrait de code suivant crée une MessageBox avec un titre et des boutons Oui et Non.\r\n        Il s’agit d’une MessageBox typique que vous pouvez appeler\r\n       lorsque vous souhaitez fermer une application.Si vous cliquez sur le bouton Oui,\r\n          l’application sera fermée.La méthode Show renvoie une énumération DialogResult.";

            //varriable string affichant du texte
            string message = "Voulez-vous fermer?";

            //varriable string affichant un titre en haut à droite de la MessageBox
            string title = "Fermer";

            //va stocker dans une variable buttons des boutons et les afficher
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //stocker un DialogueResult dans une variable result contenant, un message, un titre
            //et les boutons 
            DialogResult result = MessageBox.Show(message, title, buttons);

            //Condition pour le Oui et pour le Non
            //Si oui, alors fermer la page
            //Si non, alors ouvrir le message 3
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(message3);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Un MessageBox peut afficher une icône dans la boîte de dialogue.
    Une énumération MessageBoxIcons représente une icône à afficher sur un MessageBox
   et possède les valeurs suivantes.
 
              -Aucun
              - Main
              -Question
             - Exclamation
             -Astérisque
              - Arrêter
               -Erreur
               - Avertissement
               -Information
               */

            ////L’extrait de code suivant crée une MessageBox avec un titre, des boutons et une icône.

            string message4 = "Un MessageBox peut afficher une icône dans la boîte de dialogue.\r\n Une énumération MessageBoxIcons représente une icône à afficher sur un MessageBox\r\net possède les valeurs suivantes.\r\n\r\n           -Aucun\r\n           - Main\r\n           -Question\r\n          - Exclamation\r\n          -Astérisque\r\n           - Arrêter\r\n            -Erreur\r\n            - Avertissement\r\n            -Information\r\n            ";

            string message = "Voulez-vous abandonner cette opération?";
            string title = "Fermer";
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.Abort) {
                this.Close();
            }

            if (result == DialogResult.Retry) {
                MessageBox.Show(message4);
            }

            else {
                // instructions
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox avec bouton par défaut
            //Nous pouvons également définir le bouton par défaut sur une MessageBox.
            //Par défaut, le premier bouton est le bouton par défaut.
            //L’énumération MessageBoxDefaultButton est utilisée à cette fin et comporte
            //les trois valeurs suivantes.

            //Bouton1
            //Bouton2
            //Bouton3
            //L’extrait de code suivant crée une MessageBox avec un titre,
            //des boutons et une icône, puis définit le deuxième bouton comme bouton par défaut.


            string message = "Voulez-vous abandonner cette opération?";
            string title = "Fermer";
            MessageBoxButtons bouton = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, bouton, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            if (result == DialogResult.Retry)
            {
                // Do nothing
                string message2 = "//Nous pouvons également définir le bouton par défaut sur une MessageBox.\r\n//Par défaut, le premier bouton est le bouton par défaut.\r\n//L’énumération MessageBoxDefaultButton est utilisée à cette fin et comporte\r\n//les trois valeurs suivantes.\r\n\r\n    //Bouton1\r\n    //Bouton2\r\n    //Bouton3\r\n    //L’extrait de code suivant crée une MessageBox avec un titre,\r\n    //des boutons et une icône, puis définit le deuxième bouton comme bouton par défaut.\";";
                MessageBox.Show(message2);
            }
            else
            {
                // instructions
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // MessageBox avec bouton d’aide Une MessageBox peut avoir
            //un bouton supplémentaire appelé bouton Aide.
            //Ceci est utile lorsque nous avons besoin d’afficher un fichier d’aide.
            //L’extrait de code suivant crée une MessageBox avec un bouton Aide.
            string message = "Voulez-vous abandonner cette opération?";
            string title = "Fermer";
            MessageBoxButtons bouton = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, bouton, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,MessageBoxOptions.RightAlign, true);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Nous pouvons également spécifier un fichier d’aide
            //lorsque vous cliquez sur le bouton Aide.
            //L’extrait de code suivant fait référence à un fichier d’aide.
            string message = "Voulez-vous abandonner cette opération?";
            string title = "Fermer";
            MessageBoxButtons bouton = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, bouton, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, "helpfile.chm");
        }
    }
}
