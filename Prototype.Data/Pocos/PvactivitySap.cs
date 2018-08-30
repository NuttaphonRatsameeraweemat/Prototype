using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class PvactivitySap
    {
        public int Id { get; set; }
        public string Pvno { get; set; }
        public int? ProcessInstanceId { get; set; }
        public string Step { get; set; }
        public string Activity { get; set; }
        public string ActionId { get; set; }
        public string ActionType { get; set; }
        public string Action { get; set; }
        public string ActionName { get; set; }
        public DateTime? ActionDate { get; set; }
        public string Comment { get; set; }
        public string AllocateUser { get; set; }
        public int? Pvsapid { get; set; }
    }
}
