using EmployeeService.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpService" in both code and config file together.
    [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        EmployeeDto AddNewEmployee(EmployeeDto employee);
        [OperationContract]
        List<EmployeeDto> SearchEmployee(string departmentName);
    }
}
