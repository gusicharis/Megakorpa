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
    
    public partial class Proizvod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proizvod()
        {
            this.NarudzbaProizvods = new HashSet<NarudzbaProizvod>();
        }
    
        public int ProizvodID { get; set; }
        public int VrstaProizvodaID { get; set; }
        public int ProizvodjacID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int Kvantitet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NarudzbaProizvod> NarudzbaProizvods { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
        public virtual VrstaProizvoda VrstaProizvoda { get; set; }
    }
}
