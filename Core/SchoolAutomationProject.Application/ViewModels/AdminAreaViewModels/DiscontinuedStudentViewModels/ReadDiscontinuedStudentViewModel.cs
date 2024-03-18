using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.DiscontinuedStudentViewModels
{
    public class ReadDiscontinuedStudentViewModel : BaseClass, IReadViewModel
    {
        public Student Student { get; set; }
        public string StudentFullName => $"{Student.FirstName} {Student.LastName}";
        public ContinuationStatus? ContinuationStatus => Student.ContinuationStatus;
    }
}
