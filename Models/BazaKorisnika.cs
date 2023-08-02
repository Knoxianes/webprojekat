using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebProjekat.Models
{
    public class BazaKorisnika
    {
        public static Dictionary<string, Korisnik> Korisnici = new Dictionary<string, Korisnik>();
        private static string dbPath = "App_Data/BazaKorisnika.json";
        public static Korisnik DodajKorisnika (Korisnik korisnik)
        {
            if (Korisnici.ContainsKey(korisnik.Korisnicko_ime))
            {
                return null;
            }
            else
            {
                Korisnici.Add(korisnik.Korisnicko_ime, korisnik);
                SacuvajBazu();
                return korisnik;
            }
        }
        
        public static void ObrisiKorisnika(string korisnicko_ime)
        {
            if (Korisnici.ContainsKey(korisnicko_ime))
            {
                Korisnici.Remove(korisnicko_ime);
                SacuvajBazu();
            }
        }

        public static Korisnik AzurirajKorisnika(Korisnik korisnik)
        {
            if (Korisnici.ContainsKey(korisnik.Korisnicko_ime))
            {
                Korisnici[korisnik.Korisnicko_ime] = korisnik;
                SacuvajBazu();
                return Korisnici[korisnik.Korisnicko_ime];
            }
            else
            {
                return null;
            }
        }
        public static List<Korisnik> ProcitajKorisnike()
        {
            List<Korisnik> lista = new List<Korisnik>();
            foreach(var key in Korisnici.Keys)
            {
                lista.Add(Korisnici[key]);
            }
            return lista;
        }
        public static void ProcitajBazu()
        {
            
            string procitanaBaza = File.ReadAllText(dbPath);
            List<Korisnik> listKorisnika = JsonConvert.DeserializeObject<List<Korisnik>>(procitanaBaza);
            Korisnici = listKorisnika.ToDictionary(keySelector: korisnik => korisnik.Korisnicko_ime, elementSelector: korisnik => korisnik);

        }
        public static void SacuvajBazu()
        {
            List<Korisnik> listKorisnika = new List<Korisnik>();
            foreach(var key in Korisnici.Keys)
            {
                listKorisnika.Add(Korisnici[key]);
            }
            string jsonKorisnika = JsonConvert.SerializeObject(listKorisnika, Formatting.Indented);
            File.WriteAllText(dbPath, jsonKorisnika);
        }
    }
}