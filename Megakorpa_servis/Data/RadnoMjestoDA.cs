using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class RadnoMjestoDA
    {
        public static RadnoMjesto provjeriRadnoMjesto(int radnomjestoID)
        {
            return Connection.dm.megakorpa_RadnoMjesto_Provjera(radnomjestoID).FirstOrDefault();
        }
        public static List<RadnoMjesto> prikazRadnihMjesta()
        {
            return Connection.dm.megakorpa_RadnoMjesto_Prikaz().ToList();
        }
    }
}
