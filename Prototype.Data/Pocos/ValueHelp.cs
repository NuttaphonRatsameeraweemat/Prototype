using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class ValueHelp
    {
        public int Id { get; set; }
        public string ValueType { get; set; }
        public string ValueKey { get; set; }
        public string ValueText { get; set; }
        public int? Sequence { get; set; }
        public string Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string LastModifyBy { get; set; }
    }
}
