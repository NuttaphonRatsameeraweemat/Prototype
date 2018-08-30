using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class ReviewManagerItem
    {
        public int Id { get; set; }
        public int? ReviewManagerId { get; set; }
        public string Reviewer { get; set; }
        public string ComCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
