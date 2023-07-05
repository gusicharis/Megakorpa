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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void linklblZaboraviliSteLozinku_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Molimo kontaktirajte vašeg administratora za pomoć. ", "Zaboravili ste lozinku? ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider.SetError(txtKorisnickoIme, "Molimo unesite korisničko ime. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtKorisnickoIme, "");
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                errorProvider.SetError(txtLozinka, "Molimo unesite lozinku. ");
                e.Cancel = true;
            }
            else
                errorProvider.SetError(txtLozinka, "");
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            Properties.Settings.Default.Prijava = null;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Megakorpa_servis.Zaposlenik prijava = Megakorpa_servis.Data.ZaposlenikDA.prijavaZaposlenik(txtKorisnickoIme.Text,txtLozinka.Text);
                if (prijava != null)
                {
                    Properties.Settings.Default.Prijava = prijava;
                    frmDobrodosli frm = new frmDobrodosli();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unijeli ste pogrešno korisničko ime ili lozinku! ", "Pogrešni podaci", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
