using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.DiscontinuedStudentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.DiscontinuedStudentViewModels;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DiscontinuedStudentsController : GenericController<DiscontinuedStudent, ReadDiscontinuedStudentViewModel, WriteDiscontinuedStudentViewModel>
    {
        private readonly IDiscontinuedStudentReadRepository _readRepository;
        private readonly IDiscontinuedStudentWriteRepository _writeRepository;
        private readonly IMapper _mapper;

        public DiscontinuedStudentsController(
            IDiscontinuedStudentReadRepository readRepository,
            IDiscontinuedStudentWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)

        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
        }

        public override IActionResult GetPassives()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "İlişiği Kesilen Öğrenciler Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Durumu"};
            ViewData["CustomProperties"] = new List<string> { "StudentFullName","ContinuationStatus"};
            ViewData["ControllerName"] = "DiscontinuedStudents";

            return base.GetPassives();
        }
        public async Task<IActionResult> DiscontinuedStudentDetails(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "İlişiği Kesilen Öğrenciler Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Durumu" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "ContinuationStatus" };
            ViewData["CommonColumnTitles"] = new List<string> { "Oluşturma Zamanı", "Oluşturulan Bilgisayar Adı", "Oluşturulan IP Adresi", "Güncelleme Zamanı", "Güncellenilen Bilgisayar Adı", "Güncellenilen IP Adresi" };
            ViewData["CommonProperties"] = new List<string> { "CreatedDate", "CreatedComputerName", "CreatedIpAddress", "UpdatedDate", "UpdatedComputerName", "UpdatedIpAddress" };
            var entity = await _readRepository.GetAllPassivesByIdAsync(id);
            ReadDiscontinuedStudentViewModel readViewModel = _mapper.Map<ReadDiscontinuedStudentViewModel>(entity);
            return View(readViewModel);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteDiscontinuedStudentViewModel modelVM)
        {
            return await base.Add(modelVM);
        }
    }
}