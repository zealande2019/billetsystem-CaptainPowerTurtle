using System;

namespace BilletLibrary
{
    public class Bil : BaseKlasse
    {
        /// <summary>
        /// Opretter en ny instans af <see cref="Bil"/>
        /// </summary>
        public Bil() { }
        /// <summary>
        /// Opretter en ny instans af <see cref="Bil"/> med nummerplade og dato
        /// </summary>
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato) { }
        /// <summary>
        /// Hvad det koster at krydse broen
        /// </summary>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Hvilken type køretøj det er
        /// </summary>
        public override string Type()
        {
            return "Bil";
        }
    }
}
