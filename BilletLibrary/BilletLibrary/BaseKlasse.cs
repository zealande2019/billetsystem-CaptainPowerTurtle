using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class BaseKlasse
    {
        protected string NummerPlade;
        protected DateTime Dato;
        protected decimal _pris;
        protected string _køretøjType;

        protected void Pris(Decimal bPris)
        {
            _pris = bPris;
        }
        protected void Køretøjtype(String bKøretøjType)
        {
            _køretøjType = bKøretøjType;
        }

        protected void NummerPladeCheck()
        {
            if (NummerPlade.Length < 7 )
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
