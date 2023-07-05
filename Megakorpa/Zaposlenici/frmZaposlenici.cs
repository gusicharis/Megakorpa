using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megakorpa.Zaposlenici
{
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            UcitajGrid();
        }

        private void UcitajGrid()
        {
            dgZaposlenici.DataSource = Megakorpa_servis.Data.ZaposlenikDA.ucitajZaposlenik();
            lblBrojRezultata.Text="Broj rezultata: "+ Megakorpa_servis.Data.ZaposlenikDA.ucitajZaposlenik().Count();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajZaposlenika frm=new frmDodajZaposlenika(this);
            frm.Show();
        }

        private void dgZaposlenici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int zaposlenikID = Convert.ToInt32(dgZaposlenici.SelectedRows[0].Cells[0].Value);
            frmUrediZaposlenika frm=new frmUrediZaposlenika(zaposlenikID,this);
            frm.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int zaposlenikID = Convert.ToInt32(dgZaposlenici.SelectedRows[0].Cells[0].Value);
            Megakorpa_servis.Data.ZaposlenikDA.obrisiZaposlenik(zaposlenikID);
            UcitajGrid();
        }
    }
}
