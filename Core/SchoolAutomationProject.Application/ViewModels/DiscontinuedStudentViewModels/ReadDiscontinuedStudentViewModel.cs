using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.DiscontinuedStudentViewModels
{
    public class ReadDiscontinuedStudentViewModel:ReadViewModel
    {
        public virtual Student Student { get; set; }
    }
}
