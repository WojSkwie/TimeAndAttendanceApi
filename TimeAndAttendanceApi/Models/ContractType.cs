using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeAndAttendanceApi.Models
{
    public class ContractType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public enum EContractType
    {
        civilContract = 1,
        employmentContract = 2,
        b2b = 3,
        commissionContract = 4
    }
}