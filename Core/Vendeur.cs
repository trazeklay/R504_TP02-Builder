using R504_TP02_Builder.Core.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R504_TP02_Builder.Core.Liasse;

namespace R504_TP02_Builder.Core
{
    public class Vendeur
    {
        protected ConstructeurLiasseVehicule constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        public Liasse.Liasse construit(string nomClient)
        {
            constructeur.ConstruitBonDeCommande(nomClient);
            constructeur.ConstruitDemandeImmatriculation(nomClient);

            Liasse.Liasse liasse = constructeur.Resultat;
            return liasse;
        }
    }
}
