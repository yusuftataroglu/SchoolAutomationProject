using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Teacher : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Role { get; set; }
        public string Department { get; set; }

        //Teacher-MainCourse ilişkisi
        public virtual MainCourse MainCourse { get; set; }
        public Guid MainCourseId { get; set; }

        //Teacher-Classroom ilişkisi
        public virtual ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }

        //Teacher-Student ilişkisi
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }


    }
}
