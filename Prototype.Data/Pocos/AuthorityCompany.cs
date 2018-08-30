using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class AuthorityCompany
    {
        public int Id { get; set; }
        public string Aduser { get; set; }
        public bool? Brb { get; set; }
        public bool? Brt { get; set; }
        public bool? Sco { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
