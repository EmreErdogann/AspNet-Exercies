//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineKutuphanem.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cezalar
    {
        public int ID { get; set; }
        public Nullable<int> UYE { get; set; }
        public Nullable<System.DateTime> BASLANGICTARIHI { get; set; }
        public Nullable<System.DateTime> BITISTARIHI { get; set; }
        public Nullable<decimal> PARA { get; set; }
        public Nullable<int> HAREKET { get; set; }
    
        public virtual Hareket Hareket1 { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
