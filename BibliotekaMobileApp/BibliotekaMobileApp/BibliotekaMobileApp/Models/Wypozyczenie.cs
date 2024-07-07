using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotekaMobileApp.Models
{
    public class Wypozyczenie
    {
        public int WypozyczenieId { get; set; }
        public int KsiazkaId { get; set; }
        public Ksiazka Ksiazka { get; set; }
        public int CzłonekId { get; set; }
        public Członek Członek { get; set; }
        public DateTime DataWypozyczenia { get; set; }
        public DateTime? DataZwrotu { get; set; }
    }
}
