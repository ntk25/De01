//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace De01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sinhvien
    {
        public string MaSV { get; set; }
        public string HotenSV { get; set; }
        public string MaLop { get; set; }
    
        public virtual Lop Lop { get; set; }
    }
}
