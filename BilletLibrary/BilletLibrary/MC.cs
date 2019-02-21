using System;

namespace BilletLibrary
{
    public class MC
    {
        //I disse datafields, opretter vi henholdsvids en string til NummerPlade, og en DateTime til Dato.
        public string NummerPlade;
        public DateTime Dato;

        //Her sætter vi prisen for hvad det vil koste for en motorcykel.
        public decimal Pris()
        {
            return 125;
        }

        //Her retunere vi typen af køretøj, i det tilfælde en motorcykel.
        public string Køretøj()
        {
            return "Motorcykel";
        }
    }
}