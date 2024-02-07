using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Domain.Entities.UniqueTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.StudentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Persistence
{
    //public class RegistrationNumberHelper
    //{
    //    private static IStudentReadRepository _studentReadRepository; //todo instance sorunu var.
    //    private static SchoolAutomationProjectDbContext _schoolAutomationProjectDbContext;
    //    private static string RegistrationNumber;
    //    public static string CalcRegistrationNumber()
    //    {
    //        _studentReadRepository = new StudentReadRepository(_schoolAutomationProjectDbContext);
    //        var result = _studentReadRepository.GetAll();
    //        if (result==null)
    //        {
    //            RegistrationNumber = $"100-{DateTime.Now.Year.ToString().Substring(2)}";
    //        }
    //        else
    //        {
    //            var lastRegistretedStudent = _schoolAutomationProjectDbContext.Students.OrderByDescending(student => student.CreatedDate).FirstOrDefault();
    //            RegistrationNumber = $"{lastRegistretedStudent.RegistrationNumber.Split("-")[0]}-{DateTime.Now.Year.ToString().Substring(2)}";
    //        }
    //        return RegistrationNumber;
    //    }
    //}
}
