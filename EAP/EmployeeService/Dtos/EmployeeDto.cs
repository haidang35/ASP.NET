using EmployeeService.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeService.Dtos
{
    [DataContract]
    public class EmployeeDto
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [Required]
        [DataMember]
        public string EmployeeName { get; set; }
        [Required]
        [DataMember]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required]
        [DataMember]
        public double Salary { get; set; }
        [Required]
        [DataMember]
        public string Department { get; set; }
        [Required]
        [DataMember]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string Address { get; set; }

        public Employee toEmployee()
        {
            return new Employee()
            {
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