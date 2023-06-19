using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjekat.Interfaces
{
    public interface IDataBase
    {
        void Dodaj(object unos);
        void Izbrisi(object unos);
        object Pronadji(string uslov);

        void Procitaj();
        
    }
}
