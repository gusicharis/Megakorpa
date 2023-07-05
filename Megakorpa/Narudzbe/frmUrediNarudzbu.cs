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
    public partial class frmUrediNarudzbu : Form
    {
        frmNarudzbe forma;
        int narudzbaID;
        decimal cijena;
        Megakorpa_servis.Narudzba narudzba = new Megakorpa_servis.Narudzba();
        public frmUrediNarudzbu(int proslijedjeniID,frmNarudzbe frm)
        {
            InitializeComponent();
            narudzbaID = proslijedjeniID;
            forma = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUrediNarudzbu_Load(object sender, EventArgs e)
        {
            narudzba = Megakorpa_servis.Data.NarudzbaDA.ucitajNarudzbu(Convert.ToInt32(narudzbaID));
            this.AutoValidate = AutoValidate.Disable;
            lblUrediNarudzbu.Text = "Narudžba: " + narudzbaID.ToString();
            dtpVrijemeNarudzbe.Format = DateTimePickerFormat.Custom;
            dtpDatumNarudzbe.Value = DateTime.Now.Date;
            UcitajZaposlenike();
            UcitajDrzave();
            UcitajGradove();
            UcitajProizvode();
            UcitajAritkle();
            cmbxZaposlenik.SelectedValue = narudzba.ZaposlenikID;
            dtpDatumNarudzbe.Value = narudzba.DatumNarudzbe;
            dtpVrijemeNarudzbe.Value = DateTime.Now.Add(narudzba.VrijemeNarudzbe);
            txtIme.Text = narudzba.Ime;
            txtPrezime.Text = narudzba.Prezime;
            txtBrojTelefona.Text = narudzba.Telefon;
            cmbxGrad.SelectedValue = narudzba.GradID;
            txtAdresa.Text = narudzba.Adresa;
            txtNapomena.Text = narudzba.Napomene;
            chbxDostavljeno.Checked = narudzba.Dostavljeno;
            IzracunajCijenu();
        }

        private void IzracunajCijenu()
        {
            List<Megakorpa_servis.megakorpa_NarudzbaProizvod_Prikaz_Result> narudzbaProizvod = new List<Megakorpa_servis.megakorpa_NarudzbaProizvod_Prikaz_Result>();
            narudzbaProizvod = Megakorpa_servis.Data.NarudzbaProizvodDA.getNarudzbaProizvod(narudzbaID);
            int broj = narudzbaProizvod.Count;
            //for (int i = 1; i <= broj; i++)
            //{
            //    cijena += narudzbaProizvod[i].CijenaRacun;
            //}
            //lblUkupno.Text = "Ukupno: " + cijena + " KM";
        }

        private void UcitajAritkle()
        {
            dgArtikli.DataSource = Megakorpa_servis.Data.NarudzbaProizvodDA.getNarudzbaProizvod(narudzbaID);
        }

        private void UcitajProizvode()
        {
            List<Megakorpa_servis.megakorpa_Proizvod_Prikaz_Result> listaProizvoda = Megakorpa_servis.Data.ProizvodDA.getProizvod();

            Megakorpa_servis.megakorpa_Proizvod_Prikaz_Result izaberiProizvod = new Megakorpa_servis.megakorpa_Proizvod_Prikaz_Result();
            izaberiProizvod.ProizvodID = 0;
            izaberiProizvod.Naziv = "Izaberite proizvod";
            listaProizvoda.Insert(0, izaberiProizvod);

            cmbxProizvod.DataSource = listaProizvoda;
            cmbxProizvod.DisplayMember = "Naziv";
            cmbxProizvod.ValueMember = "ProizvodID";
        }

        private void UcitajGradove()
        {
            List<Megakorpa_servis.Grad> listaGradova = Megakorpa_servis.Data.GradDA.getGrad();

            Megakorpa_servis.Grad izaberiGrad = new Megakorpa_servis.Grad();
            izaberiGrad.GradID = 0;
            izaberiGrad.Naziv = "Izaberite grad";
            listaGradova.Insert(0, izaberiGrad);

            cmbxGrad.DataSource = listaGradova;
            cmbxGrad.DisplayMember = "Naziv";
            cmbxGrad.ValueMember = "GradID";
        }

        private void UcitajGradovePoDrzavaID(String drzavaID)
        {
            List<Megakorpa_servis.Grad> listaGradova = Megakorpa_servis.Data.GradDA.getGradByID(drzavaID);

            Megakorpa_servis.Grad izaberiGrad = new Megakorpa_servis.Grad();
            izaberiGrad.GradID = 0;
            izaberiGrad.Naziv = "Izaberite grad";
            listaGradova.Insert(0, izaberiGrad);

            cmbxGrad.DataSource = listaGradova;
            cmbxGrad.DisplayMember = "Naziv";
            cmbxGrad.ValueMember = "GradID";
        }

        private void UcitajDrzave()
        {
            List<Megakorpa_servis.Drzava> listaDrzava = Megakorpa_servis.Data.DrzavaDA.getDrzava();

            Megakorpa_servis.Drzava izaberiDrzavu = new Megakorpa_servis.Drzava();
            izaberiDrzavu.DrzavaID = "00";
            izaberiDrzavu.Naziv = "Izaberite državu";
            listaDrzava.Insert(0, izaberiDrzavu);

            cmbxDrzava.DataSource = listaDrzava;
            cmbxDrzava.DisplayMember = "Naziv";
            cmbxDrzava.ValueMember = "DrzavaID";
        }
        private void UcitajZaposlenike()
        {
            List<Megakorpa_servis.megakorpa_Zaposlenik_PrikazForcmbx_Result> listaZaposlenika = Megakorpa_servis.Data.ZaposlenikDA.getZaposlenikcmbx();

            Megakorpa_servis.megakorpa_Zaposlenik_PrikazForcmbx_Result izaberiZaposlenika = new Megakorpa_servis.megakorpa_Zaposlenik_PrikazForcmbx_Result();
            izaberiZaposlenika.ZaposlenikID = 0;
            izaberiZaposlenika.ImePrezime = "Izaberite zaposlenika";
            listaZaposlenika.Insert(0, izaberiZaposlenika);

            cmbxZaposlenik.DataSource = listaZaposlenika;
            cmbxZaposlenik.DisplayMember = "ImePrezime";
            cmbxZaposlenik.ValueMember = "ZaposlenikID";
        }

        private void cmbxGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gradID;
            bool result = int.TryParse(cmbxGrad.SelectedValue.ToString(), out gradID);
            if (cmbxGrad.SelectedIndex > 0)
            {
                String drzavaID = Megakorpa_servis.Data.DrzavaDA.getDrzavaByGradID(gradID).DrzavaID;
                cmbxDrzava.SelectedValue = drzavaID;
            }
        }

        private void cmbxDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            String drzavaID = cmbxDrzava.SelectedValue.ToString();
            if (cmbxDrzava.SelectedIndex > 0)
                UcitajGradovePoDrzavaID(drzavaID);
            else
                UcitajGradove();
        }

        private void cmbxProizvod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbxProizvod.SelectedIndex > 1)
            {
                Megakorpa_servis.NarudzbaProizvod narudzbaproizvod = new Megakorpa_servis.NarudzbaProizvod();
                int proizvodID = Convert.ToInt32(cmbxProizvod.SelectedValue);
                narudzbaproizvod.NarudzbaID = narudzbaID;
                narudzbaproizvod.ProizvodID = proizvodID;
                narudzbaproizvod.Kvantitet = Convert.ToInt32(nudKvantitet.Value);
                narudzbaproizvod.Cijena = Megakorpa_servis.Data.ProizvodDA.getCijena(proizvodID).Cijena;
                Megakorpa_servis.Data.NarudzbaProizvodDA.insertNarudzbaProizvod(narudzbaproizvod);
                UcitajAritkle();
                cmbxProizvod.SelectedIndex = 0;
                nudKvantitet.Value = 1;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int narudzbaproizvodID = Convert.ToInt32(dgArtikli.SelectedRows[0].Cells[0].Value);
            Megakorpa_servis.Data.NarudzbaProizvodDA.obrisiNarudzbaProizvod(narudzbaproizvodID);
            UcitajAritkle();
        }

        private void cmbxZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            if (cmbxZaposlenik.SelectedIndex < 1)
            {
                errorProvider.SetError(cmbxZaposlenik, "Molimo izaberite zaposlenika. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(cmbxZaposlenik, "");
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            int duzinaUnosa = txtIme.Text.Trim(' ').Length;
            if (duzinaUnosa < 1)
            {
                errorProvider.SetError(txtIme, "Molimo upišite ime kupca. ");
                e.Cancel = true;
            }
            else if (duzinaUnosa > 50)
            {
                errorProvider.SetError(txtIme, "Ime može sadržavati maksimalno 50 znakova. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtIme, "");
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            int duzinaUnosa = txtPrezime.Text.Trim(' ').Length;
            if (duzinaUnosa < 1)
            {
                errorProvider.SetError(txtPrezime, "Molimo upišite prezime kupca. ");
                e.Cancel = true;
            }
            else if (duzinaUnosa > 50)
            {
                errorProvider.SetError(txtPrezime, "Prezime može sadržavati maksimalno 50 znakova. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtPrezime, "");
        }

        private void txtBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            int duzinaUnosa = txtBrojTelefona.Text.Trim(' ').Length;
            if (duzinaUnosa < 1)
            {
                errorProvider.SetError(txtBrojTelefona, "Molimo upišite kontakt telefon kupca. ");
                e.Cancel = true;
            }
            else if (duzinaUnosa > 50)
            {
                errorProvider.SetError(txtBrojTelefona, "Broj telefona može sadržavati maksimalno 15 znakova. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtBrojTelefona, "");
        }

        private void cmbxDrzava_Validating(object sender, CancelEventArgs e)
        {
            if (cmbxDrzava.SelectedIndex < 1)
            {
                errorProvider.SetError(cmbxDrzava, "Molimo izaberite državu. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(cmbxDrzava, "");
        }

        private void cmbxGrad_Validating(object sender, CancelEventArgs e)
        {
            if (cmbxGrad.SelectedIndex < 1)
            {
                errorProvider.SetError(cmbxGrad, "Molimo izaberite grad. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(cmbxGrad, "");
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            int duzinaUnosa = txtAdresa.Text.Trim(' ').Length;
            if (duzinaUnosa < 1)
            {
                errorProvider.SetError(txtAdresa, "Molimo upišite adresu dostave. ");
                e.Cancel = true;
            }
            else if (duzinaUnosa > 100)
            {
                errorProvider.SetError(txtAdresa, "Adresa može sadržavati maksimalno 100 znakova. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtAdresa, "");
        }

        private void txtNapomena_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                narudzba.NarudzbaID = narudzbaID;
                narudzba.ZaposlenikID = Convert.ToInt32(cmbxZaposlenik.SelectedValue);
                narudzba.DatumNarudzbe = dtpDatumNarudzbe.Value;
                narudzba.VrijemeNarudzbe = dtpVrijemeNarudzbe.Value.TimeOfDay;
                narudzba.Ime = txtIme.Text;
                narudzba.Prezime = txtPrezime.Text;
                narudzba.Telefon = txtBrojTelefona.Text;
                narudzba.Adresa = txtAdresa.Text;
                narudzba.GradID = Convert.ToInt32(cmbxGrad.SelectedValue);
                narudzba.Napomene = txtNapomena.Text;
                narudzba.Dostavljeno = chbxDostavljeno.Checked;
                Megakorpa_servis.Data.NarudzbaDA.izmjeniNarudzbu(narudzba);
                DataGridView dgv = (DataGridView)forma.Controls["dgNarudzbe"];
                dgv.DataSource = Megakorpa_servis.Data.NarudzbaDA.getNarudzbe();
                this.Close();
            }
        }
    }
}
