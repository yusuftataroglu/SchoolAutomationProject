using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.ClassroomViewModels
{
    public class WriteClassroomViewModel
    {
        public WriteClassroomViewModel()
        {
            ClassroomMainCoursesMainCourseIds = new();
            StudentIds = new();
            ClassroomTeachersTeacherIds = new();
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage ="İsim boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Kapasite boş geçilemez")]
        [DefaultValue(25)]
        public byte Capacity { get; set; }

        //Sonradan da girilebilir.
        public List<Guid>? ClassroomMainCoursesMainCourseIds { get; set; }
        public List<Guid>? StudentIds { get; set; }
        public List<Guid>? ClassroomTeachersTeacherIds { get; set; }

    }
}
