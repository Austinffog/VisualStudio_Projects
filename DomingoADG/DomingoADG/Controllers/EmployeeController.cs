using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomingoADG.Models;
using DomingoADG.Respository;

namespace DomingoADG.Controllers
{
    public class EmployeeController : Controller
    {
        //Get: Get employee/All employees
        public ActionResult GetEmployees()
        {
            EmployeeRespository EmployeeRepo = new EmployeeRespository();
            ModelState.Clear();
            return View(EmployeeRepo.GetEmployee());
        }

        //Get: Get employee/Return employee
        public ActionResult CreateEmployee()
        {
            return View();
        }

        //Post: Create Employee
        [HttpPost]
        public ActionResult CreateEmployee(EmployeeModel Pat)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeRespository EmployeeRepo = new EmployeeRespository();
                    if (EmployeeRepo.CreateEmployee(Pat))
                    {
                        ViewBag.Message = "Details added successfully.";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee Update 
        public ActionResult UpdateEmployee(int emp)
        {
            EmployeeRespository EmployeeRepo = new EmployeeRespository();
            return View(EmployeeRepo.GetEmployee().Find(Employee => Employee.employee_no == emp));
        }

        //Post: Employee Update
        [HttpPost]
        public ActionResult UpdateEmployee(int emp, EmployeeModel obj)
        {
            try
            {
                EmployeeRespository EmployeeRepo = new EmployeeRespository();
                EmployeeRepo.UpdateEmployee(obj);

                return RedirectToAction("GetEmployee");
            }
            catch
            {
                return View();
            }
        }
    }
}
