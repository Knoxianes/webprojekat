using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace WebProjekat.Models
{
    public class BazaProizvoda
    {
        public static Dictionary<string, Proizvod> Proizvodi = new Dictionary<string, Proizvod>();
        private static string dbPath = "App_Data/BazaProizvoda.json";
        public static Proizvod  DodajProizvod(Proizvod Proizvod)
        {
            if (Proizvodi.ContainsKey(Proizvod.Naziv))
            {
                return null;
            }
            else
            {
                Proizvodi.Add(Proizvod.Naziv, Proizvod);
                SacuvajBazu();
                return Proizvod;
            }
        }

        public static void ObrisiProizvod(string naziv)
        {
            if (Proizvodi.ContainsKey(naziv))
            {
                Proizvodi.Remove(naziv);
                SacuvajBazu();
            }
        }

        public static Proizvod AzurirajProizvod(Proizvod Proizvod)
        {
            if (Proizvodi.ContainsKey(Proizvod.Naziv))
            {
                Proizvodi[Proizvod.Naziv] = Proizvod;
                SacuvajBazu();
                return Proizvodi[Proizvod.Naziv];
            }
            else
            {
                return null;
            }
        }
        public static List<Proizvod> ProcitajProizvode()
        {
            List<Proizvod> lista = new List<Proizvod>();
            foreach (var key in Proizvodi.Keys)
            {
                lista.Add(Proizvodi[key]);
            }
            return lista;
        }
        public static void ProcitajBazu()
        {
            string procitanaBaza = File.ReadAllText(dbPath);
            List<Proizvod> listProizvoda = JsonConvert.DeserializeObject<List<Proizvod>>(procitanaBaza);
            Proizvodi = listProizvoda.ToDictionary(keySelector: proizvod => proizvod.Naziv, elementSelector: proizvod => proizvod);
        }
        public static void SacuvajBazu()
        {
            List<Proizvod> listProizvoda = new List<Proizvod>();
            foreach (var key in Proizvodi.Keys)
            {
                listProizvoda.Add(Proizvodi[key]);
            }
            string jsonProizvoda = JsonConvert.SerializeObject(listProizvoda, Formatting.Indented);
            File.WriteAllText(dbPath, jsonProizvoda);
        }
    }
}