using SchoolAutomationProject.Domain.Entities.Common;
using SchoolAutomationProject.Domain.Entities.Enums;

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
        public virtual Classroom Classroom { get; set; }
        public Guid ClassroomId { get; set; } //todo Sınıf Id'si  Classroom oluşturulacak!

        //Student-Teacher ilişkisi
        public virtual ICollection<Teacher> Teachers{ get; set; }

        //Student-Achievement ilişkisi
        public virtual Achievement Achievement { get; set; }





    }
}
