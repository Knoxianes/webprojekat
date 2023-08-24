using System;
using System.Collections.Generic;
using System.Web;

namespace WebProjekat.Models
{
    public enum  Pol{
        
        MUSKI,
        ZENSKI
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
        private List<Porudzbina> _listaPorudzbina;
        private List<Proizvod> _listaOmiljenihProizvoda;
        private List<Proizvod> _listaObjavljenihProizvoda;

        public Korisnik(string korisnicko_ime, string lozinka, string ime, string prezime, Pol pol, string email, DateTime rodjendan, Uloga uloga)
        {
            Korisnicko_ime = korisnicko_ime;
            Lozinka = lozinka;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            Email = email;
            Rodjendan = rodjendan;
            Uloga = uloga;
            ListaOmiljenihProizvoda = new List<Proizvod>();
            ListaPorudzbina = new List<Porudzbina>();
            ListaObjavljenihProizvoda = new List<Proizvod>();
        }

        public string Korisnicko_ime { get => _korisnicko_ime; set => _korisnicko_ime = value; }
        public string Lozinka { get => _lozinka; set => _lozinka = value; }
        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        public Pol Pol { get => _pol; set => _pol = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Rodjendan { get => _rodjendan; set => _rodjendan = value; }
        public Uloga Uloga { get => _uloga; set => _uloga = value; }
        public List<Porudzbina> ListaPorudzbina { 
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
        public List<Proizvod> ListaOmiljenihProizvoda 
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
        public List<Proizvod> ListaObjavljenihProizvoda 
        { 
            get
            {
                if(Uloga == Uloga.PRODAVAC)
                {
                    return _listaObjavljenihProizvoda;
                }
                else
                {
                    return null;
                }
            }
          set => _listaObjavljenihProizvoda = value;
        }
    }
}