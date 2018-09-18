using System;

namespace BilletLibrary
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public double Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}
