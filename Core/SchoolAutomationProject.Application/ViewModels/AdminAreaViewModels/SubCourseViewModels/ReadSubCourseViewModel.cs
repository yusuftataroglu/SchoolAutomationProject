using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SubCourseViewModels
{
    public class ReadSubCourseViewModel : BaseClass, IReadViewModel
    {
        public string Code { get; set; }
        public int WeeklyHour { get; set; }
        public int Position { get; set; }

        //SubCourse - MainCourse ilişkisi
        public MainCourse MainCourse { get; set; }
        public string MainCourseName => MainCourse.IsActive? MainCourse.Name:"Silinmiş Ders";
    }
}
