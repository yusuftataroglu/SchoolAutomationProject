using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.SubCourseViewModels
{
    public class WriteSubCourseViewModel:WriteViewModel
    {
        [Required(ErrorMessage ="Ders Kodu Boş Geçilemez!")]
        public string Code { get; set; }

        [Required(ErrorMessage ="Haftalık Ders Saati Boş Geçilemez!")]
        public int WeeklyHour { get; set; }

        public int? Position { get; set; }


        //SubCourse - MainCourse ilişkisi
        [Required(ErrorMessage ="Ana Ders Seçimi Boş Geçilemez!")]
        public string MainCourseId { get; set; }
    }
}
