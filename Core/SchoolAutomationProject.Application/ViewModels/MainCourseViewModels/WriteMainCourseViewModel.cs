using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.MainCourseViewModels
{
    public class WriteMainCourseViewModel
    {
        public WriteMainCourseViewModel()
        {
            SubCourseIds = new();
            TeacherIds = new();
            ClassroomMainCoursesClassroomIds = new();
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "İsim boş geçilemez")]
        public string Name { get; set; }

        public List<Guid> SubCourseIds { get; set; }
        public List<Guid> TeacherIds { get; set; }
        public List<Guid> ClassroomMainCoursesClassroomIds { get; set; }
    }
}
