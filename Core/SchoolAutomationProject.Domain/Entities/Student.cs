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
        public Guid ClassId { get; set; } //todo Sınıf Id'si  Class oluşturulacak!
        public string Branch { get; set; } // Şube
        public string FirstName { get; set; } // Öğrenci Ad
        public string LastName { get; set; } // Öğrenci Soyad
        public Gender Gender { get; set; } //Cinsiyet
        public AttendanceStatus AttendanceStatus { get; set; }
        public string GraduatedSchool { get; set; } // Bitirdiği Okul
        public double GPA { get; set; } // Not Ortalaması
        public string City { get; set; } // İl

        //Student-Parent ilişkisi
        public virtual Parent Parent { get; set; }
        public Guid ParentId { get; set; }


    }
}
