using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class ConfigureValue
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
