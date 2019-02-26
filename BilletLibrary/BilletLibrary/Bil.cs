using System;

namespace BilletLibrary
{
    public class Bil : BaseKlasse
    {
        //Her sætter vi prisen for hvad det vil koste for en bil.
        public override decimal Pris()
        {
            return 240;
        }

        //Her retunere vi typen af køretøj, i det tilfælde en bil.
        public override string Type()
        {
            return "Bil";
        }
    }
}
