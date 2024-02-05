using SchoolAutomationProject.Domain.Entities.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Semester : BaseClass
    {
        public Guid Id { get; set; } // Season Id'si
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Semester - Achievement ilişkisi
        public virtual ICollection<Achievement> Achievements { get; set; }
    }
}
