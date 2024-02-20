using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class DiscontinuedStudent:BaseClass
    {
        public DiscontinuedStudent()
        {
            //Student = new Student();
        }
        public virtual Student Student { get; set; }
        public Guid? StudentId { get; set; }
    }
}
