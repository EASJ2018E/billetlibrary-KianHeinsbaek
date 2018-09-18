using System;

namespace BilletLibrary
{
    public class Bil : KøretøjSuperClass
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
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }


        public override double BroBizz()
        {
            return Pris() * 0.95;
        }
    }
}
