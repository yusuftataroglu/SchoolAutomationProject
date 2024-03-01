using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels
{
    public class ReadParentViewModel : BaseClass, IReadViewModel
    {
        public string FirstName { get; set; } // Veli Ad
        public string LastName { get; set; } // Veli Soyad
        public string MobilePhone { get; set; } // Cep Telefonu
        public string? WorkPhone { get; set; } // İş Telefonu
        public string Address { get; set; } // Ev Adresi    
        public string District { get; set; } // İlçe
        public string City { get; set; } // İl

        // Student-Parent ilişkisi
        public ICollection<Student> Students { get; set; }

        //Parent-AppUser ilişkisi
        public AppUser User { get; set; }
    }
}
