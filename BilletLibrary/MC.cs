using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : KøretøjSuperClass
    {
        public override double Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
