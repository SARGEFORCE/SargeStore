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
        public static readonly List<EmployeeView> __Employees = new List<EmployeeView>
        {
            new EmployeeView{Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 35 },
            new EmployeeView{Id = 2, LastName = "Петров", FirstName = "Перт", Patronymic = "Петрович", Age = 43 },
            new EmployeeView{Id = 3, LastName = "Козлов", FirstName = "Козлик", Patronymic = "Сидорович", Age = 25 },

        };

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