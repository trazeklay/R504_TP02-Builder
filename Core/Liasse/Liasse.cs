﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP02_Builder.Core.Liasse
{
    public abstract class Liasse
    {
        protected IList<string> contenu = new List<string>();

        public abstract void AjouteDocument(string document);
        public abstract void Imprime();
    }
}
