using Prototype.Bll.Interfaces;
using Prototype.Data.Pocos;
using Prototype.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Prototype.Bll
{
    public class HrEmployee : IHrEmployee
    {
        #region [Fields]

        /// <summary>
        /// The utilities unit of work for manipulating utilities data in database.
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HrEmployee" /> class.
        /// </summary>
        /// <param name="unitOfWork">The utilities unit of work.</param>
        public HrEmployee(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get all employee.
        /// </summary>
        /// <returns>IEnumerable Hremployee Type</returns>
        public IEnumerable<Hremployee> GetEmployee()
        {
            return _unitOfWork.GetRepository<Hremployee>().Get();
        }

        /// <summary>
        /// Get employee by id.
        /// </summary>
        /// <param name="EmpNo"></param>>
        /// <returns>IEnumerable Hremployee Type</returns>
        public Hremployee GetEmployee(string empNo)
        {
            return _unitOfWork.GetRepository<Hremployee>().Get(x => x.EmpNo == empNo).FirstOrDefault();
        }

        #endregion

    }
}
