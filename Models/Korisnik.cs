using System;
using System.Collections.Generic;
using System.Web;

namespace WebProjekat.Models
{
    public enum  Pol{
        
        MUSKI,
        ZENSKI,
        SREDNJI
    }
    public enum Uloga
    {
        KUPAC,
        PRODAVAC,
        ADMINISTRATOR
    }
    public class Korisnik
    {
        private string _korisnicko_ime;
        private string _lozinka;
        private string _ime;
        private string _prezime;
        private Pol _pol;
        private string _email;
        private DateTime _rodjendan;
        private Uloga _uloga;
        private List<Proizvod> _listaPorudzbina;
        private List<Porudzbina> _listaOmiljenihProizvoda;
        private List<Porudzbina> _listaObjavljenihProzivoda;

        public Korisnik(string korisnicko_ime, string lozinka, string ime, string prezime, Pol pol, string email, DateTime rodjendan, Uloga uloga)
        {
            _korisnicko_ime = korisnicko_ime;
            _lozinka = lozinka;
            _ime = ime;
            _prezime = prezime;
            _pol = pol;
            _email = email;
            _rodjendan = rodjendan;
            _uloga = uloga;
        }

        public string Korisnicko_ime { get => _korisnicko_ime; set => _korisnicko_ime = value; }
        public string Lozinka { get => _lozinka; set => _lozinka = value; }
        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        public Pol Pol { get => _pol; set => _pol = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Rodjendan { get => _rodjendan; set => _rodjendan = value; }
        public Uloga Uloga { get => _uloga; set => _uloga = value; }
        public List<Proizvod> ListaPorudzbina { 
            get
            {
                if(this.Uloga == Uloga.KUPAC)
                {
                    return _listaPorudzbina;
                }
                else
                {
                    return null;
                }
            } 
            set => _listaPorudzbina = value; 
        }
        public List<Porudzbina> ListaOmiljenihProizvoda 
        {
            get 
            { 
                if(Uloga == Uloga.KUPAC)

                {
                    return _listaOmiljenihProizvoda;
                }
                else
                {
                    return null;
                }            
            }
            set => _listaOmiljenihProizvoda = value;
        }
        public List<Porudzbina> ListaObjavljenihProzivoda 
        { 
            get
            {
                if(Uloga == Uloga.PRODAVAC)
                {
                    return _listaObjavljenihProzivoda;
                }
                else
                {
                    return null;
                }
            }
          set => _listaObjavljenihProzivoda = value;
        }
    }
}