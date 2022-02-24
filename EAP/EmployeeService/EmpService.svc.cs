using EmployeeService.Data;
using EmployeeService.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmpService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmpService.svc or EmpService.svc.cs at the Solution Explorer and start debugging.
    public class EmpService : IEmpService
    {
        private MyDbContext db = new MyDbContext();
        public EmployeeDto AddNewEmployee(EmployeeDto employee)
        {
            try
            {
                var emp = db.Employees.Add(employee.toEmployee());
                db.SaveChanges();
                return emp.toEmployeeDto();
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public List<EmployeeDto> SearchEmployee(string departmentName)
        {
            List<EmployeeDto> employees = new List<EmployeeDto>();
            var results = db.Employees.Where(e => e.Department == departmentName).ToList();
            foreach(var result in results)
            {
                employees.Add(result.toEmployeeDto());
            }
            return employees;
        }
    }
}
