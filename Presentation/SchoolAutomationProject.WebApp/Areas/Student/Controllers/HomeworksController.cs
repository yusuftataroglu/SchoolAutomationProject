using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.HomeworkRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.StudentAreaViewModels.HomeworkViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.Infrastructure.Helpers.FileUploadHelpers;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Student.Controllers
{
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class HomeworksController : GenericController<Homework, ReadHomeworkViewModel, WriteHomeworkViewModel>
    {
        private readonly IReadRepository<Homework> _homeworkReadRepository;
        private readonly IHomeworkWriteRepository _homeworkWriteRepository;
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly ISubCourseReadRepository _subCourseReadRepository;
        private readonly UserManager<AppUser> _userManager;

        public HomeworksController(
            IHomeworkReadRepository homeworkReadRepository,
            IHomeworkWriteRepository homeworkWriteRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IStudentReadRepository studentReadRepository,
            ISubCourseReadRepository subCourseReadRepository,
            UserManager<AppUser> userManager)
            : base(homeworkReadRepository, homeworkWriteRepository, mapper, fillEntityRelationshipsService)
        {
            _homeworkReadRepository = homeworkReadRepository;
            _homeworkWriteRepository = homeworkWriteRepository;
            _studentReadRepository = studentReadRepository;
            _subCourseReadRepository = subCourseReadRepository;
            _userManager = userManager;
        }

        public override IActionResult Add()
        {
            return base.Add();
        }
        public override async Task<IActionResult> AddWithFile(string userName, WriteHomeworkViewModel modelVM, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(userName);
                modelVM.StudentId = _studentReadRepository.GetWhere(x => x.UserId == user.Id).FirstOrDefault()?.Id;
                var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                var subCourse = _subCourseReadRepository.GetWhere(x => x.Id == modelVM.SubCourseId).FirstOrDefault()?.Code;
                string path = "";

                if (file != null)
                {
                    var fileUploadResult = FileUploader.Upload(file.FileName);
                    if (fileUploadResult != "0")
                    {
                        //path = Path.Combine("C:\\Users\\yusuf\\Desktop\\Files", $"Homeworks\\{subCourse}\\Students\\{student.FirstName} {student.LastName}", fileUploadResult);

                        path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\Files\\Homeworks\\{subCourse}\\Students\\{student.FirstName} {student.LastName}", fileUploadResult);

                        //if (!Directory.Exists(path))
                        //{
                        //    Directory.CreateDirectory(path);
                        //}
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        };
                        modelVM.FileUrl = path;
                        return await base.AddWithFile(userName, modelVM, file);
                    }

                    else
                    {
                        TempData["Error"] = "Uygun Türde Dosya Yükleyiniz";
                        return View(modelVM);
                    }
                }
                else
                {
                    TempData["Error"] = "Bir Dosya Seçiniz";
                    return View(modelVM);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }

        }
    }
}
