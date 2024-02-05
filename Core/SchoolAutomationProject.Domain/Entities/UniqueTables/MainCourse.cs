using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class MainCourse : BaseClass
    {
        public string Name { get; set; }

        //MainCourse - SubCourse ilişkisi
        public virtual ICollection<SubCourse> SubCourses { get; set; }

        //MainCourse-Teacher ilişkisi
        public virtual ICollection<Teacher> Teachers { get; set; }

        //MainCourse - Classroom ilişkisi
        public virtual ICollection<ClassroomMainCourse> ClassroomMainCourses { get; set; }

    }
}
