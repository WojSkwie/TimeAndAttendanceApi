using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeAndAttendanceApi.Models
{
    public class WorkdayType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [Range(0,1)]
        public double SalaryCoefficient { get; set; }
    }

    public enum EWorkdayType
    {
        normal = 1,
        vacation = 2,
        onRequest = 3,
        sickLeave = 4
    }
}