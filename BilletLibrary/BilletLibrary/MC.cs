using System;

namespace BilletLibrary
{
    public class MC : BaseKlasse
    {
        public MC() { }
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato) { }
        //Her sætter vi prisen for hvad det vil koste for en motorcykel.
        public override decimal Pris()
        {
            return 125;
        }

        //Her retunere vi typen af køretøj, i det tilfælde en motorcykel.
        public override string Type()
        {
            return "Motorcykel";
        }
    }
}