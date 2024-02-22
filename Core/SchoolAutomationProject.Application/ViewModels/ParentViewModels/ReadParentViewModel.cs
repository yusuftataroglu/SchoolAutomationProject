using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.ParentViewModels
{
    public class ReadParentViewModel:ReadViewModel
    {
        public string FirstName { get; set; } // Veli Ad
        public string LastName { get; set; } // Veli Soyad
        public string MobilePhone { get; set; } // Cep Telefonu
        public string? WorkPhone { get; set; } // İş Telefonu
        public string Address { get; set; } // Ev Adresi    
        public string District { get; set; } // İlçe
        public string City { get; set; } // İl

        // Student-Parent ilişkisi
        public virtual ICollection<ParentStudent> ParentStudents { get; set; }

        //Parent-AppUser ilişkisi
        public virtual AppUser User { get; set; }
    }
}
