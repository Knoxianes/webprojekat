using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebProjekat.Models;

namespace WebProjekat.Controllers
{
    public class BazaProizvodaController : ApiController
    {
        public List<Proizvod> Get()
        {
            return BazaProizvoda.ProcitajProizvode();
        }

        // GET api/<controller>/5
        public Proizvod Get(string naziv)
        {
            return BazaProizvoda.Proizvodi[naziv];
        }

        // POST api/<controller>
        public IHttpActionResult Post(Proizvod proizvod)
        {
            if(proizvod == null)
            {
                return BadRequest();
            }
            if(proizvod.Naziv == "" || proizvod.Naziv == null)
            {
                return BadRequest();
            }
            return Ok(BazaProizvoda.DodajProizvod(proizvod));
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(Proizvod proizvod)
        {
            if (proizvod == null)
            {
                return BadRequest();
            }
            if (proizvod.Naziv == "" || proizvod.Naziv == null)
            {
                return BadRequest();
            }
            return Ok(BazaProizvoda.AzurirajProizvod(proizvod));
        }

        // DELETE api/<controller>/5
        public void Delete(string naziv)
        {
            BazaProizvoda.ObrisiProizvod(naziv);
        }
    }
}