using SchoolAutomationProject.Domain.Entities.Common;

namespace SchoolAutomationProject.Domain.Entities
{
    public class SubCourse:BaseClass
    {
        public string Code { get; set; }
        public int WeeklyHour { get; set; }//todo Bu property'ler MainCourse'da olabilir emin değilim.
        public int Position { get; set; }

        //MainCourse - SubCourse ilişkisi
        public virtual MainCourse MainCourse { get; set; }
        public Guid MainCourseId { get; set; }

    }
}