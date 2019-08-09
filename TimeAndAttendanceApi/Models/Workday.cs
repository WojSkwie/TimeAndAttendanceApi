using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TimeAndAttendanceApi.Attributes;

namespace TimeAndAttendanceApi.Models
{
    public class Workday
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [AcceptableDateRange]
        public DateTime StartTime { get; set; }

        [Required]
        [AcceptableDateRange]
        public DateTime EndTime { get; set; }
        [Required]
        public Employee Employee { get; set; }

        [Required]
        public WorkdayType WorkdayType { get; set; }

        
    }
}