using R504_TP02_Builder.Core.Builder;
using R504_TP02_Builder.Core.Liasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP02_Builder.Core.LiasseVehicule
{
    public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf()
        {
            liasse = new LiassePdf();
        }

        public override void ConstruitBonDeCommande(string nomClient)
        {
            string bonDeCommandePdf = GeneratePdfContent($"Bon de commande pour le client: {nomClient}");
            liasse.AjouteDocument(bonDeCommandePdf);
        }

        public override void ConstruitDemandeImmatriculation(string nomDemandeur)
        {
            string demandeImmatriculationPdf = GeneratePdfContent($"Demande d'immatriculation pour: {nomDemandeur}");
            liasse.AjouteDocument(demandeImmatriculationPdf);
        }

        private string GeneratePdfContent(string content)
        {
            // Simulate PDF content generation
            // In reality, this would involve using a PDF library to generate actual PDF content
            return $"<PDF>{content}</PDF>";
        }
    }
}
