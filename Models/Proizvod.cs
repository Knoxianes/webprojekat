﻿using System;
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
        private string _korisnicko_ime;

        private List<Recenzija> _listaRecenzija;

        public Proizvod(string naziv, double cena, uint kolicina, string opis, string slika, string grad,string korisnicko_ime)
        {
            _naziv = naziv;
            _cena = cena;
            _kolicina = kolicina;
            _opis = opis;
            _slika = slika;
            _grad = grad;
            _korisnicko_ime = korisnicko_ime;
            Objavljen = DateTime.Now;
            if(kolicina <= 0)
            {
                StatusProizvoda = StatusProizvoda.NEDOSTUPAN;
            }
            else
            {
                StatusProizvoda = StatusProizvoda.DOSTPAN;
            }
            ListaRecenzija = new List<Recenzija>();
        }

        public string Naziv { get => _naziv; set => _naziv = value; }
        public double Cena { get => _cena; set => _cena = value; }
        public uint Kolicina { get => _kolicina; set => _kolicina = value; }
        public string Opis { get => _opis; set => _opis = value; }
        public string Slika { get => _slika; set => _slika = value; }
        public DateTime Objavljen { get => _objavljen; set => _objavljen = value; }
        public string Grad { get => _grad; set => _grad = value; }
        public StatusProizvoda StatusProizvoda { get => _statusProizvoda; set => _statusProizvoda = value; }
        public List<Recenzija> ListaRecenzija { get => _listaRecenzija; set => _listaRecenzija = value; }
        public string Korisnicko_ime { get => _korisnicko_ime; set => _korisnicko_ime = value; }
    }
}