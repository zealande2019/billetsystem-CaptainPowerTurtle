using System;

namespace OeresundBilletLibrary
{
    public class MC : BilletLibrary.BaseKlasse
    {
        /// <summary>
        /// Opretter en ny instans af <see cref="MC"/>
        /// </summary>
        public MC() { }
        /// <summary>
        /// Opretter en ny instans af <see cref="MC"/> med nummerplade og dato
        /// </summary>
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato) { }

        public override decimal RabatPris(bool brobizz = false)
        {
            return 73;
        }
        /// <summary>
        /// Hvad det koster at krydse broen
        /// </summary>
        public override decimal Pris()
        {
            return 210;
        }

        /// <summary>
        /// Hvilken type køretøj det er
        /// </summary>
        public override string Type()
        {
            return "Øresund MC";
        }
    }
}