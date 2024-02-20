using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Semester : BaseClass
    {
        public Semester()
        {
            //Achievements = new List<Achievement>();
        }
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Semester - Achievement ilişkisi
        public virtual ICollection<Achievement> Achievements { get; set; }
    }
}
