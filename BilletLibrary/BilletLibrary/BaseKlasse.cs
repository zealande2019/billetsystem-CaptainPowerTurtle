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
        public abstract string Type();

        protected void NummerPladeCheck()
        {
            if (_nummerPlade.Length < 7 )
            {
                throw new ArgumentOutOfRangeException("Nummerplade er for lang!");
            }
        }
    }
}
