using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class KøretøjSuperClass
    {
        public virtual string Nummerplade { get; set; }
        public virtual DateTime Dato { get; set; }

        public abstract double Pris();

        public abstract string Køretøj();

        public abstract double BroBizz();
    }
}
