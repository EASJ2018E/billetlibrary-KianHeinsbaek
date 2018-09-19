using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class KøretøjSuperClass
    {
        public virtual string Nummerplade { get; set; }
        public virtual DateTime Dato { get; set; }

        /// <summary>
        /// En metode der giver prisen på en billet.
        /// Prisen varierer fra hvert køretøj, derfor er metoden abstract,
        /// så den kan overrides i den nedarvede klasse.
        /// </summary>
        /// <returns></returns>
        public abstract double Pris();

        /// <summary>
        /// En metoder der viser hvilket køretøj der er tale om.
        /// Typen af køretøj varierer, derfor er metoden abstract,
        /// så den kan overrides i den nedarvede klasse.
        /// </summary>
        /// <returns></returns>
        public abstract string Køretøj();

        /// <summary>
        /// En metode der giver rabat på billetprisen, når man har en BroBizz.
        /// Prisen varierer, derfor er metoden lavet abstract, så den kan ændres
        /// i den nedarvede klasse.
        /// </summary>
        /// <returns></returns>
        public abstract double BroBizz();
    }
}
