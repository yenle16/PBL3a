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
    
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }
    
        public string ID_HoaDon { get; set; }
        public string ID_KhuyenMai { get; set; }
        public Nullable<double> PhanTram { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public Nullable<System.DateTime> NgayMuaHang { get; set; }
        public Nullable<double> TongTien { get; set; }
        public string ID_NV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
