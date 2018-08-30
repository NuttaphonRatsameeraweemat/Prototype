using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Pvgroup
    {
        public int Id { get; set; }
        public string PvgroupNo { get; set; }
        public string PvgroupType { get; set; }
        public DateTime? PvgroupDate { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public string CreatePos { get; set; }
        public string CreateOrg { get; set; }
        public DateTime? CreateDate { get; set; }
        public string OrgName { get; set; }
        public string ComCode { get; set; }
    }
}
