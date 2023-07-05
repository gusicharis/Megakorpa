using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class ProizvodDA
    {
        public static List<megakorpa_Proizvod_Prikaz_Result> getProizvod()
        {
            return Connection.dm.megakorpa_Proizvod_Prikaz().ToList();
        }
        public static megakorpa_Proizvod_Cijena_Result getCijena(int proizvodID)
        {
            return Connection.dm.megakorpa_Proizvod_Cijena(proizvodID).FirstOrDefault();
        }
        public static void dodajProizvod(Proizvod proizvod)
        {
            Connection.dm.megakorpa_Proizvod_Insert(proizvod.VrstaProizvodaID, proizvod.ProizvodjacID, proizvod.Naziv, proizvod.Opis, proizvod.Sifra, proizvod.Cijena, proizvod.Kvantitet);
        }
        public static void izmjeniProizvod(Proizvod proizvod)
        {
            Connection.dm.megakorpa_Proizvod_Izmjena(proizvod.ProizvodID,proizvod.VrstaProizvodaID, proizvod.ProizvodjacID, proizvod.Naziv, proizvod.Opis, proizvod.Sifra, proizvod.Cijena, proizvod.Kvantitet);
        }
        public static Proizvod ucitajProizvod(int proizvodID)
        {
            return Connection.dm.megakorpa_Proizvod_prikazEdit(proizvodID).FirstOrDefault();
        }
        public static void obrisiProizvod(int proizvodID)
        {
            Connection.dm.megakorpa_Proizvod_Obrisi(proizvodID);
        }
    }
}
