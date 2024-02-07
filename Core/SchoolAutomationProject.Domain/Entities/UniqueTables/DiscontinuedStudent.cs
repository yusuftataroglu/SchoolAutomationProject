using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class DiscontinuedStudent:BaseClass
    {
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }
    }
}
