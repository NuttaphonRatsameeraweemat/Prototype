using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype.Bll.Interfaces;

namespace Prototype.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrEmployeeController : ControllerBase
    {

        #region [Fields]

        /// <summary>
        /// The HR Employee manager provides HR Employee functionality.
        /// </summary>
        private readonly IHrEmployee _hremployee;

        #endregion

        #region [Constructors]

        /// <summary>
        ///  Initializes a new instance of the <see cref="HrEmployeeController" /> class.
        /// </summary>
        /// <param name="hremployee"></param>
        public HrEmployeeController(IHrEmployee hremployee)
        {
            _hremployee = hremployee;
        }

        #endregion

        #region [Methods]

        [HttpGet]
        [Route("GetEmployee")]
        public IActionResult GetEmployee()
        {
            return Ok(_hremployee.GetEmployee());
        }

        #endregion

    }
}