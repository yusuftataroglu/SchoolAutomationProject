using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ParentsController : GenericController<Parent, ReadParentViewModel, WriteParentViewModel>
    {

        public ParentsController(
            IParentReadRepository readRepository,
            IParentWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsRepository,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsRepository)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Veli Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Ad", "Soyad", "Cep Telefonu", "İş Telefonu", "Ev Adresi", "İlçe", "İl", "Öğrenciler" };
            ViewData["CustomProperties"] = new List<string> { "FirstName", "LastName", "MobilePhone", "WorkPhone", "Address", "District", "City", "Students" };
            ViewData["ControllerName"] = "Parents";
            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Veli Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Ad", "Soyad", "Cep Telefonu", "İş Telefonu", "Ev Adresi", "İlçe", "İl", "Öğrenciler" };
            ViewData["CustomProperties"] = new List<string> { "FirstName", "LastName", "MobilePhone", "WorkPhone", "Address", "District", "City", "Students" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteParentViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteParentViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}