using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClassroomsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IClassroomReadRepository _classroomReadRepository;
        private readonly IClassroomWriteRepository _classroomWriteRepository;

        public ClassroomsController(
            IMapper mapper,
            IClassroomReadRepository classroomReadRepository,
            IClassroomWriteRepository classroomWriteRepository)
        {
            _mapper = mapper;
            _classroomReadRepository = classroomReadRepository;
            _classroomWriteRepository = classroomWriteRepository;
        }

        [HttpGet]
        public IActionResult GetClassrooms()
        {
            var model = _mapper.Map<List<ReadClassroomViewModel>>(_classroomReadRepository.GetAll().ToList());
            return View(model);
        }

        [HttpGet]
        public IActionResult AddClassroom()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddClassroom(WriteClassroomViewModel model, List<string> mainCourseId, List<string> studentId, List<string> teacherId)
        {
            if (ModelState.IsValid)
            {
                var classroom = new Classroom
                {
                    Name = model.Name,
                    Capacity = model.Capacity,
                    ClassroomTeachers = new List<ClassroomTeacher>(),
                    ClassroomMainCourses = new List<ClassroomMainCourse>(),
                    Students = new List<Student>()
                };

                // Eklenen kod:
                foreach (var id in studentId)
                {
                    classroom.Students.Add(new Student { Id = Guid.Parse(id) });
                }

                foreach (var id in teacherId)
                {
                    classroom.ClassroomTeachers.Add(new ClassroomTeacher
                    {
                        ClassroomId = classroom.Id,
                        TeacherId = Guid.Parse(id)
                    });
                }

                foreach (var id in mainCourseId)
                {
                    classroom.ClassroomMainCourses.Add(new ClassroomMainCourse
                    {
                        ClassroomId = classroom.Id,
                        MainCourseId = Guid.Parse(id)
                    });
                }

                var result = await _classroomWriteRepository.AddAsync(classroom);
                if (result)
                {
                    await _classroomWriteRepository.SaveChangesAsync();
                    TempData["Success"] = "Sınıf başarıyla eklendi";
                    return View(model);
                }
                else
                {
                    TempData["Error"] = "Bir hata meydana geldi!";
                    return View(model);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(model);
            }
        }
    }
}
