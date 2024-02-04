using SchoolAutomationProject.Domain.Entities.Common;
using SchoolAutomationProject.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities
{
    public class Student : BaseClass
    {
        public string RegistrationNumber { get; set; } // Okul No
        public string FirstName { get; set; } // Öğrenci Ad
        public string LastName { get; set; } // Öğrenci Soyad
        public Gender Gender { get; set; } //Cinsiyet
        public string GraduatedSchool { get; set; } // Bitirdiği Okul
        public double GPA { get; set; } // Not Ortalaması
        public AttendanceStatus AttendanceStatus { get; set; }

        //Student-Parent ilişkisi
        public virtual Parent Parent { get; set; }
        public Guid ParentId { get; set; }

        //Student-Class ilişkisi
        public Guid ClassroomId { get; set; } //todo Sınıf Id'si  Classroom oluşturulacak!



    }
}
