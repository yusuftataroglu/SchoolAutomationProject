using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class MainCourse : BaseClass
    {
        public string Name { get; set; }

        //MainCourse - SubCourse ilişkisi
        public virtual ICollection<SubCourse> SubCourses { get; set; }

        //MainCourse-Teacher ilişkisi
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
