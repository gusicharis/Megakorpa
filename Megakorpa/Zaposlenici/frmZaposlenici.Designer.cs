namespace Megakorpa.Zaposlenici
{
    partial class frmZaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaposlenici));
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblProdavnica = new System.Windows.Forms.Label();
            this.pbZaposlenici = new System.Windows.Forms.PictureBox();
            this.lblZaposlenici = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblBrojRezultata = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgZaposlenici = new System.Windows.Forms.DataGridView();
            this.ZaposlenikID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadnoMjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbZaposlenici)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposlenici)).BeginInit();
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
            // pbZaposlenici
            // 
            this.pbZaposlenici.Image = global::Megakorpa.Properties.Resources.Zaposlenici;
            this.pbZaposlenici.Location = new System.Drawing.Point(12, 12);
            this.pbZaposlenici.Name = "pbZaposlenici";
            this.pbZaposlenici.Size = new System.Drawing.Size(100, 100);
            this.pbZaposlenici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZaposlenici.TabIndex = 10;
            this.pbZaposlenici.TabStop = false;
            // 
            // lblZaposlenici
            // 
            this.lblZaposlenici.AutoSize = true;
            this.lblZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenici.ForeColor = System.Drawing.Color.Gray;
            this.lblZaposlenici.Location = new System.Drawing.Point(118, 12);
            this.lblZaposlenici.Name = "lblZaposlenici";
            this.lblZaposlenici.Size = new System.Drawing.Size(179, 37);
            this.lblZaposlenici.TabIndex = 9;
            this.lblZaposlenici.Text = "Zaposlenici";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBrojRezultata});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 13;
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
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Image = global::Megakorpa.Properties.Resources.Dodaj;
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDodaj.Location = new System.Drawing.Point(874, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 100);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj...";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgZaposlenici
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgZaposlenici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgZaposlenici.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgZaposlenici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgZaposlenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZaposlenikID,
            this.RadnoMjesto,
            this.Ime,
            this.Prezime,
            this.DatumRodjenja,
            this.JMBG,
            this.KorisnickoIme,
            this.Telefon,
            this.EMail,
            this.Adresa,
            this.Grad,
            this.Napomene});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgZaposlenici.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgZaposlenici.EnableHeadersVisualStyles = false;
            this.dgZaposlenici.Location = new System.Drawing.Point(14, 164);
            this.dgZaposlenici.Name = "dgZaposlenici";
            this.dgZaposlenici.ReadOnly = true;
            this.dgZaposlenici.RowHeadersWidth = 51;
            this.dgZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgZaposlenici.Size = new System.Drawing.Size(960, 262);
            this.dgZaposlenici.TabIndex = 14;
            this.dgZaposlenici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgZaposlenici_CellClick);
            // 
            // ZaposlenikID
            // 
            this.ZaposlenikID.DataPropertyName = "ZaposlenikID";
            this.ZaposlenikID.HeaderText = "ZaposlenikID";
            this.ZaposlenikID.Name = "ZaposlenikID";
            this.ZaposlenikID.ReadOnly = true;
            this.ZaposlenikID.Visible = false;
            // 
            // RadnoMjesto
            // 
            this.RadnoMjesto.DataPropertyName = "RadnoMjesto";
            this.RadnoMjesto.HeaderText = "Rad. mj. ";
            this.RadnoMjesto.Name = "RadnoMjesto";
            this.RadnoMjesto.ReadOnly = true;
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
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođ.";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // JMBG
            // 
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Username";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.DataPropertyName = "EMail";
            this.EMail.HeaderText = "E-Mail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
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
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Image = global::Megakorpa.Properties.Resources.Obrisi;
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnObrisi.Location = new System.Drawing.Point(768, 12);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 100);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgZaposlenici);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblProdavnica);
            this.Controls.Add(this.pbZaposlenici);
            this.Controls.Add(this.lblZaposlenici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmZaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZaposlenici)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblProdavnica;
        private System.Windows.Forms.PictureBox pbZaposlenici;
        private System.Windows.Forms.Label lblZaposlenici;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblBrojRezultata;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadnoMjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomene;
        private System.Windows.Forms.Button btnObrisi;
    }
}