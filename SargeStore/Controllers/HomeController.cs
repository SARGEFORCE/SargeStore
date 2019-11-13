using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SargeStore.ViewModels;

namespace SargeStore.Controllers
{

    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;

        public HomeController(IConfiguration Configuration) => _Configuration = Configuration;
        public IActionResult Index() => View();
        public IActionResult ReadConfig() => Content(_Configuration["CustomData"]);
        public static readonly List<EmployeeView> __Employees = new List<EmployeeView>
        {
            new EmployeeView{Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 35 },
            new EmployeeView{Id = 2, LastName = "Петров", FirstName = "Перт", Patronymic = "Петрович", Age = 43 },
            new EmployeeView{Id = 3, LastName = "Козлов", FirstName = "Козлик", Patronymic = "Сидорович", Age = 25 },

        };
        public IActionResult GetEmployes() => View(__Employees);
    }
}