using System;
using System.Reflection.Metadata;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class Bil : BilletLibrary.Bil
    {
        /// <summary>
        /// Opretter en ny instans af. <see cref="Bil"/>
        /// </summary>
        public Bil() { }
        /// <summary>
        /// Opretter en ny instans af <see cref="Bil"/> med nummerplade og dato
        /// </summary>
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato) { }

        public override decimal Pris()
        {
            decimal pris = base.Pris();
            if (base.Dato.DayOfWeek == DayOfWeek.Saturday || base.Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                pris = (pris * 0.20M) - base.RabatPris(true);
            }

            return Pris() - pris;
        }
    }
}
