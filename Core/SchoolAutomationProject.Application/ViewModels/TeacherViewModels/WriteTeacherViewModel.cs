using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.TeacherViewModels
{
    public class WriteTeacherViewModel
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

        //Öğretmen eklendikten sonra sınıf ataması yapmak zorunlu değil. Atama sonradan yapılabilir.(Update yaparken)
        public List<string>? ClassroomTeachersClassroomIds { get; set; }
    }
}
