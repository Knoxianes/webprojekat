using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models
{
    public class Recenzija
    {
        private string _recenzent;
        private string _naslov;
        private string _sadrzaj;
        private string _slika;

        public Recenzija( string recenzent, string naslov, string sadrzaj, string slika)
        {
            _recenzent = recenzent;
            _naslov = naslov;
            _sadrzaj = sadrzaj;
            _slika = slika;
        }

        public string Recenzent { get => _recenzent; set => _recenzent = value; }
        public string Naslov { get => _naslov; set => _naslov = value; }
        public string Sadrzaj { get => _sadrzaj; set => _sadrzaj = value; }
        public string Slika { get => _slika; set => _slika = value; }
    }
}