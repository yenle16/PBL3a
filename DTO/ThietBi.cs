//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThietBi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThietBi()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    
        public string ID_ThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NhaSX { get; set; }
        public string LoaiThietBi { get; set; }
        public Nullable<double> GiaNhap { get; set; }
        public Nullable<double> GiaBan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual KHO KHO { get; set; }
    }
}
