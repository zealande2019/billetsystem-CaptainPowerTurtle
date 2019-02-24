using System;

namespace BilletLibrary
{
    public class MC : BaseKlasse
    {
        //I disse datafields, opretter vi henholdsvids en string til NummerPlade, og en DateTime til Dato.
        public string Nummerplade()
        {
            return _nummerPlade;
        }

        public DateTime Dato()
        {
            return _dato;
        }

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