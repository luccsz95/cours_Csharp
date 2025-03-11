using System;
namespace projet_e_commerce {
    public class Client {
        //attribu
        public string lastname;
        public string firstname;
        public string email;
        private string password;
        public string role; //s'il est vendeur ou acheteur
        public string RCS; //Id d'entreprise ? <--- a voir pour le e-commerce, fait parti du SIRET <--- tjrs à voir ce que c'est (le prof dit string)
        

        //constructeur
        /*public Client (string lastname, string firstname, string email) {
            this.lastname = lastname;
            this.firstname = firstname;
            this.email = email;
        }*/

        //constructeur à vide
        public Client () {

        }

        //methodes
        //methodes qui permet d'ajouter un nouveau client
        public void addClient() {
     
        }

        public void modifyClient() {

        }

        public void deleteClient() {

        }

        //avec 
        /*public string getPassword() {
            return password; 
        }*/
        
        public string getTypeVente {
            get { return password; }
        }
    }
}