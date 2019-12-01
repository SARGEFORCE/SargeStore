﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SargeStore.ViewModels.Identity
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Имя пользователя")]
        [MaxLength(256)]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Пароль")]
        [MaxLength(256)]
        public string Password { get; set; }
        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }
    }
}
