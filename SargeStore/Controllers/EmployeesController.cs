using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SargeStore.ViewModels;

namespace SargeStore.Controllers
{
    public class EmployeesController : Controller
    {
        

        public IActionResult Index()
        {
            return View(__Employees);
        }

        public IActionResult Details(int? Id)
        {
            if (Id is null)
                return BadRequest();
            var employee = __Employees.FirstOrDefault(e => e.Id == Id);
            if (employee is null)
                return NotFound();
            return View(employee);
        }
    }
}