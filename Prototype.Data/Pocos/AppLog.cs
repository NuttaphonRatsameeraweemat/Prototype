using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class AppLog
    {
        public int Id { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogBy { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }
    }
}
