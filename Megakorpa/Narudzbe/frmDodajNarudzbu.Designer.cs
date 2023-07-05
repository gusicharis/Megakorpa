namespace Megakorpa.Narudzbe
{
    partial class frmDodajNarudzbu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajNarudzbu));
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblProdavnica = new System.Windows.Forms.Label();
            this.lblDodajNarudzbu = new System.Windows.Forms.Label();
            this.gbPodaciONarudzbi = new System.Windows.Forms.GroupBox();
            this.dtpVrijemeNarudzbe = new System.Windows.Forms.DateTimePicker();
            this.lblVrijemeNarudzbe = new System.Windows.Forms.Label();
            this.dtpDatumNarudzbe = new System.Windows.Forms.DateTimePicker();
            this.lblDatumNarudzbe = new System.Windows.Forms.Label();
            this.cmbxZaposlenik = new System.Windows.Forms.ComboBox();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.gbPodaciOKupcu = new System.Windows.Forms.GroupBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.gbPodaciODostavi = new System.Windows.Forms.GroupBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.cmbxGrad = new System.Windows.Forms.ComboBox();
            this.lblGrad = new System.Windows.Forms.Label();
            this.cmbxDrzava = new System.Windows.Forms.ComboBox();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.gbNapomena = new System.Windows.Forms.GroupBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.pbNarudzbe = new System.Windows.Forms.PictureBox();
            this.gbPodaciONarudzbi.SuspendLayout();
            this.gbPodaciOKupcu.SuspendLayout();
            this.gbPodaciODostavi.SuspendLayout();
            this.gbNapomena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.Orange;
            this.lblAdresa.Location = new System.Drawing.Point(122, 73);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(114, 16);
            this.lblAdresa.TabIndex = 12;
            this.lblAdresa.Text = "Alekse Šantića 10";
            // 
            // lblProdavnica
            // 
            this.lblProdavnica.AutoSize = true;
            this.lblProdavnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdavnica.ForeColor = System.Drawing.Color.Orange;
            this.lblProdavnica.Location = new System.Drawing.Point(121, 49);
            this.lblProdavnica.Name = "lblProdavnica";
            this.lblProdavnica.Size = new System.Drawing.Size(105, 24);
            this.lblProdavnica.TabIndex = 11;
            this.lblProdavnica.Text = "Megakorpa";
            // 
            // lblDodajNarudzbu
            // 
            this.lblDodajNarudzbu.AutoSize = true;
            this.lblDodajNarudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodajNarudzbu.ForeColor = System.Drawing.Color.Gray;
            this.lblDodajNarudzbu.Location = new System.Drawing.Point(118, 12);
            this.lblDodajNarudzbu.Name = "lblDodajNarudzbu";
            this.lblDodajNarudzbu.Size = new System.Drawing.Size(245, 37);
            this.lblDodajNarudzbu.TabIndex = 9;
            this.lblDodajNarudzbu.Text = "Dodaj narudžbu";
            // 
            // gbPodaciONarudzbi
            // 
            this.gbPodaciONarudzbi.Controls.Add(this.dtpVrijemeNarudzbe);
            this.gbPodaciONarudzbi.Controls.Add(this.lblVrijemeNarudzbe);
            this.gbPodaciONarudzbi.Controls.Add(this.dtpDatumNarudzbe);
            this.gbPodaciONarudzbi.Controls.Add(this.lblDatumNarudzbe);
            this.gbPodaciONarudzbi.Controls.Add(this.cmbxZaposlenik);
            this.gbPodaciONarudzbi.Controls.Add(this.lblZaposlenik);
            this.gbPodaciONarudzbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPodaciONarudzbi.Location = new System.Drawing.Point(12, 128);
            this.gbPodaciONarudzbi.Name = "gbPodaciONarudzbi";
            this.gbPodaciONarudzbi.Size = new System.Drawing.Size(275, 110);
            this.gbPodaciONarudzbi.TabIndex = 13;
            this.gbPodaciONarudzbi.TabStop = false;
            this.gbPodaciONarudzbi.Text = "Podaci o narudžbi";
            // 
            // dtpVrijemeNarudzbe
            // 
            this.dtpVrijemeNarudzbe.CustomFormat = "hh:mm:ss";
            this.dtpVrijemeNarudzbe.Location = new System.Drawing.Point(127, 77);
            this.dtpVrijemeNarudzbe.Name = "dtpVrijemeNarudzbe";
            this.dtpVrijemeNarudzbe.ShowUpDown = true;
            this.dtpVrijemeNarudzbe.Size = new System.Drawing.Size(125, 22);
            this.dtpVrijemeNarudzbe.TabIndex = 8;
            this.dtpVrijemeNarudzbe.Value = new System.DateTime(2022, 3, 20, 14, 49, 55, 0);
            // 
            // lblVrijemeNarudzbe
            // 
            this.lblVrijemeNarudzbe.AutoSize = true;
            this.lblVrijemeNarudzbe.Location = new System.Drawing.Point(6, 80);
            this.lblVrijemeNarudzbe.Name = "lblVrijemeNarudzbe";
            this.lblVrijemeNarudzbe.Size = new System.Drawing.Size(115, 16);
            this.lblVrijemeNarudzbe.TabIndex = 7;
            this.lblVrijemeNarudzbe.Text = "Vrijeme narudžbe:";
            // 
            // dtpDatumNarudzbe
            // 
            this.dtpDatumNarudzbe.CustomFormat = "yyyy-MM-dd";
            this.dtpDatumNarudzbe.Location = new System.Drawing.Point(127, 49);
            this.dtpDatumNarudzbe.Name = "dtpDatumNarudzbe";
            this.dtpDatumNarudzbe.Size = new System.Drawing.Size(125, 22);
            this.dtpDatumNarudzbe.TabIndex = 5;
            this.dtpDatumNarudzbe.Value = new System.DateTime(2022, 3, 20, 14, 49, 55, 0);
            this.dtpDatumNarudzbe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpDatumNarudzbe_MouseDown);
            // 
            // lblDatumNarudzbe
            // 
            this.lblDatumNarudzbe.AutoSize = true;
            this.lblDatumNarudzbe.Location = new System.Drawing.Point(6, 54);
            this.lblDatumNarudzbe.Name = "lblDatumNarudzbe";
            this.lblDatumNarudzbe.Size = new System.Drawing.Size(108, 16);
            this.lblDatumNarudzbe.TabIndex = 4;
            this.lblDatumNarudzbe.Text = "Datum narudžbe:";
            // 
            // cmbxZaposlenik
            // 
            this.cmbxZaposlenik.Enabled = false;
            this.cmbxZaposlenik.FormattingEnabled = true;
            this.cmbxZaposlenik.Location = new System.Drawing.Point(127, 19);
            this.cmbxZaposlenik.Name = "cmbxZaposlenik";
            this.cmbxZaposlenik.Size = new System.Drawing.Size(125, 24);
            this.cmbxZaposlenik.TabIndex = 1;
            this.cmbxZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxZaposlenik_Validating);
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(6, 22);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(77, 16);
            this.lblZaposlenik.TabIndex = 0;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // gbPodaciOKupcu
            // 
            this.gbPodaciOKupcu.Controls.Add(this.txtBrojTelefona);
            this.gbPodaciOKupcu.Controls.Add(this.lblBrojTelefona);
            this.gbPodaciOKupcu.Controls.Add(this.txtPrezime);
            this.gbPodaciOKupcu.Controls.Add(this.lblPrezime);
            this.gbPodaciOKupcu.Controls.Add(this.txtIme);
            this.gbPodaciOKupcu.Controls.Add(this.lblIme);
            this.gbPodaciOKupcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPodaciOKupcu.Location = new System.Drawing.Point(12, 244);
            this.gbPodaciOKupcu.Name = "gbPodaciOKupcu";
            this.gbPodaciOKupcu.Size = new System.Drawing.Size(275, 110);
            this.gbPodaciOKupcu.TabIndex = 14;
            this.gbPodaciOKupcu.TabStop = false;
            this.gbPodaciOKupcu.Text = "Podaci o kupcu";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(103, 77);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(145, 22);
            this.txtBrojTelefona.TabIndex = 18;
            this.txtBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojTelefona_Validating);
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(12, 80);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(85, 16);
            this.lblBrojTelefona.TabIndex = 17;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(103, 49);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(145, 22);
            this.txtPrezime.TabIndex = 16;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 52);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 15;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(103, 21);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(145, 22);
            this.txtIme.TabIndex = 16;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 24);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 15;
            this.lblIme.Text = "Ime:";
            // 
            // gbPodaciODostavi
            // 
            this.gbPodaciODostavi.Controls.Add(this.lblAdres);
            this.gbPodaciODostavi.Controls.Add(this.txtAdresa);
            this.gbPodaciODostavi.Controls.Add(this.cmbxGrad);
            this.gbPodaciODostavi.Controls.Add(this.lblGrad);
            this.gbPodaciODostavi.Controls.Add(this.cmbxDrzava);
            this.gbPodaciODostavi.Controls.Add(this.lblDrzava);
            this.gbPodaciODostavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPodaciODostavi.Location = new System.Drawing.Point(293, 128);
            this.gbPodaciODostavi.Name = "gbPodaciODostavi";
            this.gbPodaciODostavi.Size = new System.Drawing.Size(275, 110);
            this.gbPodaciODostavi.TabIndex = 14;
            this.gbPodaciODostavi.TabStop = false;
            this.gbPodaciODostavi.Text = "Podaci o dostavi";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(5, 80);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(54, 16);
            this.lblAdres.TabIndex = 20;
            this.lblAdres.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(65, 79);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(175, 22);
            this.txtAdresa.TabIndex = 19;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // cmbxGrad
            // 
            this.cmbxGrad.FormattingEnabled = true;
            this.cmbxGrad.Location = new System.Drawing.Point(65, 49);
            this.cmbxGrad.Name = "cmbxGrad";
            this.cmbxGrad.Size = new System.Drawing.Size(175, 24);
            this.cmbxGrad.TabIndex = 3;
            this.cmbxGrad.SelectedIndexChanged += new System.EventHandler(this.cmbxGrad_SelectedIndexChanged);
            this.cmbxGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxGrad_Validating);
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(6, 52);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(40, 16);
            this.lblGrad.TabIndex = 2;
            this.lblGrad.Text = "Grad:";
            // 
            // cmbxDrzava
            // 
            this.cmbxDrzava.FormattingEnabled = true;
            this.cmbxDrzava.Location = new System.Drawing.Point(65, 19);
            this.cmbxDrzava.Name = "cmbxDrzava";
            this.cmbxDrzava.Size = new System.Drawing.Size(175, 24);
            this.cmbxDrzava.TabIndex = 1;
            this.cmbxDrzava.SelectedIndexChanged += new System.EventHandler(this.cmbxDrzava_SelectedIndexChanged);
            this.cmbxDrzava.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxDrzava_Validating);
            // 
            // lblDrzava
            // 
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.Location = new System.Drawing.Point(6, 22);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(53, 16);
            this.lblDrzava.TabIndex = 0;
            this.lblDrzava.Text = "Država:";
            // 
            // gbNapomena
            // 
            this.gbNapomena.Controls.Add(this.txtNapomena);
            this.gbNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNapomena.Location = new System.Drawing.Point(293, 244);
            this.gbNapomena.Name = "gbNapomena";
            this.gbNapomena.Size = new System.Drawing.Size(275, 110);
            this.gbNapomena.TabIndex = 21;
            this.gbNapomena.TabStop = false;
            this.gbNapomena.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(6, 18);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(263, 86);
            this.txtNapomena.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Image = global::Megakorpa.Properties.Resources.btnGreska;
            this.btnOtkazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtkazi.Location = new System.Drawing.Point(362, 360);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 24);
            this.btnOtkazi.TabIndex = 22;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Image = global::Megakorpa.Properties.Resources.btnTacnica;
            this.btnSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvaj.Location = new System.Drawing.Point(468, 360);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 24);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // pbNarudzbe
            // 
            this.pbNarudzbe.Image = global::Megakorpa.Properties.Resources.Korpa;
            this.pbNarudzbe.Location = new System.Drawing.Point(12, 12);
            this.pbNarudzbe.Name = "pbNarudzbe";
            this.pbNarudzbe.Size = new System.Drawing.Size(100, 100);
            this.pbNarudzbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNarudzbe.TabIndex = 10;
            this.pbNarudzbe.TabStop = false;
            // 
            // frmDodajNarudzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.gbNapomena);
            this.Controls.Add(this.gbPodaciODostavi);
            this.Controls.Add(this.gbPodaciOKupcu);
            this.Controls.Add(this.gbPodaciONarudzbi);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblProdavnica);
            this.Controls.Add(this.pbNarudzbe);
            this.Controls.Add(this.lblDodajNarudzbu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDodajNarudzbu";
            this.Text = "Dodaj narudžbu";
            this.Load += new System.EventHandler(this.frmDodajNarudzbu_Load);
            this.gbPodaciONarudzbi.ResumeLayout(false);
            this.gbPodaciONarudzbi.PerformLayout();
            this.gbPodaciOKupcu.ResumeLayout(false);
            this.gbPodaciOKupcu.PerformLayout();
            this.gbPodaciODostavi.ResumeLayout(false);
            this.gbPodaciODostavi.PerformLayout();
            this.gbNapomena.ResumeLayout(false);
            this.gbNapomena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblProdavnica;
        private System.Windows.Forms.PictureBox pbNarudzbe;
        private System.Windows.Forms.Label lblDodajNarudzbu;
        private System.Windows.Forms.GroupBox gbPodaciONarudzbi;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.ComboBox cmbxZaposlenik;
        private System.Windows.Forms.DateTimePicker dtpDatumNarudzbe;
        private System.Windows.Forms.Label lblDatumNarudzbe;
        private System.Windows.Forms.Label lblVrijemeNarudzbe;
        private System.Windows.Forms.GroupBox gbPodaciOKupcu;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.GroupBox gbPodaciODostavi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ComboBox cmbxGrad;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.ComboBox cmbxDrzava;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.GroupBox gbNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dtpVrijemeNarudzbe;
    }
}