using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megakorpa.Narudzbe
{
    public partial class frmNarudzbe : Form
    {
        public frmNarudzbe()
        {
            InitializeComponent();
        }

        private void frmNarudzbe_Load(object sender, EventArgs e)
        {
            dgNarudzbe.AutoGenerateColumns = false;
            UcitajGrid();
        }

        private void UcitajGrid()
        {
            dgNarudzbe.DataSource = Megakorpa_servis.Data.NarudzbaDA.getNarudzbe();
            lblBrojRezultata.Text="Broj rezultata: "+Megakorpa_servis.Data.NarudzbaDA.getNarudzbe().Count().ToString();
        }

        private void UcitajGridByID(int id)
        {
            dgNarudzbe.DataSource = Megakorpa_servis.Data.NarudzbaDA.getNarudzbeByID(id);
            lblBrojRezultata.Text = "Broj rezultata: " + Megakorpa_servis.Data.NarudzbaDA.getNarudzbeByID(id).Count().ToString();
        }

        private void UcitajGridByImePrezime(String ime,String prezime)
        {
            dgNarudzbe.DataSource = Megakorpa_servis.Data.NarudzbaDA.getNarudzbeByImePrezime(ime,prezime);
            lblBrojRezultata.Text = "Broj rezultata: " + Megakorpa_servis.Data.NarudzbaDA.getNarudzbeByImePrezime(ime, prezime).Count().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajNarudzbu frm = new frmDodajNarudzbu(this);
            frm.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int narudzbaID = Convert.ToInt32(dgNarudzbe.SelectedRows[0].Cells[0].Value);
            Megakorpa_servis.Data.NarudzbaDA.obrisiNarudzbu(narudzbaID);
            UcitajGrid();
        }

        private void dgNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int narudzbaID= Convert.ToInt32(dgNarudzbe.SelectedRows[0].Cells[0].Value);
            frmUrediNarudzbu frm = new frmUrediNarudzbu(narudzbaID,this);
            frm.Show();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                UcitajGridByImePrezime(txtIme.Text, txtPrezime.Text);
            }
            if (radioButton2.Checked == true && mtxtBrojNarudzbe.MaskCompleted==true)
            {
                UcitajGridByID(Convert.ToInt32(mtxtBrojNarudzbe.Text));
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
                UcitajGrid();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtIme.Text = "";
            txtPrezime.Text = "";
            mtxtBrojNarudzbe.Text = "";
            UcitajGrid();
        }

        private void dgNarudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
