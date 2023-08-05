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
    public class BazaKorisnikaController : ApiController
    {

        public List<Korisnik> Get()
        {
            return ProcitajBazu();
        }
        public Korisnik Get(string korisnicko_ime)
        {
            return PronadjiKorisnika(korisnicko_ime);
        }
        public IHttpActionResult Post(Korisnik k)
        {
            if (DodajKorisnika(k))
            {
                return Ok("Uspesno dodat korisnik");
            }
            return BadRequest("Korisnik vec postoji");
        }
        public IHttpActionResult Delete(string korisnicko_ime)
        {
            if (ObrisiKorisnika(korisnicko_ime))
            {
                return Ok("Uspesno obrisan korisnik");
            }
            return BadRequest("Korisnik ne postoji");
        }


        private string dbPath = "";

        private List<Korisnik> ProcitajBazu()
        {
            string procitanaBaza = File.ReadAllText(dbPath);
            return JsonConvert.DeserializeObject<List<Korisnik>>(procitanaBaza);
        }
        
        private void SacuvajBazu(List<Korisnik> baza)
        {
            string jsonKorisnika = JsonConvert.SerializeObject(baza, Formatting.Indented);
            File.WriteAllText(dbPath, jsonKorisnika);
        }

        private bool DodajKorisnika(Korisnik k)
        {
            var baza = ProcitajBazu();
            if (baza.Contains(k))
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
        private bool ObrisiKorisnika(string korisnicko_ime)
        {
            var baza = ProcitajBazu();
            var tmp = baza;
            foreach(var k in tmp)
            {
                if(k.Korisnicko_ime == korisnicko_ime)
                {
                    baza.Remove(k);
                    SacuvajBazu(baza);
                    return true;
                }
            }
            return false;
        }
        private Korisnik PronadjiKorisnika(string korisnicko_ime)
        {
            var baza = ProcitajBazu();
            foreach(var k in baza)
            {
                if(k.Korisnicko_ime == korisnicko_ime)
                {
                    return k;
                }
            }
            return null;
        }
    }
}