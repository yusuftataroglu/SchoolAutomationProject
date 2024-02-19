using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.CommonEntityFillRelationshipsServices;
using SchoolAutomationProject.Application.Repositories.ClassroomRepositories;
using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClassroomsController : GenericController<Classroom, ReadClassroomViewModel, WriteClassroomViewModel>
    {

        public ClassroomsController(
            IClassroomReadRepository readRepository,
            IClassroomWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsRepository,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsRepository)

        {
        }

        public override IActionResult Get()
        {
            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteClassroomViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }

        
        public override async Task<IActionResult> Update(WriteClassroomViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }


    }
}





//#region EskiClassroomController






//[HttpPost]
//public async Task<IActionResult> AddClassroom(WriteClassroomViewModel model)
//{
//    if (ModelState.IsValid)
//    {
//        Classroom classroom = new Classroom();
//        List<ClassroomMainCourse> classroomMainCourses = new List<ClassroomMainCourse>();
//        List<ClassroomTeacher> classroomTeachers = new List<ClassroomTeacher>();
//        List<Student> students = new List<Student>();

//        foreach (var modelMainCourseId in model.ClassroomMainCoursesMainCourseIds)
//        {
//            var classroomMainCourse = new ClassroomMainCourse()
//            {
//                ClassroomId = classroom.Id,
//                MainCourseId = Guid.Parse(modelMainCourseId)
//            };
//            classroomMainCourses.Add(classroomMainCourse);
//        }

//        //Id ile öğrenciyi bul
//        foreach (var modelStudentId in model.StudentIds)
//        {
//            students.Add(await _studentReadRepository.GetByIdAsync(modelStudentId.ToString()));
//        }

//        foreach (var modelTeacherId in model.ClassroomTeachersTeacherIds)
//        {
//            var classroomTeacher = new ClassroomTeacher()
//            {
//                ClassroomId = classroom.Id,
//                TeacherId = Guid.Parse(modelTeacherId)
//            };
//            classroomTeachers.Add(classroomTeacher);
//        }

//        classroom.Name = model.Name;
//        classroom.Capacity = model.Capacity;
//        classroom.ClassroomTeachers = classroomTeachers;
//        classroom.ClassroomMainCourses = classroomMainCourses;
//        classroom.Students = students;

//        var result = await _classroomWriteRepository.AddAsync(classroom);
//        if (result)
//        {
//            await _classroomWriteRepository.SaveChangesAsync();
//            TempData["Success"] = "Sınıf başarıyla eklendi";
//            return RedirectToAction("GetClassrooms");
//        }
//        else
//        {
//            TempData["Error"] = "Bir hata meydana geldi!";
//            return View(model);
//        }
//    }
//    else
//    {
//        TempData["Error"] = "Bir hata meydana geldi!";
//        return View(model);
//    }
//}


//[HttpGet]
//public async Task<IActionResult> UpdateClassroom(string id)
//{
//    var classroom = await _classroomReadRepository.GetByIdAsync(id.ToString());
//    if (classroom != null)
//    {
//        var classroomVM = new WriteClassroomViewModel()
//        {
//            Id = classroom.Id,
//            Name = classroom.Name,
//            Capacity = classroom.Capacity,
//            StudentIds = classroom.Students.Select(x => x.Id.ToString()).ToList(),
//            ClassroomMainCoursesMainCourseIds = classroom.ClassroomMainCourses.Select(x => x.MainCourseId.ToString()).ToList(),
//            ClassroomTeachersTeacherIds = classroom.ClassroomTeachers.Select(x => x.TeacherId.ToString()).ToList()
//        };
//        return View(classroomVM);
//    }
//    else
//    {
//        TempData["Error"] = "Bu sınıf veri tabanında mevcut değil!";
//        return RedirectToAction("GetClassrooms");
//    }
//}

//[HttpPost]
//public async Task<IActionResult> UpdateClassroom(WriteClassroomViewModel model)
//{
//    Classroom classroom = await _classroomReadRepository.GetByIdAsync(model.Id.ToString());

