using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.StudentViewModels
{
    public class ReadStudentViewModel : IReadViewModel
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

        //Student-Grade ilişkisi
        public ICollection<Grade> Grades { get; set; }
    }
}
