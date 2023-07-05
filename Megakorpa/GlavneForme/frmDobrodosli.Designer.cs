namespace Megakorpa.GlavneForme
{
    partial class frmDobrodosli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDobrodosli));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblZaposlenik = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRazmak = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDatumVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.lblProdavnica = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.panelNarudzbe = new System.Windows.Forms.Panel();
            this.lblNarudzbe = new System.Windows.Forms.Label();
            this.panelProizvodi = new System.Windows.Forms.Panel();
            this.lblUkupnoProizvoda = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.panelNarudzbe.SuspendLayout();
            this.panelProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DarkOrange;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblZaposlenik,
            this.lblRazmak,
            this.lblDatumVrijeme});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaposlenik.ForeColor = System.Drawing.Color.White;
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(70, 17);
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // lblRazmak
            // 
            this.lblRazmak.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazmak.ForeColor = System.Drawing.Color.White;
            this.lblRazmak.Name = "lblRazmak";
            this.lblRazmak.Size = new System.Drawing.Size(800, 17);
            this.lblRazmak.Spring = true;
            // 
            // lblDatumVrijeme
            // 
            this.lblDatumVrijeme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatumVrijeme.ForeColor = System.Drawing.Color.White;
            this.lblDatumVrijeme.Name = "lblDatumVrijeme";
            this.lblDatumVrijeme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDatumVrijeme.Size = new System.Drawing.Size(99, 17);
            this.lblDatumVrijeme.Text = "Datum i vrijeme";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.ForeColor = System.Drawing.Color.Gray;
            this.lblDobrodosli.Location = new System.Drawing.Point(118, 12);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(189, 37);
            this.lblDobrodosli.TabIndex = 1;
            this.lblDobrodosli.Text = "Dobrodošli! ";
            this.lblDobrodosli.Click += new System.EventHandler(this.lblDobrodosli_Click);
            // 
            // lblProdavnica
            // 
            this.lblProdavnica.AutoSize = true;
            this.lblProdavnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdavnica.ForeColor = System.Drawing.Color.Orange;
            this.lblProdavnica.Location = new System.Drawing.Point(121, 49);
            this.lblProdavnica.Name = "lblProdavnica";
            this.lblProdavnica.Size = new System.Drawing.Size(105, 24);
            this.lblProdavnica.TabIndex = 3;
            this.lblProdavnica.Text = "Megakorpa";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresa.ForeColor = System.Drawing.Color.Orange;
            this.lblAdresa.Location = new System.Drawing.Point(122, 73);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(114, 16);
            this.lblAdresa.TabIndex = 4;
            this.lblAdresa.Text = "Alekse Šantića 10";
            // 
            // panelNarudzbe
            // 
            this.panelNarudzbe.BackColor = System.Drawing.Color.Orange;
            this.panelNarudzbe.Controls.Add(this.lblNarudzbe);
            this.panelNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelNarudzbe.ForeColor = System.Drawing.Color.White;
            this.panelNarudzbe.Location = new System.Drawing.Point(722, 128);
            this.panelNarudzbe.Name = "panelNarudzbe";
            this.panelNarudzbe.Size = new System.Drawing.Size(250, 100);
            this.panelNarudzbe.TabIndex = 8;
            // 
            // lblNarudzbe
            // 
            this.lblNarudzbe.AutoSize = true;
            this.lblNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNarudzbe.Location = new System.Drawing.Point(3, 5);
            this.lblNarudzbe.Name = "lblNarudzbe";
            this.lblNarudzbe.Size = new System.Drawing.Size(192, 24);
            this.lblNarudzbe.TabIndex = 0;
            this.lblNarudzbe.Text = "Ukupno narudžbi: 0";
            // 
            // panelProizvodi
            // 
            this.panelProizvodi.BackColor = System.Drawing.Color.LimeGreen;
            this.panelProizvodi.Controls.Add(this.lblUkupnoProizvoda);
            this.panelProizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProizvodi.ForeColor = System.Drawing.Color.White;
            this.panelProizvodi.Location = new System.Drawing.Point(722, 234);
            this.panelProizvodi.Name = "panelProizvodi";
            this.panelProizvodi.Size = new System.Drawing.Size(250, 100);
            this.panelProizvodi.TabIndex = 9;
            // 
            // lblUkupnoProizvoda
            // 
            this.lblUkupnoProizvoda.AutoSize = true;
            this.lblUkupnoProizvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnoProizvoda.Location = new System.Drawing.Point(3, 5);
            this.lblUkupnoProizvoda.Name = "lblUkupnoProizvoda";
            this.lblUkupnoProizvoda.Size = new System.Drawing.Size(202, 24);
            this.lblUkupnoProizvoda.TabIndex = 0;
            this.lblUkupnoProizvoda.Text = "Ukupno proizvoda: 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Megakorpa.Properties.Resources.kontakt;
            this.pictureBox2.Location = new System.Drawing.Point(407, 228);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaposlenici.Image = global::Megakorpa.Properties.Resources.btnZaposlenici;
            this.btnZaposlenici.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZaposlenici.Location = new System.Drawing.Point(12, 234);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(206, 100);
            this.btnZaposlenici.TabIndex = 7;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnZaposlenici.UseVisualStyleBackColor = false;
            this.btnZaposlenici.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProizvodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProizvodi.Image = global::Megakorpa.Properties.Resources.btnProizvod;
            this.btnProizvodi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProizvodi.Location = new System.Drawing.Point(118, 128);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(100, 100);
            this.btnProizvodi.TabIndex = 6;
            this.btnProizvodi.Text = "Proizvodi";
            this.btnProizvodi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProizvodi.UseVisualStyleBackColor = false;
            this.btnProizvodi.Click += new System.EventHandler(this.btnProizvodi_Click);
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNarudzbe.Image = global::Megakorpa.Properties.Resources.btnKorpa1;
            this.btnNarudzbe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNarudzbe.Location = new System.Drawing.Point(12, 128);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(100, 100);
            this.btnNarudzbe.TabIndex = 5;
            this.btnNarudzbe.Text = "Narudžbe";
            this.btnNarudzbe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Megakorpa.Properties.Resources.Prodavnica;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(376, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kontaktiraj podršku";
            // 
            // frmDobrodosli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelProizvodi);
            this.Controls.Add(this.panelNarudzbe);
            this.Controls.Add(this.btnZaposlenici);
            this.Controls.Add(this.btnProizvodi);
            this.Controls.Add(this.btnNarudzbe);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblProdavnica);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDobrodosli";
            this.Text = "Dobrodošli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDobrodosli_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDobrodosli_FormClosed);
            this.Load += new System.EventHandler(this.frmDobrodosli_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelNarudzbe.ResumeLayout(false);
            this.panelNarudzbe.PerformLayout();
            this.panelProizvodi.ResumeLayout(false);
            this.panelProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblZaposlenik;
        private System.Windows.Forms.ToolStripStatusLabel lblDatumVrijeme;
        private System.Windows.Forms.ToolStripStatusLabel lblRazmak;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProdavnica;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Panel panelNarudzbe;
        private System.Windows.Forms.Label lblNarudzbe;
        private System.Windows.Forms.Panel panelProizvodi;
        private System.Windows.Forms.Label lblUkupnoProizvoda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}