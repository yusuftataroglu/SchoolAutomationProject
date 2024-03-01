using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.StudentViewModels
{
    public class ReadStudentViewModel : BaseClass, IReadViewModel
    {
        public string RegistrationNumber { get; set; } // Okul No
        public string FirstName { get; set; } // Öğrenci Ad
        public string LastName { get; set; } // Öğrenci Soyad
        public Gender Gender { get; set; } //Cinsiyet
        public string GraduatedSchool { get; set; } // Bitirdiği Okul
        public double GPA { get; set; } // Mezun olduğu okulun not ortalaması
        public bool IsPreRegistered { get; set; } // Ön kayıt durumu
        public short? TotalAbsenceCount { get; set; } // Devamsızlık sayısı
        public ContinuationStatus? ContinuationStatus { get; set; } //Devam etme durumu

        //Student-Classroom ilişkisi
        public Classroom Classroom { get; set; }

        //Student-AppUser ilişkisi
        public AppUser User { get; set; }

        //Student-Parent ilişkisi
        public Parent Parent { get; set; }

        //Student-Grade ilişkisi
        public ICollection<Grade> Grades { get; set; }

        //Student-Achievement ilişkisi
        public ICollection<Achievement> Achievements { get; set; }
    }
}
