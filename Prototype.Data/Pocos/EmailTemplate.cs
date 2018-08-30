using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class EmailTemplate
    {
        public string EmailType { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
