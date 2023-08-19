using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models
{
    public enum StatusPorudzbine
    {
        AKTIVAN,
        IZVRSEN,
        OTKAZAN
    }
    public class Porudzbina
    {
        private Proizvod _proizvod;
        private uint _kolicina;
        private string _kupac;
        private DateTime _datumPorudzbine;
        private StatusPorudzbine _statusPorudzbine;

        public Porudzbina(Proizvod prozivod, uint kolicina, string kupac, DateTime datumPorudzbine, StatusPorudzbine statusPorudzbine)
        {
            _proizvod = prozivod;
            _kolicina = kolicina;
            _kupac = kupac;
            _datumPorudzbine = datumPorudzbine;
            _statusPorudzbine = statusPorudzbine;
        }

        public Proizvod Proizvod { get => _proizvod; set => _proizvod = value; }
        public uint Kolicina { get => _kolicina; set => _kolicina = value; }
        public string Kupac { get => _kupac; set => _kupac = value; }
        public DateTime DatumPorudzbine { get => _datumPorudzbine; set => _datumPorudzbine = value; }
        public StatusPorudzbine StatusPorudzbine { get => _statusPorudzbine; set => _statusPorudzbine = value; }
    }
}