using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Hrposition
    {
        public string PosId { get; set; }
        public string PosName { get; set; }
        public string PosLevel { get; set; }
        public DateTime? LastInterface { get; set; }
    }
}
