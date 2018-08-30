using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class BoardUser
    {
        public int Id { get; set; }
        public string Aduser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
