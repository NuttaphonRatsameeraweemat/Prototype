using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class EmailTaskContent
    {
        public int Id { get; set; }
        public int EmailTaskId { get; set; }
        public string Content { get; set; }
    }
}
