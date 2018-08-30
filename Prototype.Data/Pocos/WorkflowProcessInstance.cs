using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class WorkflowProcessInstance
    {
        public int ProcessInstanceId { get; set; }
        public string ProcessCode { get; set; }
        public int? DataId { get; set; }
        public int? CurrentStep { get; set; }
        public string Status { get; set; }
    }
}
