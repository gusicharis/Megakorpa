using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class NarudzbaDA
    {
        public static List<megakorpa_Narudzba_Prikaz_Result> getNarudzbe()
        {
            return Connection.dm.megakorpa_Narudzba_Prikaz().ToList();
        }
        public static void insertNarudzbe(Narudzba narudzba)
        {
            Connection.dm.megakorpa_Narudzba_Insert(narudzba.ZaposlenikID, narudzba.DatumNarudzbe, narudzba.VrijemeNarudzbe, narudzba.Ime, narudzba.Prezime, narudzba.Telefon, narudzba.Adresa, narudzba.GradID, narudzba.Napomene, narudzba.Dostavljeno);
        }
        public static void obrisiNarudzbu(int narudzbaID)
        {
            Connection.dm.megakorpa_Narudzba_Obrisi(narudzbaID);
        }
        public static Narudzba ucitajNarudzbu(int narudzbaID)
        {
            return Connection.dm.megakorpa_Narudzba_Ucitaj(narudzbaID).FirstOrDefault();
        }
        public static void izmjeniNarudzbu(Narudzba narudzba)
        {
            Connection.dm.megakorpa_Narudzba_Izmjena(narudzba.NarudzbaID, narudzba.ZaposlenikID, narudzba.DatumNarudzbe, narudzba.VrijemeNarudzbe, narudzba.Ime, narudzba.Prezime, narudzba.Telefon, narudzba.Adresa, narudzba.GradID, narudzba.Napomene, narudzba.Dostavljeno);
        }
        public static List<megakorpa_Narudzba_PrikazByImePrezime_Result> getNarudzbeByImePrezime(String ime,String prezime)
        {
            return Connection.dm.megakorpa_Narudzba_PrikazByImePrezime(ime,prezime).ToList();
        }
        public static List<megakorpa_Narudzba_PrikazByBrojNarudzbe_Result> getNarudzbeByID(int id)
        {
            return Connection.dm.megakorpa_Narudzba_PrikazByBrojNarudzbe(id).ToList();
        }
    }
}
