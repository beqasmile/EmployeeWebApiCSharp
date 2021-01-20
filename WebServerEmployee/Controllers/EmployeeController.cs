using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServerEmployee.Models;

namespace WebServerEmployee.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [ActionName("GetEmployee")]
        public Employee  GetEmployee()
        {
            Employee employee = new Employee();
            employee.employeeName = "Moshe";
            employee.employeeSalary = 33;
            employee.employeeId = 3;
            employee.employeeFamily = "Dovnov";

            return employee;
        }


        [HttpGet]
        [ActionName("GetEmployeeList")]
        public List<Employee> GetEmployeeList()
        {
            Employee employee = new Employee();
            employee.employeeName = "Moshe";
            employee.employeeSalary = 33;
            employee.employeeId = 2;
            employee.employeeFamily = "Dovnov";

            Employee employee2 = new Employee();
            employee2.employeeName = "Avi";
            employee2.employeeSalary = 33;
            employee2.employeeId = 3;
            employee2.employeeFamily = "Saharov";

            Employee employee2555 = new Employee();
            employee2555.employeeName = "Avi333";
            employee2555.employeeSalary = 33444;
            employee2555.employeeId = 311;
            employee2555.employeeFamily = "Saharov3333";

            List<Employee> myEmployees = new List<Employee>();
            myEmployees.Add(employee2);
            myEmployees.Add(employee);
            myEmployees.Add(employee2555);

            return myEmployees;
        }
    }
}
