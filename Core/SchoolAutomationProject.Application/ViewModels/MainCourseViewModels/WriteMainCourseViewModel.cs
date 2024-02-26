using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.MainCourseViewModels
{
    public class WriteMainCourseViewModel:WriteViewModel
    {
        public WriteMainCourseViewModel()
        {
            ClassroomMainCoursesClassroomIds = new();
        }

        [Required(ErrorMessage = "Ders adı boş geçilemez")]
        public string Name { get; set; }

        public List<ClassroomMainCourse>? ClassroomMainCourses { get; set; }
        public List<string>? ClassroomMainCoursesClassroomIds { get; set; }

    }
}
