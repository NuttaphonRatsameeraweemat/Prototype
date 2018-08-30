using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class AppMenu
    {
        public string MenuCode { get; set; }
        public string ResourceName { get; set; }
        public string MenuType { get; set; }
        public string ParentMenuCode { get; set; }
        public int? Sequence { get; set; }
        public string RoleForManage { get; set; }
        public string RoleForDisplay { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Area { get; set; }
        public string Icon { get; set; }
    }
}
