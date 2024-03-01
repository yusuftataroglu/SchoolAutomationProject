using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SubCourseViewModels
{
    public class WriteSubCourseViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Ders Kodu Boş Geçilemez!")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Haftalık Ders Saati Boş Geçilemez!")]
        public int WeeklyHour { get; set; }

        public int? Position { get; set; }


        //SubCourse - MainCourse ilişkisi
        [Required(ErrorMessage = "Ana Ders Seçimi Boş Geçilemez!")]
        public string MainCourseId { get; set; }
    }
}
