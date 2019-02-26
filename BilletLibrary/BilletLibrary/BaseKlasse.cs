using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Dette er en baseklasse, som indholder generelle ting for en bil som skal betale broafgift
    /// </summary>
    public abstract class BaseKlasse
    {
        private string _nummerplade;

        /// <summary>
        /// Opretter en ny instans af <see cref="BaseKlasse"/> klassen
        /// </summary>
        public BaseKlasse() { }

        /// <summary>
        /// Opretter en ny instans af <see cref="BaseKlasse"/> klassen med en nummerplade og en dato
        /// </summary>
        public BaseKlasse(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        /// <summary>
        /// Et køretøjs nummerplade
        /// </summary>
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
        /// <summary>
        /// Hvor meget det koster at kryde broen med rabat hvis man har brobizz
        /// </summary>
        public virtual decimal RabatPris(bool brobizz = false)
        {
            decimal rabat = 0;
            if (brobizz)
            {
                rabat = Pris() * 0.05M;
            }
            return Pris() - rabat;
        }
        /// <summary>
        /// Hvilken dato køretøjet har krydset broen
        /// </summary>
        public DateTime Dato { get; set; }
        /// <summary>
        /// Hvilken type køretøj det er
        /// </summary>
        public abstract string Type();
        /// <summary>
        /// Standard prisen for at krydse broen
        /// </summary>
        public abstract decimal Pris();
    }
}
