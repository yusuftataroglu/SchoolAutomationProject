﻿using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AppUserViewModels
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Password { get; set; }
    }
}
