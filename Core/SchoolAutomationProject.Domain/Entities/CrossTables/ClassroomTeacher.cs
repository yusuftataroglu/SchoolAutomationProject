using SchoolAutomationProject.Domain.Entities.UniqueTables;

namespace SchoolAutomationProject.Domain.Entities.CrossTables
{
    public class ClassroomTeacher
    {
        public Guid ClassroomId { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
