using EmployeeService.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeService.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public EmployeeDto toEmployeeDto()
        {
            return new EmployeeDto()
            {
                EmployeeID = this.EmployeeID,
                EmployeeName = this.EmployeeName,
                Birthday = this.Birthday,
                Salary = this.Salary,
                Department = this.Department,
                Email = this.Email,
                PhoneNumber = this.PhoneNumber,
                Address = this.Address,
            };
        }
    }
}