using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class ProizvodjacDA
    {
        public static List<megakorpa_Proizvodjac_prikaz_Result> getProizvodjac()
        {
            return Connection.dm.megakorpa_Proizvodjac_prikaz().ToList();
        }
    }
}
