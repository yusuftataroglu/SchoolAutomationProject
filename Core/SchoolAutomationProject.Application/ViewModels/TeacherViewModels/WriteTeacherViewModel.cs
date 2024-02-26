using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.TeacherViewModels
{
    public class WriteTeacherViewModel : WriteViewModel
    {
        public WriteTeacherViewModel()
        {
            ClassroomTeachersClassroomIds = new();
        }

        [Required(ErrorMessage = "İsim boş geçilemez!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim boş geçilemez!")]
        public string LastName { get; set; }
        public string? Title { get; set; }

        [Required(ErrorMessage = "Ders seçimi boş geçilemez!")]
        public string MainCourseId { get; set; }
        public List<string>? ClassroomTeachersClassroomIds { get; set; }
        public List<ClassroomTeacher>? ClassroomTeachers { get; set; }

    }
}
