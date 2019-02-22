using System;

namespace BilletLibrary
{
    public class Bil : BaseKlasse
    {
        //I disse datafields, opretter vi henholdsvids en string til NummerPlade, og en DateTime til Dato
        public string VisNummerplade()
        {
            return NummerPlade;
        }

        public DateTime ShowDato()
        {
            return Dato;
        }

        //Her sætter vi prisen for hvad det vil koste for en bil
        public decimal SetPrice()
        {
            _pris = 240;
            return _pris;
        }

        //Her retunere vi typen af køretøj, i det tilfælde en bil.
        public string SetKøretøj()
        {
            _køretøjType = "Bil";
            return _køretøjType;
        }
    }
}
