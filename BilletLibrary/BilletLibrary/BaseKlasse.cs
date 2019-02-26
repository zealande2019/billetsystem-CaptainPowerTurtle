using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BilletLibrary
{
    public abstract class BaseKlasse
    {
        private string _nummerplade;

        public BaseKlasse() { }

        public BaseKlasse(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }
        public string Nummerplade
        {
            get { return _nummerplade;}
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("Nummerplade kan ikke være længere end 7 tegn.");
                _nummerplade = value;
            }
        }
        public virtual decimal RabatPris(bool brobizz = false)
        {
            decimal rabat = 0;
            if (brobizz)
            {
                rabat = Pris() * 0.05M;
            }
            return Pris() - rabat;
        }
        public DateTime Dato { get; set; }

        public abstract string Type();
        public abstract decimal Pris();
    }
}
