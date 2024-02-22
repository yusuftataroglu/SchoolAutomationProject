using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.ClassroomViewModels
{
    public class WriteClassroomViewModel : WriteViewModel
    {
        public WriteClassroomViewModel()
        {
            ClassroomMainCoursesMainCourseIds = new();
            StudentIds = new();
            ClassroomTeachersTeacherIds = new();
        }


        [Required(ErrorMessage = "Sınıf boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Kapasite boş geçilemez")]
        [DefaultValue(25)]
        public byte Capacity { get; set; }

        //Sonradan da girilebilir.
        public List<string>? ClassroomMainCoursesMainCourseIds { get; set; }
        public List<string>? StudentIds { get; set; }
        public List<string>? ClassroomTeachersTeacherIds { get; set; }

    }
}
