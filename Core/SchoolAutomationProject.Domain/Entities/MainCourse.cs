using SchoolAutomationProject.Domain.Entities.Common;

namespace SchoolAutomationProject.Domain.Entities
{
    public class MainCourse:BaseClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; } //todo Bu property'ler SubCourse'da olabilir emin değilim.
        public int WeeklyHour { get; set; }
        public int Position { get; set; }

        //MainCourse - SubCourse ilişkisi
        public virtual ICollection<SubCourse> SubCourses { get; set; }
    }
}
