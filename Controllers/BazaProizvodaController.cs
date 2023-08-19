using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            return ProcitajBazu();
        }
        public Proizvod Get(string naziv)
        {
            return PronadjiProizvod(naziv);
        }
        public IHttpActionResult Post(Proizvod k)
        {
            if (DodajProizvod(k))
            {
                return Ok("Uspesno dodat Proizvod");
            }
            return BadRequest("Proizvod vec postoji");
        }
        public IHttpActionResult Delete(string korisnicko_ime)
        {
            if (ObrisiProizvod(korisnicko_ime))
            {
                return Ok("Uspesno obrisan Proizvod");
            }
            return BadRequest("Proizvod ne postoji");
        }


        private string dbPath = "";

        private List<Proizvod> ProcitajBazu()
        {
            string procitanaBaza = File.ReadAllText(dbPath);
            return JsonConvert.DeserializeObject<List<Proizvod>>(procitanaBaza);
        }

        private void SacuvajBazu(List<Proizvod> baza)
        {
            string jsonProizvoda = JsonConvert.SerializeObject(baza, Formatting.Indented);
            File.WriteAllText(dbPath, jsonProizvoda);
        }

        private bool DodajProizvod(Proizvod k)
        {
            var baza = ProcitajBazu();
            if (PronadjiProizvod(k.Naziv) != null)
            {
                return false;
            }
            else
            {
                baza.Add(k);
                SacuvajBazu(baza);
                return true;
            }
        }
        private bool ObrisiProizvod(string naziv)
        {
            var baza = ProcitajBazu();
            var tmp = baza;
            foreach (var k in tmp)
            {
                if (k.Naziv == naziv)
                {
                    baza.Remove(k);
                    SacuvajBazu(baza);
                    return true;
                }
            }
            return false;
        }
        private Proizvod PronadjiProizvod(string naziv)
        {
            var baza = ProcitajBazu();
            foreach (var k in baza)
            {
                if (k.Naziv == naziv)
                {
                    return k;
                }
            }
            return null;
        }
    }
}