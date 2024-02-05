using SchoolAutomationProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities
{
    public class Grade:BaseClass
    {
        public double Score { get; set; } // Öğrencinin aldığı not
        public byte ExamNumber { get; set; } // O dersin kaçıncı sınavı

        // Not - Öğrenci ilişkisi
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; } // Öğrenci ID'si


        // Not - Alt Ders ilişkisi
        public virtual SubCourse SubCourse { get; set; }
        public Guid SubCourseId { get; set; } // Ana Ders ID'si

    }
}
