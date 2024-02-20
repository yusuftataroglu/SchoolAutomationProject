﻿using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Domain.Entities.CustomTables
{
    public class Grade : BaseClass
    {
        public Grade()
        {
            //Student = new Student();
            //SubCourse = new SubCourse();
        }
        public double Score { get; set; } // Öğrencinin aldığı not
        public byte ExamNumber { get; set; } // O dersin kaçıncı sınavı

        // Not - Öğrenci ilişkisi
        public virtual Student Student { get; set; }
        public Guid? StudentId { get; set; } // Öğrenci ID'si


        // Not - Alt Ders ilişkisi
        public virtual SubCourse SubCourse { get; set; }
        public Guid? SubCourseId { get; set; } // Ana Ders ID'si

    }
}
