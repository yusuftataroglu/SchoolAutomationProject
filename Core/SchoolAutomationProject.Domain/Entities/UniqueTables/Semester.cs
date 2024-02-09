using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Semester : BaseClass
    {
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Semester - Achievement ilişkisi
        public virtual ICollection<Achievement> Achievements { get; set; }
    }
}
