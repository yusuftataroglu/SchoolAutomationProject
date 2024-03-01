using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AppUserViewModels
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Password { get; set; }
    }
}
