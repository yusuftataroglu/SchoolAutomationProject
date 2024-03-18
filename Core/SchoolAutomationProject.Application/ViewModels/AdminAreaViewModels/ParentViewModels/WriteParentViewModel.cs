using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels
{
    public class WriteParentViewModel : IWriteViewModel
    {
        public WriteParentViewModel()
        {
            StudentIds = new();
        }
        public Guid Id { get; set; }

        [Required(ErrorMessage = "İsim Boş Geçilemez!")]
        public string FirstName { get; set; } // Veli Ad

        [Required(ErrorMessage = "Soyisim Boş Geçilemez!")]
        public string LastName { get; set; } // Veli Soyad

        [Required(ErrorMessage = "Telefon Numarası Boş Geçilemez!")]
        [Phone(ErrorMessage = "Cep Telefonu Numarası Uygun Formatta Değil!")]
        public string MobilePhone { get; set; } // Cep Telefonu

        [Phone(ErrorMessage = "İş Telefonu Numarası Uygun Formatta Değil!")]
        public string? WorkPhone { get; set; } // İş Telefonu

        [Required(ErrorMessage = "Adres Boş Geçilemez!")]
        public string Address { get; set; } // Ev Adresi    

        [Required(ErrorMessage = "İlçe Boş Geçilemez!")]
        public string District { get; set; } // İlçe

        [Required(ErrorMessage = "Şehir Boş Geçilemez!")]
        public string City { get; set; } // İl
        public List<Guid>? StudentIds { get; set; }
        public List<Student>? Students { get; set; }
    }
}
