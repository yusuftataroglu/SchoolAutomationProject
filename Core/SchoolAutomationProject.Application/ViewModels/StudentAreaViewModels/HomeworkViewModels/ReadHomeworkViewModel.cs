using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.HomeworkViewModels
{
    public class ReadHomeworkViewModel : IReadViewModel
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string FileUrl { get; set; }
        public Student Student { get; set; }
        public SubCourse SubCourse { get; set; }
    }
}
