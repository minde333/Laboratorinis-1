using System;

namespace L1_U1_11
{
    /// <summary>
    /// Klasė, skirta žiedų duomenų saugojimui
    /// </summary>
    class Ziedas
    {
        public string Gamintojas { get; set; }
        public string Pavadinimas { get; set; }
        public string Metalas { get; set; }
        public double Svoris { get; set; }
        public double Dydis { get; set; }
        public int Praba { get; set; }
        public double Kaina { get; set; }

        /// <summary>
        /// Numatytasis konstruktorius
        /// </summary>
        public Ziedas()
        {
        }

        /// <summary>
        /// Parametrų konstruktorius
        /// </summary>
        /// <param name="gamintojas"></param>
        /// <param name="pavadinimas"></param>
        /// <param name="metalas"></param>
        /// <param name="svoris"></param>
        /// <param name="dydis"></param>
        /// <param name="praba"></param>
        /// <param name="kaina"></param>
        public Ziedas(string gamintojas, string pavadinimas, string metalas, double svoris, double dydis, int praba, double kaina)
        {
            Gamintojas = gamintojas;
            Pavadinimas = pavadinimas;
            Metalas = metalas;
            Svoris = svoris;
            Dydis = dydis;
            Praba = praba;
            Kaina = kaina;
        }
    }
}
