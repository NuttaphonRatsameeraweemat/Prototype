using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Bll.Models
{
    public class HrEmployeeViewModel
    {
        public string EmpNo { get; set; }
        public string TitleTh { get; set; }
        public string FirstnameTh { get; set; }
        public string LastnameTh { get; set; }
        public string TitleEn { get; set; }
        public string FirstnameEn { get; set; }
        public string LastnameEn { get; set; }
        public string Email { get; set; }
        public string Aduser { get; set; }
        public string MobileNo { get; set; }
        public string OfficeTel { get; set; }
        public string Idcard { get; set; }
        public string EmpStatus { get; set; }
        public string GradeCode { get; set; }
        public string GradeText { get; set; }
        public string PositionId { get; set; }
        public string OrgId { get; set; }
        public string ManagerEmpNo { get; set; }
        public DateTime? LastInterface { get; set; }
        public string ComCode { get; set; }
        public DateTime? BirthDate { get; set; }

        public string FullnameTh
        {
            get
            {
                return string.Format("{0}{1} {2}", TitleTh, FirstnameTh, LastnameTh);
            }
        }

        public string FullnameEn
        {
            get
            {
                return string.Format("{0}{1} {2}", TitleEn, FirstnameEn, LastnameEn);
            }
        }

    }
}
