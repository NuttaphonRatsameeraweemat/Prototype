using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class WorkflowActivityStep
    {
        public int ProcessInstanceId { get; set; }
        public int Step { get; set; }
        public string ActionUser { get; set; }
        public string Activity { get; set; }
        public string FormState { get; set; }
        public string State { get; set; }
        public string ActionUserCode { get; set; }
        public string ActionUserPosition { get; set; }
        public string ActionUserOrg { get; set; }
    }
}
