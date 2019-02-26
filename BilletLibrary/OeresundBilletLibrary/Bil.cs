using System;
using BilletLibrary;

namespace OeresundBilletLibrary
{
    public class Bil : BilletLibrary.BaseKlasse
    {
        /// <summary>
        /// Opretter en ny instans af <see cref="Bil"/>
        /// </summary>
        public Bil() { }
        /// <summary>
        /// Opretter en ny instans af <see cref="Bil"/> med nummerplade og dato
        /// </summary>
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato) { }

        public override decimal RabatPris(bool brobizz = false)
        {
            return 161;
        }
        /// <summary>
        /// Hvad det koster at krydse broen
        /// </summary>
        public override decimal Pris()
        {
            return 410;
        }

        /// <summary>
        /// Hvilken type køretøj det er
        /// </summary>
        public override string Type()
        {
            return "Øresund Bil";
        }
    }
}
