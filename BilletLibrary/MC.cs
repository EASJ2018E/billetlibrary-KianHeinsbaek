using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : KøretøjSuperClass
    {
        private string _nummerplade;

        public string Nummerplade
        {
            get { return _nummerplade; }

            set
            {
                if (value.Length < 8)
                {
                    _nummerplade = value;
                }
                else
                {
                    throw new ArgumentException("Nummerpladen må højst indeholde 7 tegn.");
                }
            }
        }

        public DateTime Dato { get; set; }
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
