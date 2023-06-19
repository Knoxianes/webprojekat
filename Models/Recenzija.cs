using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models
{
    public class Recenzija
    {
        private Porudzbina _proizvod;
        private string _recenzent;
        private string _naslov;
        private string _sadrzaj;
        private string _slika;

        public Recenzija(Porudzbina proizvod, string recenzent, string naslov, string sadrzaj, string slika)
        {
            _proizvod = proizvod;
            _recenzent = recenzent;
            _naslov = naslov;
            _sadrzaj = sadrzaj;
            _slika = slika;
        }

        public Porudzbina Proizvod { get => _proizvod; set => _proizvod = value; }
        public string Recenzent { get => _recenzent; set => _recenzent = value; }
        public string Naslov { get => _naslov; set => _naslov = value; }
        public string Sadrzaj { get => _sadrzaj; set => _sadrzaj = value; }
        public string Slika { get => _slika; set => _slika = value; }
    }
}