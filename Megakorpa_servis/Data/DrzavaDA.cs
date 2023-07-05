using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class DrzavaDA
    {
        public static List<Drzava> getDrzava()
        {
            return Connection.dm.megakorpa_Drzava_Prikaz().ToList();
        }
        public static Drzava getDrzavaByID(String drzavaID)
        {
            return Connection.dm.megakorpa_Drzava_PrikazByDrzavaID(drzavaID).FirstOrDefault();
        }
        public static Drzava getDrzavaByGradID(int gradID)
        {
            return Connection.dm.megakorpa_Drzava_PrikazByGradID(gradID).FirstOrDefault();
        }
    }
}
