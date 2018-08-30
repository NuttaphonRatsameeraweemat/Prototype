using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class WorkflowDelegate
    {
        public int Id { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
