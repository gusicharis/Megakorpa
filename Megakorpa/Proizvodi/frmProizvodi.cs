using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megakorpa.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        public frmProizvodi()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajProizvod frm = new frmDodajProizvod(this);
            frm.Show();
        }

        private void frmProizvodi_Load(object sender, EventArgs e)
        {
            UcitajGrid();
        }
        private void UcitajGrid()
        {
            dgProizvodi.DataSource = Megakorpa_servis.Data.ProizvodDA.getProizvod();
            lblBrojRezultata.Text = "Broj rezultata: " + Megakorpa_servis.Data.ProizvodDA.getProizvod().Count();
        }

        private void dgProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int proizvodID=Convert.ToInt32(dgProizvodi.SelectedRows[0].Cells[0].Value);
            frmUrediProizvod frm = new frmUrediProizvod(proizvodID,this);
            frm.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int proizvodID = Convert.ToInt32(dgProizvodi.SelectedRows[0].Cells[0].Value);
            Megakorpa_servis.Data.ProizvodDA.obrisiProizvod(proizvodID);
            UcitajGrid();
        }
    }
}
