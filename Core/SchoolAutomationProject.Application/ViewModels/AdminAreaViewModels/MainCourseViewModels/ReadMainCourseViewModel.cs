using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.MainCourseViewModels
{
    public class ReadMainCourseViewModel : BaseClass, IReadViewModel
    {
        public string Name { get; set; }
        public ICollection<SubCourse> SubCourses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<ClassroomMainCourse> ClassroomMainCourses { get; set; }

    }

}
