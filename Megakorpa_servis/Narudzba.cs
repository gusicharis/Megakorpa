//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Megakorpa_servis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Narudzba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzba()
        {
            this.NarudzbaProizvods = new HashSet<NarudzbaProizvod>();
        }
    
        public int NarudzbaID { get; set; }
        public int ZaposlenikID { get; set; }
        public System.DateTime DatumNarudzbe { get; set; }
        public System.TimeSpan VrijemeNarudzbe { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public int GradID { get; set; }
        public string Napomene { get; set; }
        public bool Dostavljeno { get; set; }
    
        public virtual Grad Grad { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NarudzbaProizvod> NarudzbaProizvods { get; set; }
    }
}
