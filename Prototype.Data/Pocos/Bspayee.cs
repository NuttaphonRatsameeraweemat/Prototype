using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Bspayee
    {
        public int Id { get; set; }
        public int? BscompanyId { get; set; }
        public int? Seq { get; set; }
        public string ComCode { get; set; }
        public int? TopicId { get; set; }
        public string BankAccount { get; set; }
        public string FiDoc { get; set; }
        public string PayeeTaxId { get; set; }
        public string PayeeName { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
    }
}
