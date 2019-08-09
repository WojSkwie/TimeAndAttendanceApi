using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeAndAttendanceApi.Attributes
{
    public class AcceptableDateRangeAttribute : RangeAttribute
    {
        public AcceptableDateRangeAttribute() : base(typeof(DateTime),
            new DateTime(2000,1,1).ToShortDateString(),
            new DateTime(2050,1,1).ToShortDateString())
        {

        }

        public AcceptableDateRangeAttribute(DateTime minDate, DateTime maxDate) : base(typeof(DateTime),
            minDate.ToShortDateString(),
            maxDate.ToShortDateString())
        {

        }



    }
}