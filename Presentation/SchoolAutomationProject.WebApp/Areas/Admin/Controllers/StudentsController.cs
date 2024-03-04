using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.StudentViewModels;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class StudentsController : GenericController<Domain.Entities.CustomTables.Student, ReadStudentViewModel, WriteStudentViewModel>
    {

        public StudentsController(
            IStudentReadRepository readRepository,
            IStudentWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Öğrenci Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Okul No", "Ad", "Soyad", "Cinsiyet", "Bitirdiği Okul", "Bitirdiği Okuldaki Not Ortalaması", "Ön Kayıt Durumu", "Devamsızlık Sayısı", "Devam Etme Durumu" };
            ViewData["CustomProperties"] = new List<string> { "RegistrationNumber", "FirstName", "LastName", "Gender", "GraduatedSchool", "GPA", "IsPreRegistered", "TotalAbsenceCount", "ContinuationStatus" };
            ViewData["ControllerName"] = "Students";
            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Öğrenci Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Okul No", "Ad", "Soyad", "Cinsiyet", "Bitirdiği Okul", "Bitirdiği Okuldaki Not Ortalaması", "Ön Kayıt Durumu", "Devamsızlık Sayısı", "Devam Etme Durumu", "Sınıfı", "Velisi", "Belgeleri" };
            ViewData["CustomProperties"] = new List<string> { "RegistrationNumber", "FirstName", "LastName", "Gender", "GraduatedSchool", "GPA", "IsPreRegistered", "TotalAbsenceCount", "ContinuationStatus", "Classroom", "Parent", "Achievements" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteStudentViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteStudentViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}