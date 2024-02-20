using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class MainCourse : BaseClass
    {
        public MainCourse()
        {
            SubCourses = new List<SubCourse>();
            Teachers = new List<Teacher>();
            ClassroomMainCourses = new List<ClassroomMainCourse>();
        }
        public string Name { get; set; }

        //MainCourse - SubCourse ilişkisi (One to Many)
        public virtual ICollection<SubCourse> SubCourses { get; set; }

        //MainCourse-Teacher ilişkisi (One to Many)
        public virtual ICollection<Teacher> Teachers { get; set; }

        //MainCourse - Classroom ilişkisi (Many to Many)
        public virtual ICollection<ClassroomMainCourse> ClassroomMainCourses { get; set; }

    }
}
