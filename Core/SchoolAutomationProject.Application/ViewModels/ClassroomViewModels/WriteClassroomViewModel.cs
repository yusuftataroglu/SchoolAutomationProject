using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.ClassroomViewModels
{
    public class WriteClassroomViewModel
    {
        [Required(ErrorMessage ="İsim boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Kapasite boş geçilemez")]
        [DefaultValue(25)]
        public byte Capacity { get; set; }

        //Sonradan da girilebilir.
        public List<string>? ClassroomMainCoursesMainCourseIds { get; set; }
        public List<string>? StudentIds { get; set; }
        public List<string>? ClassroomTeachersTeacherIds { get; set; }

    }
}
