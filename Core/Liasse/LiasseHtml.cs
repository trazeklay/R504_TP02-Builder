using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP02_Builder.Core.Liasse
{
    public class LiasseHtml : Liasse
    {
        public override void AjouteDocument(string document)
        {
            if (document.StartsWith("<HTML>"))
            {
                contenu.Add(document);
            }
        }

        public override void Imprime()
        {
            foreach (string s in contenu)
            {
                Console.WriteLine(s);
            }
        }
    }
}
