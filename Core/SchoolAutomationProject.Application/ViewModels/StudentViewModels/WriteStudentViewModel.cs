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

        [Required(ErrorMessage ="Veli İsmi Boş Geçilemez!")]
        public string ParentFirstName { get; set; }

        [Required(ErrorMessage = "Veli Soyismi Boş Geçilemez!")]
        public string ParentLastName { get; set; }

        [Required(ErrorMessage = "Veli Cep Telefon Numarası Boş Geçilemez!")]
        public string ParentMobilePhone { get; set; }
        public string? ParentWorkPhone { get; set; }

        [Required(ErrorMessage = "Adres Boş Geçilemez!")]
        public string ParentAddress { get; set; }

        [Required(ErrorMessage = "İlçe Boş Geçilemez!")]
        public string ParentDistrict { get; set; }

        [Required(ErrorMessage = "Şehir Boş Geçilemez!")]
        public string ParentCity { get; set; }

        public bool? IsPreRegistered { get; set; }

        public ContinuationStatus? ContinuationStatus { get; set; }

        //Student-Classroom ilişkisi
        public string? ClassroomId { get; set; } //Ön kayıt aşamasında girilmesine gerek yok.

        //Student-Parent ilişkisi
        public string? ParentId { get; set; }

        //Student-Grade ilişkisi
        public List<string>? GradeIds { get; set; }
        public List<Grade>? Grades { get; set; }

        //Student-Achievement ilişkisi
        public List<string>? AchievementIds { get; set; }
        public List<Achievement>? Achievements { get; set; }

        //Student-Attendance ilişkisi
        public List<string>? AttendanceIds { get; set; }
        public List<Attendance>? Attendances { get; set; }
    }
}
