using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherScheduleViewModels
{
    public class WriteTeacherScheduleViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Tarih Boş Geçilemez!")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Gün Boş Geçilemez!")]
        public DayOfWeek Day { get; set; } //js ile DateTime verisi alınarak otomatik doldurulabilir.

        [Required(ErrorMessage = "Zaman Aralığı Boş Geçilemez!")]
        public byte TimeSlot { get; set; }

        [Required(ErrorMessage = "Sınıf Boş Geçilemez!")]
        public string Classroom { get; set; }

        //TeacherSchedule - Teacher ilişkisi
        [Required(ErrorMessage = "Öğretmen Boş Geçilemez!")]
        public Guid? TeacherId { get; set; }
    }
}
