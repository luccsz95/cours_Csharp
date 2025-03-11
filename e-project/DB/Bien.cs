using System.Diagnostics;
using System;

namespace projet_e_commerce {
    public class Bien {
        //public string type; //Maison ou appart
        //public string typeVente; //vente ou location
        //public double prixLocation;
        //private string type; useless, car on ne va pas choisir le type maison et typeVente appart xD
        private string typeVente;
        private double prixLocation;
        public double prixVente;
        public double terrain;
        public int annneeConstruction;
        public int piece;
        public int? chambre; //peut accepter une valeur null



        //opérateur : patron de la plateform, il aura accet à tout
        //vendeur : ne peut que vendre
        //

        

        public Bien() {

        }
        public Bien(string type, string typeVente, double prixLocation) {
            //this.type = type;
            this.typeVente = typeVente;
            this.prixLocation = prixLocation;
        }

        /*public Article(string type, string typeVente, double prixVente, double terrain, int annneeConstruction, int piece, int chambre) {
            this.type = type;
            this.typeVente = typeVente;
            this.prixVente = prixVente;
            this.prixLocation = prixLocation;
            this.terrain = terrain;
            this.annneeConstruction = annneeConstruction;
            this.piece = piece;
            this.chambre = chambre;
        }*/
        

        public void createArticle() {

        }

        public void updateArticle() {

        }

        public void deleteArticle() {

        }

        public string getTypeVente
        {
            get { return typeVente; }
        }
        
        public string setTypeVente {
            set { 
                if (value != null) {
                    typeVente = value;
                }
                else { Console.WriteLine("Impossible d'assigner une valeur nulle au type de vente"); }
            }
        }
        
        /*public string setTypeVente() {
            return typeVente = "";
        }

        public string setType() {
            return type;
        }

        public double setPrixLocation() {
            return prixLocation;
        }*/
    }
}