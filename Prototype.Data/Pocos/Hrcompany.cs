using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Hrcompany
    {
        public string ComCode { get; set; }
        public string SapcomCode { get; set; }
        public string ShortText { get; set; }
        public string LongText { get; set; }
        public DateTime? LastInterface { get; set; }
        public string Email { get; set; }
    }
}
