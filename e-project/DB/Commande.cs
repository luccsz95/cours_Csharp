namespace projet_e_commerce {
    public class Commande {
        public string idCommande;
        public string typeCommande; //Si maison ou appart
        public string typeVenteCommande; //Si vente ou location
        public string libelle;

        //constructeur
        public Commande()
        {
        
        }

        public Commande(string idCommande, string typeCommande, string typeVenteCommande, string libelle)
        {
            this.idCommande = idCommande;
            this.typeCommande = typeCommande;
            this.typeVenteCommande = typeVenteCommande;
            this.libelle = libelle;
        }

        public void createCommand() { 

        }

        public void updateCommand() {

        }

        public void deleteCommand() {

        }
    }
}