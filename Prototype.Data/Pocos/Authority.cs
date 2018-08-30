using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Authority
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string ComCode { get; set; }
        public decimal? Remark1 { get; set; }
        public decimal? Remark2 { get; set; }
        public decimal? Remark3 { get; set; }
        public decimal? Remark4 { get; set; }
        public decimal? Remark5 { get; set; }
        public string Status { get; set; }
        public DateTime? LastInterface { get; set; }
    }
}
