using SchoolAutomationProject.Domain.Entities.Common;

namespace SchoolAutomationProject.Domain.Entities
{
    public class SubCourse:BaseClass
    {
        public string Code { get; set; }

        //MainCourse - SubCourse ilişkisi
        public virtual MainCourse MainCourse { get; set; }
        public Guid MainCourseId { get; set; }

    }
}