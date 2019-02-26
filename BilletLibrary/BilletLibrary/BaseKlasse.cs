using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class BaseKlasse
    {
        protected string _nummerPlade;
        protected DateTime _dato;
        public abstract decimal Pris();
        public virtual decimal RabatPris(bool brobizz = false)
        {
            decimal rabat = 0;
            if (brobizz)
            {
                rabat = Pris() * 0.05M;
            }
            return Pris() - rabat;
        }
        public abstract string Type();

        protected void NummerPlade()
        {
            if (_nummerPlade.Length < 7 )
            {
                throw new ArgumentOutOfRangeException("Nummerplade er for lang!");
            }
        }
    }
}
