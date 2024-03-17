using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels
{
    public class WriteClassroomViewModel : IWriteViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Sınıf boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Kapasite boş geçilemez")]
        [DefaultValue(25)]
        public byte? Capacity { get; set; }
    }
}
