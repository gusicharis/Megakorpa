using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megakorpa_servis.Data
{
    public class GradDA
    {
        public static List<Grad> getGrad()
        {
            return Connection.dm.megakorpa_Grad_Prikaz().ToList();
        }

        public static List<Grad> getGradByID(String drzavaID)
        {
            return Connection.dm.megakorpa_Grad_PrikazByDrzavaID(drzavaID).ToList();
        }
    }
}
