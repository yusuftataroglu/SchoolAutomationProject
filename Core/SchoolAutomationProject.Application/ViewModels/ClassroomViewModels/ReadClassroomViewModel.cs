using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.ViewModels.ClassroomViewModels
{
    public class ReadClassroomViewModel : BaseClass
    {
        public string Name { get; set; } // Sınıf
        public byte Capacity { get; set; } // Kapasite
        // Derslik - Ders ilişkisi
        public virtual ICollection<ClassroomMainCourse> ClassroomMainCourses { get; set; }
        // Sınıf - Öğrenci ilişkisi
        public virtual ICollection<Student> Students { get; set; }

        //Classroom-Teacher ilişkisi
        public virtual ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }
    }
}
