using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AdministratorViewModels
{
    public class WriteAdministratorViewModel : IWriteViewModel
    {
        public Guid Id { get; set ; }

        [Required(ErrorMessage ="İsim Boş Geçilemez!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim Boş Geçilemez!")]
        public string LastName { get; set; }
        public string? Title { get; set; }
        public  AppUser User { get; set; }
        public string? UserId { get; set; }
    }
}
