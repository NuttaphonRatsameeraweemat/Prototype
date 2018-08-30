using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class Bs
    {
        public int Id { get; set; }
        public string Bsno { get; set; }
        public DateTime? Bsdate { get; set; }
        public string BankCode { get; set; }
        public string ProductCode { get; set; }
        public string To { get; set; }
        public string Topic { get; set; }
        public string Status { get; set; }
        public string CreateBy { get; set; }
        public string CreatePos { get; set; }
        public string CreateOrg { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastModifyBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string TopicDate { get; set; }
        public string TopicDetail { get; set; }
    }
}
