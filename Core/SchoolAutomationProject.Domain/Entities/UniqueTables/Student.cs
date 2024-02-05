﻿using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Student : BaseClass
    {
        public Student()
        {
            TotalAbsenceCount = 0;
        }
        public string RegistrationNumber { get; set; } // Okul No
        public string FirstName { get; set; } // Öğrenci Ad
        public string LastName { get; set; } // Öğrenci Soyad
        public Gender Gender { get; set; } //Cinsiyet
        public string GraduatedSchool { get; set; } // Bitirdiği Okul
        public double GPA { get; set; } // Mezun olduğu okulun not ortalaması
        public int TotalAbsenceCount { get; set; } // Devamsızlık sayısı
        public bool IsPreRegistered { get; set; } // Ön kayıt durumu

        //Student-Parent ilişkisi
        public virtual ICollection<ParentStudent> ParentStudents { get; set; }

        //Student-Class ilişkisi
        public virtual Classroom Classroom { get; set; }
        public Guid ClassroomId { get; set; } //todo Sınıf Id'si  Classroom oluşturulacak!

        //Student-Teacher ilişkisi
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }

        //Student-Achievement ilişkisi
        public virtual ICollection<Achievement> Achievement { get; set; }

        //Student-Grade ilişkisi
        public ICollection<Grade> Grades { get; set; }

        //Student-Attendance ilişkisi
        public ICollection<Attendance> Attendances { get; set; }
    }
}