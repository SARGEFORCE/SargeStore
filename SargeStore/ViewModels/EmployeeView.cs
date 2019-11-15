using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SargeStore.ViewModels
{
    public class EmployeeView
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "ФёстНейм")]
        public string FirstName { get; set; }
        [Display(Name = "Соурнейм")]
        public string LastName { get; set; }
        [Display(Name = "ПатронОмик")]
        public string Patronymic { get; set; }
        [Display(Name = "Старый стал?")]
        public int Age { get; set; }
    }
}
