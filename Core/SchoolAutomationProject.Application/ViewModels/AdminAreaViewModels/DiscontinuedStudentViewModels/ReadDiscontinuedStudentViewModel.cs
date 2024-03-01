using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.DiscontinuedStudentViewModels
{
    public class ReadDiscontinuedStudentViewModel : BaseClass, IReadViewModel
    {
        public Student Student { get; set; }
    }
}
