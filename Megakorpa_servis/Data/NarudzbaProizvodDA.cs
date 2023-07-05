using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class NarudzbaProizvodDA
    {
        public static List<megakorpa_NarudzbaProizvod_Prikaz_Result> getNarudzbaProizvod(int narudzbaID)
        {
            return Connection.dm.megakorpa_NarudzbaProizvod_Prikaz(narudzbaID).ToList();
        }
        public static void insertNarudzbaProizvod(NarudzbaProizvod objekat)
        {
            Connection.dm.megakorpa_NarudzbaProizvod_Insert(objekat.NarudzbaID, objekat.ProizvodID, objekat.Kvantitet, objekat.Cijena);
        }
        public static void obrisiNarudzbaProizvod(int narudzbaproizvodID)
        {
            Connection.dm.megakorpa_NarudzbaProizvod_obrisi(narudzbaproizvodID);
        }
    }
}
