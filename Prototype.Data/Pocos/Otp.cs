using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Otp
    {
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public DateTime? CommitDate { get; set; }
        public string Status { get; set; }
        public string MobileNo { get; set; }
    }
}
