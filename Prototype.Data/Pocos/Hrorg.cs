using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Hrorg
    {
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public string ManagerEmpNo { get; set; }
        public DateTime? LastInterface { get; set; }
        public string OrgLevel { get; set; }
    }
}
