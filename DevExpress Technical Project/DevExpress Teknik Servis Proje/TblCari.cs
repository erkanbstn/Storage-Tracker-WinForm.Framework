//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExpress_Teknik_Servis_Proje
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblCari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblCari()
        {
            this.TblFaturaBilgi = new HashSet<TblFaturaBilgi>();
            this.TblÜrünHareket = new HashSet<TblÜrünHareket>();
            this.TblÜrünKabul = new HashSet<TblÜrünKabul>();
        }
    
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string İl { get; set; }
        public string İlçe { get; set; }
        public string Banka { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Statü { get; set; }
        public string Adres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFaturaBilgi> TblFaturaBilgi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblÜrünHareket> TblÜrünHareket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblÜrünKabul> TblÜrünKabul { get; set; }
    }
}
