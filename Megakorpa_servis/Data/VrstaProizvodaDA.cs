using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class VrstaProizvodaDA
    {
        public static List<VrstaProizvoda> getVrste()
        {
            return Connection.dm.megakorpa_VrstaProizvoda_Prikaz().ToList();
        }
    }
}