//    if (classroom != null)
//    {
//        //İlgili sınıfın ClassroomTeachers tablosunda mevcut olan değerlerini kaldırıyorum.
//        var existingClassroomTeachers = classroom.ClassroomTeachers.Where(x => x.ClassroomId == classroom.Id).ToList();
//        foreach (var existingClassroomTeacher in existingClassroomTeachers)
//        {
//            classroom.ClassroomTeachers.Remove(existingClassroomTeacher);
//        }


//        //İlgili sınıfın ClassroomMainCourses tablosunda mevcut olan değerlerini kaldırıyorum.
//        var existingClassroomMainCourses = classroom.ClassroomMainCourses.Where(x => x.ClassroomId == classroom.Id).ToList();
//        foreach (var existingClassroomMainCourse in existingClassroomMainCourses)
//        {
//            classroom.ClassroomMainCourses.Remove(existingClassroomMainCourse);
//        }


//        //İlgili sınıfın Students değerlerini kaldırıyorum.
//        List<Student> existingStudents = classroom.Students.ToList();
//        foreach (var existingStudent in existingStudents)
//        {
//            classroom.Students.Remove(existingStudent);
//        }


//        //İlgili sınıf için model'dan gelen ClassroomId değerlerini ClassroomTeachers tablosuna ekliyorum.
//        List<ClassroomTeacher> classroomTeachers = new();
//        foreach (var teacherId in model.ClassroomTeachersTeacherIds)
//        {
//            classroomTeachers.Add(new ClassroomTeacher
//            {
//                ClassroomId = classroom.Id,
//                TeacherId = Guid.Parse(teacherId)
//            });
//        }


//        //İlgili sınıf için model'dan gelen MainCourseId değerlerini ClassroomMainCourses tablosuna ekliyorum.
//        List<ClassroomMainCourse> classroomMainCourses = new();
//        foreach (var mainCourseId in model.ClassroomMainCoursesMainCourseIds)
//        {
//            classroomMainCourses.Add(new ClassroomMainCourse
//            {
//                ClassroomId = classroom.Id,
//                MainCourseId = Guid.Parse(mainCourseId)
//            });
//        }


//        //İlgili sınıf için model'dan gelen Students değerlerini ekliyorum.
//        List<Student> students = new();
//        foreach (var studentId in model.StudentIds)
//        {
//            var student = await _studentReadRepository.GetByIdAsync(studentId.ToString());
//            students.Add(student);
//        }

//        //Güncellenen değerleri aktarıyorum.
//        classroom.Name = model.Name;
//        classroom.Capacity = model.Capacity;
//        classroom.ClassroomTeachers = classroomTeachers;
//        classroom.Students = students;
//        classroom.ClassroomMainCourses = classroomMainCourses;


//        //Veri tabanına kaydediyorum.
//        _classroomWriteRepository.Update(classroom);
//        await _classroomWriteRepository.SaveChangesAsync();
//        TempData["Success"] = "Güncelleme işlemi başarıyla gerçekleştirildi";
//        return RedirectToAction("GetClassrooms");
//    }
//    else
//    {
//        TempData["Error"] = "Bu sınıf veri tabanında bulunmuyor!";
//        return RedirectToAction("GetClassrooms");
//    }
//}

//[HttpGet]
//public async Task<IActionResult> DeleteClassroom(string id)
//{
//    var classroom = await _classroomReadRepository.GetByIdAsync(id);
//    if (classroom != null)
//    {
//        var deleteResult = _classroomWriteRepository.Remove(classroom);
//        if (deleteResult)
//        {
//            await _classroomWriteRepository.SaveChangesAsync();
//            TempData["Success"] = "Silme işlemi başarıyla gerçekleşti";
//        }
//        else
//        {
//            TempData["Error"] = "Silme işleminde bir sorun oluştu!";
//        }
//    }
//    else
//    {
//        TempData["Error"] = "Bu sınıf veri tabanında bulunmuyor!";
//    }
//    return RedirectToAction("GetClassrooms");
//}

//#endregion
