using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megakorpa.GlavneForme
{
    public partial class frmDobrodosli : Form
    {
        public frmDobrodosli()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDatumVrijeme.Text = System.DateTime.Now.ToString();
        }

        private void frmDobrodosli_Load(object sender, EventArgs e)
        {
            Megakorpa_servis.Zaposlenik prijava = Properties.Settings.Default.Prijava;
            lblZaposlenik.Text = prijava.Ime + " " + prijava.Prezime;
            if (Megakorpa_servis.Data.RadnoMjestoDA.provjeriRadnoMjesto(prijava.RadnoMjestoID).Naziv.ToString() != "Administrator")
            {
                btnZaposlenici.Visible = false;
            }
            lblDatumVrijeme.Text = System.DateTime.Now.ToString();
            timer.Start();

            int BrojNarudzbi = Megakorpa_servis.Data.NarudzbaDA.getNarudzbe().Count();
            int BrojProizvoda = Megakorpa_servis.Data.ProizvodDA.getProizvod().Count();
            lblNarudzbe.Text = "Ukupno narudžbi: " + BrojNarudzbi;
            lblUkupnoProizvoda.Text = "Ukupno proizvoda: " + BrojProizvoda;
        }

        private void lblDobrodosli_Click(object sender, EventArgs e)
        {

        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            Narudzbe.frmNarudzbe frm = new Narudzbe.frmNarudzbe();
            frm.Show();
        }

        private void frmDobrodosli_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnProizvodi_Click(object sender, EventArgs e)
        {
            Proizvodi.frmProizvodi frm = new Proizvodi.frmProizvodi();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zaposlenici.frmZaposlenici frm = new Zaposlenici.frmZaposlenici();
            frm.Show();
        }

        private void frmDobrodosli_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrijava obj = (frmPrijava)Application.OpenForms["frmPrijava"];
            obj.Close();
        }
    }
}
