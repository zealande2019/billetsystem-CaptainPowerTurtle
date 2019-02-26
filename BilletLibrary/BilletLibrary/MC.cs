using System;

namespace BilletLibrary
{
    /// <summary>
    /// Enb specifik klasse, som arver fra baseklassen, i dette tilføje repræsenter denne klasse motorcykler
    /// </summary>
    public class MC : BaseKlasse
    {

        /// <summary>
        /// Opretter en ny instans af <see cref="MC"/>
        /// </summary>
        public MC() { }
        /// <summary>
        /// Opretter en ny instans af <see cref="MC"/> med nummerplade og dato
        /// </summary>
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato) { }
        /// <summary>
        /// Hvad det koster at krydse broen
        /// </summary>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Hvilken type køretøj det er
        /// </summary>
        public override string Type()
        {
            return "Motorcykel";
        }
    }
}