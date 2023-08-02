using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebProjekat.Models;

namespace WebProjekat.Controllers
{
    public class BazaKorisnikaController : ApiController
    {
        // GET api/<controller>
        public List<Korisnik> Get()
        {
            return BazaKorisnika.ProcitajKorisnike();
        }

        // GET api/<controller>/5
        public Korisnik Get(string korisnicko_ime)
        {
            return BazaKorisnika.Korisnici[korisnicko_ime];
        }

        // POST api/<controller>
        public IHttpActionResult Post(Korisnik korisnik)
        {
            if(korisnik == null)
            {
                return BadRequest();
            }
            if(korisnik.Korisnicko_ime =="" || korisnik.Korisnicko_ime == null)
            {
                return BadRequest();
            }
            if(korisnik.Lozinka == "" || korisnik.Lozinka == null)
            {
                return BadRequest();
            }
            return Ok(BazaKorisnika.DodajKorisnika(korisnik));
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(Korisnik korisnik)
        {
            if (korisnik == null)
            {
                return BadRequest();
            }
            if (korisnik.Korisnicko_ime == "" || korisnik.Korisnicko_ime == null)
            {
                return BadRequest();
            }
            if (korisnik.Lozinka == "" || korisnik.Lozinka == null)
            {
                return BadRequest();
            }
            return Ok(BazaKorisnika.AzurirajKorisnika(korisnik));
        }

        // DELETE api/<controller>/5
        public void Delete(string korisnicko_ime)
        {
            BazaKorisnika.ObrisiKorisnika(korisnicko_ime);
        }
    }
}