using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        Employee obj = new Employee();
        Employee obj1 = new Employee();
List<Employee> employees = new List<Employee>();
//OrganizationEntites db=new OrganizationEntites();
//List<Employee> employees=db.Employees.ToList();
        // GET: Employee
        public ActionResult GetDetail()
        {
            obj.Empid = 100;
            obj.Empname = "Shrivalli";
            obj.Salary = 23000;
            obj1.Empid = 101;
            obj1.Empname = "Vandhana";
            obj1.Salary = 53000;
            employees.Add(obj);
            employees.Add(obj1);
            return View(employees);
        }
    }
}