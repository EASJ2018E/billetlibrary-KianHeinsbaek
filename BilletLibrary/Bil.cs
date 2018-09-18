using System;

namespace BilletLibrary
{
    public class Bil : KøretøjSuperClass
    {

        public override double Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
