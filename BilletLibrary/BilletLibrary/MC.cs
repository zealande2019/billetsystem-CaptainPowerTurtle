using System;

namespace BilletLibrary
{
    public class MC : BaseKlasse
    {
        //I disse datafields, opretter vi henholdsvids en string til NummerPlade, og en DateTime til Dato.
        public string VisNummerplade()
        {
            return NummerPlade;
        }

        public DateTime ShowDato()
        {
            return Dato;
        }

        //Her sætter vi prisen for hvad det vil koste for en motorcykel.
        public decimal SetPrice()
        {
            _pris = 125;
            return _pris;
        }

        //Her retunere vi typen af køretøj, i det tilfælde en motorcykel.
        public string SetKøretøj()
        {
            _køretøjType = "Motorcykel";
            return _køretøjType;
        }
    }
}