using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!")]
        public string UserName { get; set; } 
        
        //todo belki email eklenebilir

        [Required(ErrorMessage ="Şifre boş geçilemez")]
        public string Password { get; set; }
    }
}
