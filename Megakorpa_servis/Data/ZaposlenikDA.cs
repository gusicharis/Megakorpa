using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class ZaposlenikDA
    {
        public static Zaposlenik prijavaZaposlenik(String korisnickoime,String lozinka)
        {
            return Connection.dm.megakorpa_Zaposlenik_Prijava(korisnickoime,lozinka).FirstOrDefault();
        }

        public static List<Zaposlenik> getZaposlenik()
        {
            return Connection.dm.megakorpa_Zaposlenik_Prikaz().ToList();
        }

        public static List<megakorpa_Zaposlenik_PrikazForcmbx_Result> getZaposlenikcmbx()
        {
            return Connection.dm.megakorpa_Zaposlenik_PrikazForcmbx().ToList();
        }
        public static List<megakorpa_Zaposlenik_PrikazTabela_Result> ucitajZaposlenik()
        {
            return Connection.dm.megakorpa_Zaposlenik_PrikazTabela().ToList();
        }
        public static void dodajZaposlenika(Zaposlenik zaposlenik)
        {
            Connection.dm.megakorpa_Zaposlenik_Insert(zaposlenik.RadnoMjestoID, zaposlenik.Ime, zaposlenik.Prezime, zaposlenik.DatumRodjenja, zaposlenik.JMBG, zaposlenik.KorisnickoIme, zaposlenik.Lozinka, zaposlenik.Telefon, zaposlenik.EMail, zaposlenik.Adresa, zaposlenik.GradID, zaposlenik.Napomene);
        }
        public static void izmjeniZaposlenika(Zaposlenik zaposlenik)
        {
            Connection.dm.megakorpa_Zaposlenik_Izmjeni(zaposlenik.ZaposlenikID,zaposlenik.RadnoMjestoID, zaposlenik.Ime, zaposlenik.Prezime, zaposlenik.DatumRodjenja, zaposlenik.JMBG, zaposlenik.KorisnickoIme, zaposlenik.Lozinka, zaposlenik.Telefon, zaposlenik.EMail, zaposlenik.Adresa, zaposlenik.GradID, zaposlenik.Napomene);
        }
        public static Zaposlenik zaposlenikIzaberi(int zaposlenikID)
        {
            return Connection.dm.megakorpa_Zaposlenik_Ucitaj(zaposlenikID).FirstOrDefault();
        }

        public static void obrisiZaposlenik(int zaposlenikID)
        {
            Connection.dm.megakorpa_Zaposlenik_Obrisi(zaposlenikID);
        }
    }
}
