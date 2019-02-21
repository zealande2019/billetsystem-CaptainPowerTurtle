using System;

namespace BilletLibrary
{
    public class Bil
    {
        //I disse datafields, opretter vi henholdsvids en string til NummerPlade, og en DateTime til Dato
        public string NummerPlade;
        public DateTime Dato;

        //Her sætter vi prisen for hvad det vil koste for en bil
        public decimal Pris()
        {
            return 240;
        }

        //Her retunere vi typen af køretøj, i det tilfælde en bil.
        public string Køretøj()
        {
            return "Bil";
        }
    }
}
