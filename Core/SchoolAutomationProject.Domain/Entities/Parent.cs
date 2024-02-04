using SchoolAutomationProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities
{
    public class Parent:BaseClass
    {
        public string FirstName { get; set; } // Veli Ad
        public string LastName{ get; set; } // Veli Soyad
        public string MobilePhone { get; set; } // Cep Telefonu
        public string? WorkPhone { get; set; } // İş Telefonu
        public string Address { get; set; } // Ev Adresi
        public string District { get; set; } // İlçe
        public string City { get; set; } // İl

        // Student-Parent ilişkisi
        public virtual ICollection<Student> Students { get; set; }
    }

}
