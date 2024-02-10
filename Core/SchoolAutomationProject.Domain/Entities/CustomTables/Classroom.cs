﻿using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.Enums;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Classroom : BaseClass
    {
        public string Grade { get; set; } // Sınıf (1, 2, ...)
        public Section Section { get; set; } // Şube (A, B, C, ...)
        public byte Capacity { get; set; } // Kapasite

        // Derslik - Ders ilişkisi
        public virtual ICollection<ClassroomMainCourse> ClassroomMainCourses{ get; set; }
        // Sınıf - Öğrenci ilişkisi
        public virtual ICollection<Student> Students { get; set; }

        //Classroom-Teacher ilişkisi
        public virtual ICollection<ClassroomTeacher> ClassroomTeachers { get; set; }
    }
}