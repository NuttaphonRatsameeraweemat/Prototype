using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class AppDocumentNo
    {
        public string ProcessCode { get; set; }
        public string DocumentNoPrefix { get; set; }
        public int? LastRunningNo { get; set; }
        public int? RunningNoDigit { get; set; }
        public short Year { get; set; }
        public string Additional01 { get; set; }
        public string Additional02 { get; set; }
        public string Additional03 { get; set; }
    }
}
