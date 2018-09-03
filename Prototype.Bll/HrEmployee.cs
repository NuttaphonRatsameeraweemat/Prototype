using Prototype.Bll.Interfaces;
using Prototype.Data.Pocos;
using Prototype.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using Prototype.Bll.Models;

namespace Prototype.Bll
{
    public class HrEmployee : IHrEmployee
    {
        #region [Fields]

        /// <summary>
        /// The utilities unit of work for manipulating utilities data in database.
        /// </summary>
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// The auto mapper.
        /// </summary>
        private readonly IMapper _mapper;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HrEmployee" /> class.
        /// </summary>
        /// <param name="unitOfWork">The utilities unit of work.</param>
        public HrEmployee(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Get all employee.
        /// </summary>
        /// <returns>IEnumerable Hremployee Type</returns>
        public IEnumerable<HrEmployeeViewModel> GetEmployee()
        {
            return _mapper.Map<IEnumerable<Hremployee>, IEnumerable<HrEmployeeViewModel>>(_unitOfWork.GetRepository<Hremployee>().Get());
        }

        /// <summary>
        /// Get employee by id.
        /// </summary>
        /// <param name="EmpNo"></param>>
        /// <returns>IEnumerable Hremployee Type</returns>
        public HrEmployeeViewModel GetEmployee(string empNo)
        {
            return _mapper.Map<Hremployee, HrEmployeeViewModel>(_unitOfWork.GetRepository<Hremployee>().Get(x => x.EmpNo == empNo).FirstOrDefault());
        }

        #endregion

    }
}
