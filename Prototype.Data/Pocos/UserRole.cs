using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int? CompositeRoleId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string LastModifyBy { get; set; }
    }
}
