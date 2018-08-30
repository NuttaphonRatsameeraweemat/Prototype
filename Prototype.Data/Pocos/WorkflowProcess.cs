using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class WorkflowProcess
    {
        public string ProcessCode { get; set; }
        public string ProcessName { get; set; }
        public string K2workflowProcess { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public bool? AllowConfig { get; set; }
        public bool? RejectToInbox { get; set; }
    }
}
