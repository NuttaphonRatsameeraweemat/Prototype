using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Bscompany
    {
        public int Id { get; set; }
        public string Bsno { get; set; }
        public int? Seq { get; set; }
        public string ComCode { get; set; }
        public string Topic { get; set; }
        public DateTime? ValueDate { get; set; }
        public int? TotalNoCr { get; set; }
        public string BankAccount { get; set; }
        public decimal? DebitAmount { get; set; }
        public DateTime? ExportDate { get; set; }
    }
}
