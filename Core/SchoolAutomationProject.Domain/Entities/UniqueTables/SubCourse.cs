using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class SubCourse : BaseClass
    {
        public string Code { get; set; }
        public int WeeklyHour { get; set; }//todo Bu property'ler MainCourse'da olabilir emin değilim.
        public int Position { get; set; }

        //SubCourse - MainCourse ilişkisi
        public virtual MainCourse MainCourse { get; set; }
        public Guid MainCourseId { get; set; }

        //SubCourse - Grade ilişkisi
        public virtual ICollection<Grade> Grades { get; set; }

    }
}