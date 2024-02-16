using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.TeacherViewModels
{
    public class WriteTeacherViewModel
    {
        public Guid Id { get; set; } //todo gerekli mi?

        [Required(ErrorMessage = "İsim boş geçilemez!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim boş geçilemez!")]
        public string LastName { get; set; }
        public string? Title { get; set; }

        [Required(ErrorMessage = "Ders seçimi boş geçilemez!")]
        public string MainCourseId { get; set; }

        //Öğretmen eklendikten sonra sınıf ataması yapmak zorunlu değil. Sonradan da atama yapılabilir.
        public List<string>? ClassroomId { get; set; }
    }
}
