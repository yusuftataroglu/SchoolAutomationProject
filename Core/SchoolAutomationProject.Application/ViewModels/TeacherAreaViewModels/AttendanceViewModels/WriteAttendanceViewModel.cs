using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels
{
    public class WriteAttendanceViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tarih Boş Geçilemez!")]
        public DateTime? AttendanceDate { get; set; }

        [Required(ErrorMessage = "Devamsızlık Durumu Boş Geçilemez!")]
        public AttendanceStatus AttendanceStatus { get; set; }

        [Required(ErrorMessage = "Öğrenci Boş Geçilemez!")]
        public Guid? StudentId { get; set; } 

        [Required(ErrorMessage = "Alt Ders Boş Geçilemez!")]
        public Guid? SubCourseId { get; set; } 
    }
}
