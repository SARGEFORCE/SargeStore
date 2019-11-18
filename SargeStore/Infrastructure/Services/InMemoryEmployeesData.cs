using SargeStore.Infrastructure.Conventions.Interfaces;
using SargeStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SargeStore.Infrastructure.Services
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        public readonly List<EmployeeView> _Employees = new List<EmployeeView>
        {
            new EmployeeView{Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 35 },
            new EmployeeView{Id = 2, LastName = "Петров", FirstName = "Перт", Patronymic = "Петрович", Age = 43 },
            new EmployeeView{Id = 3, LastName = "Козлов", FirstName = "Козлик", Patronymic = "Сидорович", Age = 25 },
        };

        public IEnumerable<EmployeeView> GetAll() => _Employees;

        public EmployeeView GetById(int id) => _Employees.FirstOrDefault(e => e.Id == id);

        public void Add(EmployeeView Employee)
        {
            if (Employee is null)
                throw new ArgumentNullException(nameof(Employee));
            Employee.Id = _Employees.Count == 0 ? 1 : _Employees.Max(e => e.Id) + 1;
            _Employees.Add(Employee);
        }
        public void Edit(int id, EmployeeView Employee)
        {
            var db_emloyee = GetById(id);
            if (db_emloyee is null) return;

            db_emloyee.FirstName = Employee.FirstName;
            db_emloyee.LastName = Employee.LastName;
            db_emloyee.Patronymic = Employee.Patronymic;
            db_emloyee.Age = Employee.Age;
        }
        public bool Delete(int id)
        {
            var db_emloyee = GetById(id);
            if (db_emloyee is null) return false;
            return _Employees.Remove(db_emloyee);
        }
        public void SaveChanges() { }
    }
}