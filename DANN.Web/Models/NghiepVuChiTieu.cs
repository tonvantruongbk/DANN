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
    
    public partial class NghiepVuChiTieu
    {
        public System.Guid ID { get; set; }
        public System.Guid MaNghiepVu { get; set; }
        public Nullable<System.Guid> MaChiTieu { get; set; }
        public Nullable<System.Guid> MaChiTieuCha { get; set; }
        public string TenChiTieu { get; set; }
    
        public virtual DanhMucChiTieu DanhMucChiTieu { get; set; }
        public virtual DMNghiepVu DMNghiepVu { get; set; }
    }
}