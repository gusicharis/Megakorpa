namespace Megakorpa.Narudzbe
{
    partial class frmNarudzbe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNarudzbe));
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblProdavnica = new System.Windows.Forms.Label();
            this.lblNarudzbe = new System.Windows.Forms.Label();
            this.dgNarudzbe = new System.Windows.Forms.DataGridView();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaposlenik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostavljeno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblBrojNarudzbe = new System.Windows.Forms.Label();
            this.mtxtBrojNarudzbe = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblBrojRezultata = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pbNarudzbe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.lblAdresa.TabIndex = 8;
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
            this.lblProdavnica.TabIndex = 7;
            this.lblProdavnica.Text = "Megakorpa";
            // 
            // lblNarudzbe
            // 
            this.lblNarudzbe.AutoSize = true;
            this.lblNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNarudzbe.ForeColor = System.Drawing.Color.Gray;
            this.lblNarudzbe.Location = new System.Drawing.Point(118, 12);
            this.lblNarudzbe.Name = "lblNarudzbe";
            this.lblNarudzbe.Size = new System.Drawing.Size(157, 37);
            this.lblNarudzbe.TabIndex = 5;
            this.lblNarudzbe.Text = "Narudžbe";
            // 
            // dgNarudzbe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNarudzbe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNarudzbe.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgNarudzbe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNarudzbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojNarudzbe,
            this.Zaposlenik,
            this.DatumNarudzbe,
            this.VrijemeNarudzbe,
            this.Ime,
            this.Prezime,
            this.Telefon,
            this.Adresa,
            this.Grad,
            this.Napomene,
            this.Dostavljeno});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNarudzbe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNarudzbe.EnableHeadersVisualStyles = false;
            this.dgNarudzbe.Location = new System.Drawing.Point(12, 228);
            this.dgNarudzbe.Name = "dgNarudzbe";
            this.dgNarudzbe.ReadOnly = true;
            this.dgNarudzbe.RowHeadersWidth = 51;
            this.dgNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNarudzbe.Size = new System.Drawing.Size(960, 198);
            this.dgNarudzbe.TabIndex = 9;
            this.dgNarudzbe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNarudzbe_CellClick);
            this.dgNarudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNarudzbe_CellContentClick);
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "br. narudž.";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            this.BrojNarudzbe.ReadOnly = true;
            // 
            // Zaposlenik
            // 
            this.Zaposlenik.DataPropertyName = "Zaposlenik";
            this.Zaposlenik.HeaderText = "Zaposlenik";
            this.Zaposlenik.Name = "Zaposlenik";
            this.Zaposlenik.ReadOnly = true;
            // 
            // DatumNarudzbe
            // 
            this.DatumNarudzbe.DataPropertyName = "DatumNarudzbe";
            this.DatumNarudzbe.HeaderText = "Datum";
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            this.DatumNarudzbe.ReadOnly = true;
            // 
            // VrijemeNarudzbe
            // 
            this.VrijemeNarudzbe.DataPropertyName = "VrijemeNarudzbe";
            this.VrijemeNarudzbe.HeaderText = "Vrijeme";
            this.VrijemeNarudzbe.Name = "VrijemeNarudzbe";
            this.VrijemeNarudzbe.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Napomene
            // 
            this.Napomene.DataPropertyName = "Napomene";
            this.Napomene.HeaderText = "Napomene";
            this.Napomene.Name = "Napomene";
            this.Napomene.ReadOnly = true;
            this.Napomene.Visible = false;
            // 
            // Dostavljeno
            // 
            this.Dostavljeno.DataPropertyName = "Dostavljeno";
            this.Dostavljeno.HeaderText = "Dostavljeno";
            this.Dostavljeno.Name = "Dostavljeno";
            this.Dostavljeno.ReadOnly = true;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.btnOcisti);
            this.gbPretraga.Controls.Add(this.radioButton2);
            this.gbPretraga.Controls.Add(this.radioButton1);
            this.gbPretraga.Controls.Add(this.btnTrazi);
            this.gbPretraga.Controls.Add(this.txtIme);
            this.gbPretraga.Controls.Add(this.lblIme);
            this.gbPretraga.Controls.Add(this.txtPrezime);
            this.gbPretraga.Controls.Add(this.lblPrezime);
            this.gbPretraga.Controls.Add(this.lblBrojNarudzbe);
            this.gbPretraga.Controls.Add(this.mtxtBrojNarudzbe);
            this.gbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPretraga.Location = new System.Drawing.Point(12, 128);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(960, 94);
            this.gbPretraga.TabIndex = 10;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraga";
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(751, 52);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(75, 24);
            this.btnOcisti.TabIndex = 21;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(269, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 20);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Broj narudžbe";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(80, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 20);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ime i prezime";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Image = global::Megakorpa.Properties.Resources.Trazi;
            this.btnTrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrazi.Location = new System.Drawing.Point(832, 52);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(100, 24);
            this.btnTrazi.TabIndex = 11;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(142, 20);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 22);
            this.txtIme.TabIndex = 7;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(77, 23);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(142, 45);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 5;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(77, 48);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblBrojNarudzbe
            // 
            this.lblBrojNarudzbe.AutoSize = true;
            this.lblBrojNarudzbe.Location = new System.Drawing.Point(266, 23);
            this.lblBrojNarudzbe.Name = "lblBrojNarudzbe";
            this.lblBrojNarudzbe.Size = new System.Drawing.Size(93, 16);
            this.lblBrojNarudzbe.TabIndex = 0;
            this.lblBrojNarudzbe.Text = "Broj narudžbe:";
            // 
            // mtxtBrojNarudzbe
            // 
            this.mtxtBrojNarudzbe.Location = new System.Drawing.Point(380, 20);
            this.mtxtBrojNarudzbe.Mask = "00000";
            this.mtxtBrojNarudzbe.Name = "mtxtBrojNarudzbe";
            this.mtxtBrojNarudzbe.Size = new System.Drawing.Size(50, 22);
            this.mtxtBrojNarudzbe.TabIndex = 1;
            this.mtxtBrojNarudzbe.ValidatingType = typeof(int);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBrojRezultata});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblBrojRezultata
            // 
            this.lblBrojRezultata.BackColor = System.Drawing.Color.DarkOrange;
            this.lblBrojRezultata.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojRezultata.ForeColor = System.Drawing.Color.White;
            this.lblBrojRezultata.Name = "lblBrojRezultata";
            this.lblBrojRezultata.Size = new System.Drawing.Size(99, 17);
            this.lblBrojRezultata.Text = "Broj rezultata: 0";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Image = global::Megakorpa.Properties.Resources.Obrisi;
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObrisi.Location = new System.Drawing.Point(766, 12);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 100);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Image = global::Megakorpa.Properties.Resources.Dodaj;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodaj.Location = new System.Drawing.Point(872, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 100);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj...";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // pbNarudzbe
            // 
            this.pbNarudzbe.Image = global::Megakorpa.Properties.Resources.Korpa;
            this.pbNarudzbe.Location = new System.Drawing.Point(12, 12);
            this.pbNarudzbe.Name = "pbNarudzbe";
            this.pbNarudzbe.Size = new System.Drawing.Size(100, 100);
            this.pbNarudzbe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNarudzbe.TabIndex = 6;
            this.pbNarudzbe.TabStop = false;
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbPretraga);
            this.Controls.Add(this.dgNarudzbe);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblProdavnica);
            this.Controls.Add(this.pbNarudzbe);
            this.Controls.Add(this.lblNarudzbe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNarudzbe";
            this.Text = "Narudžbe";
            this.Load += new System.EventHandler(this.frmNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNarudzbe)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblProdavnica;
        private System.Windows.Forms.PictureBox pbNarudzbe;
        private System.Windows.Forms.Label lblNarudzbe;
        private System.Windows.Forms.DataGridView dgNarudzbe;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.MaskedTextBox mtxtBrojNarudzbe;
        private System.Windows.Forms.Label lblBrojNarudzbe;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblBrojRezultata;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaposlenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomene;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dostavljeno;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnOcisti;
    }
}