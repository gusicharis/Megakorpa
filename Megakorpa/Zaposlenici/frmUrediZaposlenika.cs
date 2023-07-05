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
    public partial class frmUrediZaposlenika : Form
    {
        frmZaposlenici forma;
        int zaposlenikID;
        public frmUrediZaposlenika(int poslano,frmZaposlenici frm)
        {
            InitializeComponent();
            zaposlenikID = poslano;
            forma = frm;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Megakorpa_servis.Zaposlenik zaposlenik = new Megakorpa_servis.Zaposlenik();
                zaposlenik.RadnoMjestoID = Convert.ToInt32(cmbxRadnoMjesto.SelectedValue);
                zaposlenik.Ime = txtIme.Text;
                zaposlenik.Prezime = txtPrezime.Text;
                zaposlenik.DatumRodjenja = dtpDatumRodjenja.Value;
                zaposlenik.JMBG = mtxtJMBG.Text;
                zaposlenik.KorisnickoIme = txtKorisnickoIme.Text;
                zaposlenik.Lozinka = txtLozinka.Text;
                zaposlenik.Telefon = txtTelefon.Text;
                zaposlenik.EMail = txtEMail.Text;
                zaposlenik.Adresa = txtAdresa.Text;
                zaposlenik.GradID = Convert.ToInt32(cmbxGrad.SelectedValue);
                zaposlenik.Napomene = txtNapomena.Text;
                Megakorpa_servis.Data.ZaposlenikDA.dodajZaposlenika(zaposlenik);
                DataGridView dgv = (DataGridView)forma.Controls["dgZaposlenici"];
                dgv.DataSource = Megakorpa_servis.Data.ZaposlenikDA.ucitajZaposlenik();
                this.Close();
            }
        }

        private void frmUrediZaposlenika_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            UcitajGradove();
            UcitajDrzave();
            UcitajRadnaMjesta();
            lblUrediZaposlenika.Text = "Zaposlenik: " + zaposlenikID;
            Megakorpa_servis.Zaposlenik ucitaj = Megakorpa_servis.Data.ZaposlenikDA.zaposlenikIzaberi(zaposlenikID);
            txtIme.Text = ucitaj.Ime;
            txtPrezime.Text = ucitaj.Prezime;
            txtKorisnickoIme.Text=ucitaj.KorisnickoIme;
            txtLozinka.Text=ucitaj.Lozinka;
            txtEMail.Text=ucitaj.EMail;
            txtAdresa.Text=ucitaj.Adresa;
            txtNapomena.Text = ucitaj.Napomene;
            txtTelefon.Text=ucitaj.Telefon;
            mtxtJMBG.Text = ucitaj.JMBG;
            cmbxGrad.SelectedValue= ucitaj.GradID;
            cmbxRadnoMjesto.SelectedValue = ucitaj.RadnoMjestoID;
            dtpDatumRodjenja.Value = ucitaj.DatumRodjenja;
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

        private void UcitajRadnaMjesta()
        {
            cmbxRadnoMjesto.DataSource = Megakorpa_servis.Data.RadnoMjestoDA.prikazRadnihMjesta();
            cmbxRadnoMjesto.DisplayMember = "Naziv";
            cmbxRadnoMjesto.ValueMember = "RadnoMjestoID";
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

        private void cmbxGrad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbxDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            String drzavaID = cmbxDrzava.SelectedValue.ToString();
            UcitajGradovePoDrzavaID(drzavaID);
        }

        private void cmbxRadnoMjesto_Validating(object sender, CancelEventArgs e)
        {
            if (cmbxRadnoMjesto.SelectedIndex < 1)
            {
                errorProvider.SetError(cmbxRadnoMjesto, "Molimo izaberite radno mjesto. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(cmbxRadnoMjesto, "");
        }

        private void mtxtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (mtxtJMBG.MaskCompleted == false)
            {
                errorProvider.SetError(mtxtJMBG, "Molimo upišite JMBG. ");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(mtxtJMBG, "");
            }
        }

        private void txtNapomena_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            int duzinaUnosa = txtKorisnickoIme.Text.Trim(' ').Length;
            if (duzinaUnosa < 1)
            {
                errorProvider.SetError(txtKorisnickoIme, "Molimo upišite korisničko ime. ");
                e.Cancel = true;
            }
            else if (duzinaUnosa > 50)
            {
                errorProvider.SetError(txtKorisnickoIme, "Korisničko ime može sadržavati maksimalno 50 znakova. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtKorisnickoIme, "");
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            int duzinaUnosa = txtLozinka.Text.Trim(' ').Length;
            if (duzinaUnosa < 8)
            {
                errorProvider.SetError(txtLozinka, "Lozinka mora sadržavati minimalno 8 znakova. ");
                e.Cancel = true;
            }
            else if (duzinaUnosa > 50)
            {
                errorProvider.SetError(txtLozinka, "Lozinka može sadržavati maksimalno 50 znakova. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtLozinka, "");
        }
}
}
