//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErdemEmlak.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ilan
    {
        public int ilanId { get; set; }
        public string baslik { get; set; }
        public Nullable<int> fiyat { get; set; }
        public string adres { get; set; }
        public string aciklama { get; set; }
        public Nullable<int> sehirId { get; set; }
        public string foto { get; set; }
        public Nullable<int> uyeId { get; set; }
    
        public virtual Sehir Sehir { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
