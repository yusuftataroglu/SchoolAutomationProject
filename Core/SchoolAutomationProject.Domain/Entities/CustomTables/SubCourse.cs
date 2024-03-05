using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class SubCourse : BaseClass
    {
        public string Code { get; set; }
        public int WeeklyHour { get; set; }//todo Bu property'ler MainCourse'da olabilir emin değilim.
        public int? Position { get; set; }

        //SubCourse - MainCourse ilişkisi
        public virtual MainCourse MainCourse { get; set; }
        public Guid? MainCourseId { get; set; }

        //SubCourse - Grade ilişkisi
        public virtual ICollection<Grade> Grades { get; set; }

        //SubCourse-Homework ilişkisi
        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}