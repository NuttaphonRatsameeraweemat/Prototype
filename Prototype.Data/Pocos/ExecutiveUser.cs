using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class ExecutiveUser
    {
        public int Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Aduser { get; set; }
        public bool? NoReport { get; set; }
    }
}
