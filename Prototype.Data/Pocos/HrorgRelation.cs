using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class HrorgRelation
    {
        public string ParentOrgId { get; set; }
        public string ParentOrgName { get; set; }
        public string ChildOrgId { get; set; }
        public string ChildOrgName { get; set; }
        public DateTime? LastInterface { get; set; }
    }
}
