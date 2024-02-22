using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.StudentViewModels
{
    public class WriteStudentViewModel : WriteViewModel
    {
        public WriteStudentViewModel()
        {
            ParentStudentsParentIds = new();
            GradeIds = new();
            AchievementIds = new();
            AttendanceIds = new();
        }

        [Required(ErrorMessage = "İsim Boş Geçilemez!")]
        public string FirstName { get; set; } // Öğrenci Ad

        [Required(ErrorMessage = "Soyisim Boş Geçilemez!")]
        public string LastName { get; set; } // Öğrenci Soyad

        [Required(ErrorMessage = "Cinsiyet Boş Geçilemez!")]
        public Gender Gender { get; set; } //Cinsiyet

        [Required(ErrorMessage = "Mezun Olunan Okul Boş Geçilemez!")]
        public string GraduatedSchool { get; set; } // Bitirdiği Okul

        [Required(ErrorMessage = "Not Ortalaması Boş Geçilemez!")]
        public double GPA { get; set; } // Mezun olduğu okulun not ortalaması

        public bool? IsPreRegistered { get; set; } // Ön kayıt durumu

        //public short? TotalAbsenceCount { get; set; } // Devamsızlık sayısı (Otomatik olarak hesaplanacak.)

        public ContinuationStatus? ContinuationStatus { get; set; } //Devam etme durumu

        //Student-DiscontinuedStudent ilişkisi
        //public virtual DiscontinuedStudent DiscontinuedStudent { get; set; } //Gerek olmayabilir.

        //Student-Classroom ilişkisi
        public string? ClassroomId { get; set; } //Ön kayıt aşamasında girilmesine gerek yok.

        //Student-Parent ilişkisi
        [Required(ErrorMessage ="Veli Seçimi Boş Geçilemez!")]
        public List<string> ParentStudentsParentIds { get; set; } //todo js ile required tanımlanabilir.

        //Student-Grade ilişkisi
        public List<string>? GradeIds { get; set; }

        //Student-Achievement ilişkisi
        public List<string>? AchievementIds { get; set; }

        //Student-Attendance ilişkisi
        public List<string>? AttendanceIds { get; set; }
    }
}
