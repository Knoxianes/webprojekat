using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models
{
    public enum StatusProizvoda
    {
        DOSTPAN,
        NEDOSTUPAN
    }
    public class Proizvod
    {
        private string _naziv;
        private double _cena;
        private uint _kolicina;
        private string _opis;
        private string _slika;
        private DateTime _objavljen;
        private string _grad;
        private StatusProizvoda _statusProizvoda;

        private List<Recenzija> _listaRecenzije;

        public Proizvod(string naziv, double cena, uint kolicina, string opis, string slika, DateTime objavljen, string grad, StatusProizvoda status)
        {
            _naziv = naziv;
            _cena = cena;
            _kolicina = kolicina;
            _opis = opis;
            _slika = slika;
            _objavljen = objavljen;
            _grad = grad;
            _statusProizvoda = status;
            ListaRecenzije = new List<Recenzija>();
        }

        public string Naziv { get => _naziv; set => _naziv = value; }
        public double Cena { get => _cena; set => _cena = value; }
        public uint Kolicina { get => _kolicina; set => _kolicina = value; }
        public string Opis { get => _opis; set => _opis = value; }
        public string Slika { get => _slika; set => _slika = value; }
        public DateTime Objavljen { get => _objavljen; set => _objavljen = value; }
        public string Grad { get => _grad; set => _grad = value; }
        public StatusProizvoda StatusProzivoda { get => _statusProizvoda; set => _statusProizvoda = value; }
        public List<Recenzija> ListaRecenzije { get => _listaRecenzije; set => _listaRecenzije = value; }
    }
}