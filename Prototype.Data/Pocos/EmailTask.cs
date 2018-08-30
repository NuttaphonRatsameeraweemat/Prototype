using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class EmailTask
    {
        public int Id { get; set; }
        public DateTime TaskDate { get; set; }
        public string TaskCode { get; set; }
        public string TaskBy { get; set; }
        public string DocNo { get; set; }
        public string Subject { get; set; }
        public string Status { get; set; }
    }
}
