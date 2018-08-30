using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class HremployeeMobile
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string MobileNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
