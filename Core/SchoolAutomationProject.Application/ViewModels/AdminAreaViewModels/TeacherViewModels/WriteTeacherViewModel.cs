using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherViewModels
{
    public class WriteTeacherViewModel : IWriteViewModel
    {
        public WriteTeacherViewModel()
        {
            ClassroomTeachersClassroomIds = new();
        }
        public Guid Id { get; set; }

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
