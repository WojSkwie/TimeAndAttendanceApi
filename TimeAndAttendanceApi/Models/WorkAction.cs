using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TimeAndAttendanceApi.Attributes;

namespace TimeAndAttendanceApi.Models
{
    public abstract class WorkAction
    {
        [Key]
        public long Id { get; set; }

        [AcceptableDateRange]
        public DateTime ActionTime { get; set; }
    }
}