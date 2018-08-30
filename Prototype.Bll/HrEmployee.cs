using Prototype.Bll.Interfaces;
using Prototype.Data.Pocos;
using Prototype.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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

        #endregion

    }
}
