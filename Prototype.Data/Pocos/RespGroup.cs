using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class RespGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool BudgetGroup { get; set; }
        public string GroupType { get; set; }
    }
}
