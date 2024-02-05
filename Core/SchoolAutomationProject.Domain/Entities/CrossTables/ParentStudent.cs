using SchoolAutomationProject.Domain.Entities.UniqueTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities.CrossTables
{
    public class ParentStudent
    {
        public Guid ParentId { get; set; }
        public Guid StudentId { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual Student Student { get; set; }
      
    }
}
