using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class CompanyManagerItem
    {
        public int Id { get; set; }
        public int? CompanyManagerId { get; set; }
        public string Manager { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
