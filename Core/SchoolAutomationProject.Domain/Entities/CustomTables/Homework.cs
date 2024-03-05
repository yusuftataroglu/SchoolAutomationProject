using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Homework:BaseClass
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string FileUrl { get; set; }
        public virtual Student Student { get; set; }
        public Guid? StudentId { get; set; }
        public virtual SubCourse SubCourse { get; set; }
        public Guid? SubCourseId { get; set; }

    }
}
