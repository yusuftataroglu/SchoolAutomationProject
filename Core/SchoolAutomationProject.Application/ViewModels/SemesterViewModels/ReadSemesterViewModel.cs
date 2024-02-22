using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.SemesterViewModels
{
    public class ReadSemesterViewModel:ReadViewModel
    {
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Semester - Achievement ilişkisi
        public virtual ICollection<Achievement> Achievements { get; set; }
    }
}
