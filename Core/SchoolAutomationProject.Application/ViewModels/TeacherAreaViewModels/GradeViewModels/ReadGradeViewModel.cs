using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.GradeViewModels
{
    public class ReadGradeViewModel : IReadViewModel
    {
        public Guid Id { get; set; }
        public string CreatedUser { get; set; }
        public double Score { get; set; } // Öğrencinin aldığı not
        public byte ExamNumber { get; set; } // O dersin kaçıncı sınavı

        // Not - Öğrenci ilişkisi
        public Student Student { get; set; }

        // Not - Alt Ders ilişkisi
        public SubCourse SubCourse { get; set; }

        public string StudentFullName => $"{Student.FirstName} {Student.LastName}";
        public string SubCourseCode => SubCourse.Code;

    }
}
