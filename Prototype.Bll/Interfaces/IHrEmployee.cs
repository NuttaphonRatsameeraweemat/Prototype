using System;
using System.Collections.Generic;
using System.Text;
using Prototype.Bll.Models;
using Prototype.Data.Pocos;

namespace Prototype.Bll.Interfaces
{
    public interface IHrEmployee
    {
        IEnumerable<HrEmployeeViewModel> GetEmployee();

        HrEmployeeViewModel GetEmployee(string empNo);
    }
}
