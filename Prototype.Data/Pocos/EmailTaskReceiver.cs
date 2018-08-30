using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class EmailTaskReceiver
    {
        public int Id { get; set; }
        public int EmailTaskId { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string ReceiverType { get; set; }
    }
}
