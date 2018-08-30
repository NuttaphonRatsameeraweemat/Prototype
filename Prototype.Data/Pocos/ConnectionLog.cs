using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class ConnectionLog
    {
        public int Id { get; set; }
        public string LogType { get; set; }
        public DateTime? LogDate { get; set; }
        public string User { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public string UserAgent { get; set; }
        public string BrowserVersion { get; set; }
        public string BrowserType { get; set; }
        public bool? IsMobile { get; set; }
        public string MobileModel { get; set; }
        public string MobileManufacturer { get; set; }
        public string DocumentNo { get; set; }
    }
}
