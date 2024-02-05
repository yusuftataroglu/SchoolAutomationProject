using SchoolAutomationProject.Domain.Entities.UniqueTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities.CrossTables
{
    public class StudentTeacher
    {
        public Guid StudentId { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
