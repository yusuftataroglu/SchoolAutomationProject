using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.MainCourseViewModels
{
    public class WriteMainCourseViewModel : IWriteViewModel
    {
        public WriteMainCourseViewModel()
        {
            ClassroomMainCoursesClassroomIds = new();
        }
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Ders adı boş geçilemez")]
        public string Name { get; set; }

        public List<ClassroomMainCourse>? ClassroomMainCourses { get; set; }
        public List<Guid>? ClassroomMainCoursesClassroomIds { get; set; }

    }
}
