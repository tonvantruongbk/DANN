//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DANN.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhMucNhomChiTieu
    {
        public DanhMucNhomChiTieu()
        {
            this.DanhMucChiTieux = new HashSet<DanhMucChiTieu>();
        }
    
        public System.Guid MaNhomChiTieu { get; set; }
        public string KyHieu { get; set; }
        public string TenNhomChiTieu { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public string NguoiCapNhat { get; set; }
        public bool KhongSuDung { get; set; }
    
        public virtual ICollection<DanhMucChiTieu> DanhMucChiTieux { get; set; }
    }
}