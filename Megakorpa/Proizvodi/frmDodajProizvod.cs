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
    public partial class frmDodajProizvod : Form
    {
        frmProizvodi forma;
        public frmDodajProizvod(frmProizvodi frm)
        {
            InitializeComponent();
            forma = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodajProizvod_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            UcitajVrste();
            UcitajProizvodjace();
        }

        private void UcitajProizvodjace()
        {
            List<Megakorpa_servis.megakorpa_Proizvodjac_prikaz_Result> listaProizvodjaca = Megakorpa_servis.Data.ProizvodjacDA.getProizvodjac();

            Megakorpa_servis.megakorpa_Proizvodjac_prikaz_Result izaberiProizvodjaca = new Megakorpa_servis.megakorpa_Proizvodjac_prikaz_Result();
            izaberiProizvodjaca.ProizvodjacID = 0;
            izaberiProizvodjaca.Naziv = "Izaberite vrstu proizvoda";
            listaProizvodjaca.Insert(0, izaberiProizvodjaca);

            cmbxProizvodjac.DataSource = listaProizvodjaca;
            cmbxProizvodjac.DisplayMember = "Naziv";
            cmbxProizvodjac.ValueMember = "ProizvodjacID";
        }

        private void UcitajVrste()
        {
            List<Megakorpa_servis.VrstaProizvoda> listaVrsta = Megakorpa_servis.Data.VrstaProizvodaDA.getVrste();

            Megakorpa_servis.VrstaProizvoda izaberiVrstu = new Megakorpa_servis.VrstaProizvoda();
            izaberiVrstu.VrstaProizvodaID = 0;
            izaberiVrstu.Naziv = "Izaberite vrstu proizvoda";
            listaVrsta.Insert(0, izaberiVrstu);

            cmbxVrsta.DataSource = listaVrsta;
            cmbxVrsta.DisplayMember = "Naziv";
            cmbxVrsta.ValueMember = "VrstaProizvodaID";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Megakorpa_servis.Proizvod proizvod = new Megakorpa_servis.Proizvod();
                proizvod.VrstaProizvodaID = Convert.ToInt32(cmbxVrsta.SelectedValue);
                proizvod.ProizvodjacID = Convert.ToInt32(cmbxProizvodjac.SelectedValue);
                proizvod.Naziv = txtNaziv.Text;
                proizvod.Opis = txtOpis.Text;
                proizvod.Sifra = mtxtSifra.Text;
                proizvod.Cijena = Convert.ToDecimal(txtCijena.Text);
                proizvod.Kvantitet = Convert.ToInt32(nudKvantitet.Value);
                Megakorpa_servis.Data.ProizvodDA.dodajProizvod(proizvod);
                DataGridView dgv = (DataGridView)forma.Controls["dgProizvodi"];
                dgv.DataSource = Megakorpa_servis.Data.ProizvodDA.getProizvod();
                this.Close();
            }
        }

        private void cmbxVrsta_Validating(object sender, CancelEventArgs e)
        {
            if (cmbxVrsta.SelectedIndex < 1)
            {
                errorProvider.SetError(cmbxVrsta, "Molimo izaberite vrstu proizvoda. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(cmbxVrsta, "");
        }

        private void cmbxProizvodjac_Validating(object sender, CancelEventArgs e)
        {
            if (cmbxProizvodjac.SelectedIndex < 1)
            {
                errorProvider.SetError(cmbxProizvodjac, "Molimo izaberite proizvođača. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(cmbxProizvodjac, "");
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            int duzinaUnosa = txtNaziv.Text.Trim(' ').Length;
            if (duzinaUnosa < 1)
            {
                errorProvider.SetError(txtNaziv, "Molimo upišite naziv proizvoda. ");
                e.Cancel = true;
            }
            else if (duzinaUnosa > 50)
            {
                errorProvider.SetError(txtNaziv, "Naziv proizvoda može sadržavati maksimalno 50 znakova. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtNaziv, "");
        }

        private void mtxtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (mtxtSifra.MaskCompleted == false)
            {
                errorProvider.SetError(mtxtSifra, "Molimo upišite šifru proizvoda. ");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(mtxtSifra, "");
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            decimal decimalno;
            bool provjera = Decimal.TryParse(txtCijena.Text, out decimalno);
            if (provjera==false)
            {
                errorProvider.SetError(txtCijena, "Molimo upišite cijenu u decimalnom obliku. ");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijena, "");
            }
        }
    }
}
