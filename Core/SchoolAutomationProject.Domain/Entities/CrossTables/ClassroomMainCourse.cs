using SchoolAutomationProject.Domain.Entities.CustomTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities.CrossTables
{
    public class ClassroomMainCourse
    {
        public Guid ClassroomId { get; set; }
        public Guid MainCourseId { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual MainCourse MainCourse { get; set; }
    }
}
