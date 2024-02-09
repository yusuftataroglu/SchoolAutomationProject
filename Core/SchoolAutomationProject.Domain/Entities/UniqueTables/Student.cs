﻿using SchoolAutomationProject.Domain.Entities.CommonTables;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.Enums;

namespace SchoolAutomationProject.Domain.Entities.UniqueTables
{
    public class Student : BaseClass
    {
        public string RegistrationNumber { get; set; } // Okul No
        public string FirstName { get; set; } // Öğrenci Ad
        public string LastName { get; set; } // Öğrenci Soyad
        public Gender Gender { get; set; } //Cinsiyet
        public string GraduatedSchool { get; set; } // Bitirdiği Okul
        public double GPA { get; set; } // Mezun olduğu okulun not ortalaması
        public bool IsPreRegistered { get; set; } // Ön kayıt durumu
        public short? TotalAbsenceCount { get; set; } // Devamsızlık sayısı
        public ContinuationStatus? ContinuationStatus { get; set; } //Devam etme durumu

        //Student-Parent ilişkisi
        public virtual ICollection<ParentStudent> ParentStudents { get; set; }

        //Student-Classroom ilişkisi
        public virtual Classroom Classroom { get; set; }
        public Guid? ClassroomId { get; set; } //Ön kayıt aşamasında girilmesine gerek yok.

        //Student-Teacher ilişkisi
        //KALDIRILDI
        //public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }

        //Student-Achievement ilişkisi
        public virtual ICollection<Achievement> Achievement { get; set; }

        //Student-Grade ilişkisi
        public virtual ICollection<Grade> Grades { get; set; }

        //Student-Attendance ilişkisi
        public virtual ICollection<Attendance> Attendances { get; set; }

        //Student-DiscontinuedStudent ilişkisi
        public virtual DiscontinuedStudent DiscontinuedStudent{ get; set; }
    }
}
