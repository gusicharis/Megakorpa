namespace Megakorpa.Proizvodi
{
    partial class frmUrediProizvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrediProizvod));
            this.lblKvantitet = new System.Windows.Forms.Label();
            this.nudKvantitet = new System.Windows.Forms.NumericUpDown();
            this.lblKM = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.mtxtSifra = new System.Windows.Forms.MaskedTextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbxProizvodjac = new System.Windows.Forms.ComboBox();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.cmbxVrsta = new System.Windows.Forms.ComboBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblProdavnica = new System.Windows.Forms.Label();
            this.lblUrediProizvod = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.pbProizvodi = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudKvantitet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKvantitet
            // 
            this.lblKvantitet.AutoSize = true;
            this.lblKvantitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKvantitet.Location = new System.Drawing.Point(9, 356);
            this.lblKvantitet.Name = "lblKvantitet";
            this.lblKvantitet.Size = new System.Drawing.Size(60, 16);
            this.lblKvantitet.TabIndex = 70;
            this.lblKvantitet.Text = "Kvantitet:";
            // 
            // nudKvantitet
            // 
            this.nudKvantitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKvantitet.Location = new System.Drawing.Point(96, 354);
            this.nudKvantitet.Name = "nudKvantitet";
            this.nudKvantitet.Size = new System.Drawing.Size(50, 22);
            this.nudKvantitet.TabIndex = 69;
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(152, 330);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(26, 16);
            this.lblKM.TabIndex = 68;
            this.lblKM.Text = "KM";
            // 
            // txtCijena
            // 
            this.txtCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCijena.Location = new System.Drawing.Point(96, 327);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(50, 22);
            this.txtCijena.TabIndex = 67;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijena.Location = new System.Drawing.Point(9, 330);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(48, 16);
            this.lblCijena.TabIndex = 66;
            this.lblCijena.Text = "Cijena:";
            // 
            // mtxtSifra
            // 
            this.mtxtSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSifra.Location = new System.Drawing.Point(96, 299);
            this.mtxtSifra.Mask = "0000000000000";
            this.mtxtSifra.Name = "mtxtSifra";
            this.mtxtSifra.Size = new System.Drawing.Size(100, 22);
            this.mtxtSifra.TabIndex = 65;
            this.mtxtSifra.ValidatingType = typeof(int);
            this.mtxtSifra.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtSifra_MaskInputRejected);
            this.mtxtSifra.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtSifra_Validating);
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifra.Location = new System.Drawing.Point(12, 302);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(37, 16);
            this.lblSifra.TabIndex = 64;
            this.lblSifra.Text = "Šifra:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(12, 216);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(38, 16);
            this.lblOpis.TabIndex = 63;
            this.lblOpis.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(96, 213);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 80);
            this.txtOpis.TabIndex = 62;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(12, 188);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(44, 16);
            this.lblNaziv.TabIndex = 61;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(96, 185);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 22);
            this.txtNaziv.TabIndex = 60;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // cmbxProizvodjac
            // 
            this.cmbxProizvodjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxProizvodjac.FormattingEnabled = true;
            this.cmbxProizvodjac.Location = new System.Drawing.Point(96, 155);
            this.cmbxProizvodjac.Name = "cmbxProizvodjac";
            this.cmbxProizvodjac.Size = new System.Drawing.Size(200, 24);
            this.cmbxProizvodjac.TabIndex = 59;
            this.cmbxProizvodjac.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxProizvodjac_Validating);
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProizvodjac.Location = new System.Drawing.Point(12, 158);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(78, 16);
            this.lblProizvodjac.TabIndex = 58;
            this.lblProizvodjac.Text = "Proizvođač:";
            // 
            // cmbxVrsta
            // 
            this.cmbxVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxVrsta.FormattingEnabled = true;
            this.cmbxVrsta.Location = new System.Drawing.Point(96, 125);
            this.cmbxVrsta.Name = "cmbxVrsta";
            this.cmbxVrsta.Size = new System.Drawing.Size(200, 24);
            this.cmbxVrsta.TabIndex = 57;
            this.cmbxVrsta.Validating += new System.ComponentModel.CancelEventHandler(this.cmbxVrsta_Validating);
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrsta.Location = new System.Drawing.Point(12, 128);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(41, 16);
            this.lblVrsta.TabIndex = 56;
            this.lblVrsta.Text = "Vrsta:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.Orange;
            this.lblAdresa.Location = new System.Drawing.Point(122, 73);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(114, 16);
            this.lblAdresa.TabIndex = 54;
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
            this.lblProdavnica.TabIndex = 52;
            this.lblProdavnica.Text = "Megakorpa";
            // 
            // lblUrediProizvod
            // 
            this.lblUrediProizvod.AutoSize = true;
            this.lblUrediProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrediProizvod.ForeColor = System.Drawing.Color.Gray;
            this.lblUrediProizvod.Location = new System.Drawing.Point(118, 12);
            this.lblUrediProizvod.Name = "lblUrediProizvod";
            this.lblUrediProizvod.Size = new System.Drawing.Size(223, 37);
            this.lblUrediProizvod.TabIndex = 50;
            this.lblUrediProizvod.Text = "Uredi proizvod";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Image = global::Megakorpa.Properties.Resources.btnGreska;
            this.btnOtkazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtkazi.Location = new System.Drawing.Point(166, 425);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 24);
            this.btnOtkazi.TabIndex = 55;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Image = global::Megakorpa.Properties.Resources.btnTacnica;
            this.btnSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvaj.Location = new System.Drawing.Point(272, 425);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 24);
            this.btnSacuvaj.TabIndex = 53;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // pbProizvodi
            // 
            this.pbProizvodi.Image = global::Megakorpa.Properties.Resources.Proizvod;
            this.pbProizvodi.Location = new System.Drawing.Point(12, 12);
            this.pbProizvodi.Name = "pbProizvodi";
            this.pbProizvodi.Size = new System.Drawing.Size(100, 100);
            this.pbProizvodi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProizvodi.TabIndex = 51;
            this.pbProizvodi.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmUrediProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.lblKvantitet);
            this.Controls.Add(this.nudKvantitet);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.mtxtSifra);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.cmbxProizvodjac);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.cmbxVrsta);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblProdavnica);
            this.Controls.Add(this.pbProizvodi);
            this.Controls.Add(this.lblUrediProizvod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUrediProizvod";
            this.Text = "Uredi proizvod";
            this.Load += new System.EventHandler(this.frmUrediProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKvantitet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKvantitet;
        private System.Windows.Forms.NumericUpDown nudKvantitet;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.MaskedTextBox mtxtSifra;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbxProizvodjac;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.ComboBox cmbxVrsta;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblProdavnica;
        private System.Windows.Forms.PictureBox pbProizvodi;
        private System.Windows.Forms.Label lblUrediProizvod;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}