using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeAndAttendanceApi.Models
{
    public class Employee
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }
        public double? Salary { get; set; }
        [Required]
        public ContractType ContractType { get; set; }
        
    }

    public enum ContractType
    {
        civilContract,
        employmentContract,
        b2b,
        commissionContract
    }
}