using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.ClassroomViewModels
{
    public class WriteClassroomViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DefaultValue(25)]
        public byte Capacity { get; set; }

        //Sonradan da girilebilir.
        public List<string>? MainCourseId { get; set; }
        public List<string>? StudentId { get; set; }
        public List<string>? TeacherId { get; set; }

    }
}
