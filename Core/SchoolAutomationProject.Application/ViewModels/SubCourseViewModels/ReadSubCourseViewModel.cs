using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.SubCourseViewModels
{
    public class ReadSubCourseViewModel : ReadViewModel
    {
        public string Code { get; set; }
        public int WeeklyHour { get; set; }//todo Bu property'ler MainCourse'da olabilir emin değilim.
        public int Position { get; set; }

        //SubCourse - MainCourse ilişkisi
        public MainCourse MainCourse { get; set; }
        public string MainCourseName => MainCourse.Name;
    }
}
