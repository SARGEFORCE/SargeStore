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
        public static readonly List<EmployeeView> __Employees = new List<EmployeeView>
        {
            new EmployeeView{Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 35 },
            new EmployeeView{Id = 2, LastName = "Петров", FirstName = "Перт", Patronymic = "Петрович", Age = 43 },
            new EmployeeView{Id = 3, LastName = "Козлов", FirstName = "Козлик", Patronymic = "Сидорович", Age = 25 },
        };

        public void Add(EmployeeView Employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, EmployeeView Employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeView GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}