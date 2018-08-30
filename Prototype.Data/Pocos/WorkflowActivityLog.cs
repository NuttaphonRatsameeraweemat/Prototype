using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class WorkflowActivityLog
    {
        public int ProcessInstanceId { get; set; }
        public int? Step { get; set; }
        public string SerialNo { get; set; }
        public string ActionUser { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Action { get; set; }
        public string Comment { get; set; }
        public string AllocatedUser { get; set; }
        public string ActionUserCode { get; set; }
        public string ActionUserPosition { get; set; }
        public string ActionUserOrg { get; set; }
    }
}
