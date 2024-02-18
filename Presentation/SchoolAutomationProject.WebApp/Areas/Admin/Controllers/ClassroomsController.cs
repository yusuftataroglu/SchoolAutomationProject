using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
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
        private readonly IStudentReadRepository _studentReadRepository;

        public ClassroomsController(
            IMapper mapper,
            IClassroomReadRepository classroomReadRepository,
            IClassroomWriteRepository classroomWriteRepository,
            IStudentReadRepository studentReadRepository)
        {
            _mapper = mapper;
            _classroomReadRepository = classroomReadRepository;
            _classroomWriteRepository = classroomWriteRepository;
            _studentReadRepository = studentReadRepository;
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
        public async Task<IActionResult> AddClassroom(WriteClassroomViewModel model)
        {
            if (ModelState.IsValid)
            {
                Classroom classroom = new Classroom();
                List<ClassroomMainCourse> classroomMainCourses = new List<ClassroomMainCourse>();
                List<ClassroomTeacher> classroomTeachers = new List<ClassroomTeacher>();
                List<Student> students = new List<Student>();

                foreach (var modelMainCourseId in model.ClassroomMainCoursesMainCourseIds)
                {
                    var classroomMainCourse = new ClassroomMainCourse()
                    {
                        ClassroomId = classroom.Id,
                        MainCourseId = Guid.Parse(modelMainCourseId)
                    };
                    classroomMainCourses.Add(classroomMainCourse);
                }

                //Id ile öğrenciyi bul
                foreach (var modelStudentId in model.StudentIds)
                {
                    students.Add(await _studentReadRepository.GetByIdAsync(modelStudentId));
                }

                foreach (var modelTeacherId in model.ClassroomTeachersTeacherIds)
                {
                    var classroomTeacher = new ClassroomTeacher()
                    {
                        ClassroomId = classroom.Id,
                        TeacherId = Guid.Parse(modelTeacherId)
                    };
                    classroomTeachers.Add(classroomTeacher);
                }

                classroom.Name = model.Name;
                classroom.Capacity = model.Capacity;
                classroom.ClassroomTeachers = classroomTeachers;
                classroom.ClassroomMainCourses = classroomMainCourses;
                classroom.Students = students;

                var result = await _classroomWriteRepository.AddAsync(classroom);
                if (result)
                {
                    await _classroomWriteRepository.SaveChangesAsync();
                    TempData["Success"] = "Sınıf başarıyla eklendi";
                    return RedirectToAction("GetClassrooms");
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

        [HttpGet]
        public async Task<IActionResult> UpdateClassroom(string id)
        {
            var classroom = await _classroomReadRepository.GetByIdAsync(id);
            if (classroom != null)
            {
                var classroomVM = new WriteClassroomViewModel()
                {
                    Name = classroom.Name,
                    Capacity = classroom.Capacity,
                    StudentIds = classroom.Students.Select(x => x.Id.ToString()).ToList(),
                    ClassroomMainCoursesMainCourseIds = classroom.ClassroomMainCourses.Select(x => x.MainCourseId.ToString()).ToList(),
                    ClassroomTeachersTeacherIds = classroom.ClassroomTeachers.Select(x => x.TeacherId.ToString()).ToList()
                };
                return View(classroomVM);
            }
            else
            {
                TempData["Error"] = "Bu sınıf veri tabanında mevcut değil!";
                return RedirectToAction("GetClassrooms");
            }
        }

        [HttpPost]
        public IActionResult UpdateClassroom(WriteClassroomViewModel model)
        {
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteClassroom(string id)
        {
            var classroom = await _classroomReadRepository.GetByIdAsync(id);
            if (classroom != null)
            {
                var deleteResult = _classroomWriteRepository.Remove(classroom);
                if (deleteResult)
                {
                    await _classroomWriteRepository.SaveChangesAsync();
                    TempData["Success"] = "Silme işlemi başarıyla gerçekleşti";
                }
                else
                {
                    TempData["Error"] = "Silme işleminde bir sorun oluştu!";
                }
            }
            else
            {
                TempData["Error"] = "Bu sınıf veri tabanında bulunmuyor!";
            }
            return RedirectToAction("GetClassrooms");
        }
    }
}
