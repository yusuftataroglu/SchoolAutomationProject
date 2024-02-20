using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.MainCourseViewModels
{
    public class WriteMainCourseViewModel:WriteViewModel
    {
        public WriteMainCourseViewModel()
        {
            SubCourseIds = new();
            TeacherIds = new();
            ClassroomMainCoursesClassroomIds = new();
        }


        [Required(ErrorMessage = "Ders adı boş geçilemez")]
        public string Name { get; set; }

        //Sonradan da girilebilir
        public List<string>? TeacherIds { get; set; }
        public List<string>? SubCourseIds { get; set; }
        public List<string>? ClassroomMainCoursesClassroomIds { get; set; }
    }
}
