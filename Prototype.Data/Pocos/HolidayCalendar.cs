using System;
using System.Collections.Generic;

namespace Prototype.Data.Pocos
{
    public partial class HolidayCalendar
    {
        public int Id { get; set; }
        public short? Year { get; set; }
        public DateTime? HolidayDate { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? LastModifyDate { get; set; }
        public string LastModifyBy { get; set; }
        public bool? PublicHoliday { get; set; }
    }
}
