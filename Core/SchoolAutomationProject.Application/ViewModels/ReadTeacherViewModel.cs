using SchoolAutomationProject.Domain.Entities.CommonTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.ViewModels
{
    public class ReadTeacherViewModel:BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Role { get; set; }
        public string Department { get; set; }
    }
}
