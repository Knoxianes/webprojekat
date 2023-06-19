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
        private Porudzbina _proizvod;
        private uint _kolicina;
        private string _kupac;
        private DateTime _datumPorudzbine;
        private StatusPorudzbine _statusPorudzbine;
    }
}