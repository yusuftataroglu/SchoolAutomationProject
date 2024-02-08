using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class DiscontinuedStudent:BaseClass
    {
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }
    }
}
