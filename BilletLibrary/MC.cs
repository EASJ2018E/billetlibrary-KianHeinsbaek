﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BilletLibrary
{
    public class MC : KøretøjSuperClass
    {
        private string _nummerplade;

        /// <summary>
        /// En property med backing field, der kan sætte
        /// en begrænsning på længden af nummerpladen.
        /// Hvis nummerpladen har en karakterlængde på over 7,
        /// så vil der komme en fejlmeddelse der fortæller dette.
        /// </summary>
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

        /// <summary>
        /// En overridet metode fra KøretøjSuperClass, der angiver
        /// en billetpris for en motorcykel.
        /// </summary>
        /// <returns></returns>
        public override double Pris()
        {
            return 125;
        }

        /// <summary>
        /// En overridet metode fra KøretøjSuperClass, der angiver
        /// typen af køretøjet.
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }

        /// <summary>
        /// En overridet metode der giver 5% rabat på billetprisen,
        /// hvis man har en BroBizz.
        /// </summary>
        /// <returns></returns>
        public override double BroBizz()
        {
            return Pris() * 0.95;
        }
    }

}
