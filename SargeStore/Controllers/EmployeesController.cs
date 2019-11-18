using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SargeStore.ViewModels;
using SargeStore.Infrastructure.Services;
using SargeStore.Infrastructure.Conventions.Interfaces;

namespace SargeStore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _EmployeesData;

        public EmployeesController(IEmployeesData EmployeesData)
        {
            _EmployeesData = EmployeesData;
        }

        public IActionResult Index()
        {
            return View(_EmployeesData.GetAll());
        }

        public IActionResult Details(int? Id)
        {
            if (Id is null)
                return BadRequest();
            var employee = _EmployeesData.GetById((int)Id);
            if (employee is null)
                return NotFound();
            return View(employee);
        }

        public IActionResult DetailsName(string FirstName, string LastName)
        {
            if (FirstName is null && LastName is null)
                return BadRequest();
            IEnumerable<EmployeeView> employees = _EmployeesData.GetAll();
            if (!string.IsNullOrWhiteSpace(FirstName))
                employees = employees.Where(e => e.FirstName == FirstName);
            if (!string.IsNullOrWhiteSpace(LastName))
                employees = employees.Where(e => e.LastName == LastName);

            var employee = employees.FirstOrDefault();

            if (employee is null)
                return NotFound();

            return View(nameof(Details), employee);
        } 
        public IActionResult Edit (int id, [FromBody] EmployeeView Employee)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}