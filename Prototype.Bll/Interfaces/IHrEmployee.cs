using System;
using System.Collections.Generic;
using System.Text;
using Prototype.Data.Pocos;

namespace Prototype.Bll.Interfaces
{
    public interface IHrEmployee
    {
        IEnumerable<Hremployee> GetEmployee();
    }
}
