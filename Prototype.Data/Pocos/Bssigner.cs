using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Bssigner
    {
        public int Id { get; set; }
        public string Signer { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
