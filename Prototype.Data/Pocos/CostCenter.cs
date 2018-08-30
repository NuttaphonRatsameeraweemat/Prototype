using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class CostCenter
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
