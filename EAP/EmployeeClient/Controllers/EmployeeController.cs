using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeClient.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeService.EmpServiceClient employeeClient = new EmployeeService.EmpServiceClient();
        // GET: Employee
        [HttpGet]
        public ActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewEmployee(EmployeeService.EmployeeDto employee)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var emp = employeeClient.AddNewEmployee(employee);
                    if(emp != null)
                    {
                        TempData["Message"] = "Add new employee successfully !";
                        return RedirectToAction("EmployeeList");
                    }
                }
            }
            catch(Exception e)
            {

            }
            return View();
        }

        [HttpGet]
        public ActionResult EmployeeList(string departmentName)
        {
            var employees = employeeClient.SearchEmployee(departmentName);
            return View(employees);
        }
    }
}