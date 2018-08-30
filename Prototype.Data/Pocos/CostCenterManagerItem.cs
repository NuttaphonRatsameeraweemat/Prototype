using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class CostCenterManagerItem
    {
        public int Id { get; set; }
        public int? CostCenterManagerId { get; set; }
        public string Manager { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
