using SchoolAutomationProject.Application.ViewModels.BaseViewModels;

namespace SchoolAutomationProject.Application.ViewModels.SemesterViewModels
{
    public class ReadSemesterViewModel:ReadViewModel
    {
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"
        public DateTime StartDate { get; set; }
        public string StartDateShort => StartDate.ToShortDateString();
        public DateTime EndDate { get; set; }
        public string EndDateShort => EndDate.ToShortDateString();

    }
}
