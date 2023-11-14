using R504_TP02_Builder.Core.Builder;
using R504_TP02_Builder.Core.Liasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP02_Builder.Core.LiasseVehicule
{
    public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            liasse = new LiasseHtml();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string document = "<HTML> Bon de commande Client: " + nomClient + " </HTML>";
            liasse.AjouteDocument(document);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<HTML> Demande d'immatriculation Demandeur: " + nomDemandeur + " </HTML>";
            liasse.AjouteDocument(document);
        }
    }
}
