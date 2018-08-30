using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class AppCompositeRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string LastModifyBy { get; set; }
    }
}
