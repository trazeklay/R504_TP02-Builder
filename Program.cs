using R504_TP02_Builder.Core.Builder;
using R504_TP02_Builder.Core.Liasse;
using R504_TP02_Builder.Core.LiasseVehicule;
using R504_TP02_Builder.Core;

ConstructeurLiasseVehicule constructeur;
Console.WriteLine("Voulez-vous construire " +
  "des liasses HTML (1) ou PDF (2) :");

string choix = Console.ReadLine();

if (choix == "1")
{
    constructeur = new ConstructeurLiasseVehiculeHtml();
}
else
{
    constructeur = new ConstructeurLiasseVehiculePdf();
}

Vendeur vendeur = new Vendeur(constructeur);
Liasse liasse = vendeur.construit("Martin");
liasse.Imprime();