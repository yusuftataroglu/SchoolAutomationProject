using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AttendanceViewModels
{
    public class WriteAttendanceViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tarih Boş Geçilemez!")]
        public DateTime AttendanceDate { get; set; } // Devamsızlık tarihi

        [Required(ErrorMessage = "Devamsızlık Durumu Boş Geçilemez!")]
        public AttendanceStatus AttendanceStatus { get; set; }

        // Devamsızlık - Öğrenci ilişkisi
        [Required(ErrorMessage = "Öğrenci Boş Geçilemez!")]
        public string StudentId { get; set; } // Öğrenci ID'si

        // Devamsızlık - Ders ilişkisi
        [Required(ErrorMessage = "Alt Ders Boş Geçilemez!")]
        public string SubCourseId { get; set; } // Ders ID'si
    }
}
