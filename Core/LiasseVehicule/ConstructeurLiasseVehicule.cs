using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R504_TP02_Builder.Core.Liasse;

namespace R504_TP02_Builder.Core.Builder
{
    public abstract class ConstructeurLiasseVehicule
    {
        protected Liasse.Liasse liasse;

        public abstract void ConstruitBonDeCommande(string nomClient);
        public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);

        public Liasse.Liasse Resultat
        {
            get { return liasse; }
        }
    }
}
