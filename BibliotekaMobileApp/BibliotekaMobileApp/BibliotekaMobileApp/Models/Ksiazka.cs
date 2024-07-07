using System;
using System.Collections.Generic;
using System.Text;

    namespace BibliotekaMobileApp.Models
    {
        public class Ksiazka
        {
            public int KsiazkaId { get; set; }
            public string Tytul { get; set; }
            public int WydawcaId { get; set; }
            public Wydawca Wydawca { get; set; }
            public int KategoriaId { get; set; }
            public Kategoria Kategoria { get; set; }
        }
    }

