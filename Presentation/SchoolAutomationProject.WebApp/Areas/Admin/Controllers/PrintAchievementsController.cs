using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PrintAchievementsController : Controller
    {
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly IAchievementReadRepository _achievementReadRepository;

        public PrintAchievementsController(IStudentReadRepository studentReadRepository, IAchievementReadRepository achievementReadRepository)
        {
            _studentReadRepository = studentReadRepository;
            _achievementReadRepository = achievementReadRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PrintAchievement(Guid id)
        {
            Achievement achievement = await _achievementReadRepository.GetActiveByIdAsync(id);

            if (achievement.Type == Domain.Entities.Enums.AchievementType.Teşekkür)
            {
                return RedirectToAction("PrintCertificateOfAchievement", new { id = id });
            }
            else if (achievement.Type == Domain.Entities.Enums.AchievementType.Takdir)
            {
                return RedirectToAction("PrintCertificateOfHighAchievement", new { id = id });

            }
            else
            {
                TempData["Error"] = "Bir Hata Meydana Geldi!";
                return RedirectToAction("Get", "Achievements");
            }
        }


        [HttpGet]
        public async Task<IActionResult> PrintCertificateOfAchievement(Guid id)
        {
            Achievement achievement = await _achievementReadRepository.GetActiveByIdAsync(id);
            TempData["Date"] = DateTime.Now.ToShortDateString();
            TempData["Year"] = $"{achievement.Semester.StartDate.Year}/{achievement.Semester.EndDate.Year}";

            if (achievement.Semester.Name.Contains("Güz", StringComparison.OrdinalIgnoreCase))
            {
                TempData["SemesterNo"] = "1.";
            }
            else if (achievement.Semester.Name.Contains("Bahar", StringComparison.OrdinalIgnoreCase))
            {
                TempData["SemesterNo"] = "2.";
            }
            return View(achievement.Student);
        }

        [HttpGet]
        public async Task<IActionResult> PrintCertificateOfHighAchievement(Guid id)
        {
            Achievement achievement = await _achievementReadRepository.GetActiveByIdAsync(id);

            TempData["Date"] = DateTime.Now.ToShortDateString();
            TempData["Year"] = $"{achievement.Semester.StartDate.Year}/{achievement.Semester.EndDate.Year}";

            if (achievement.Semester.Name.Contains("Güz", StringComparison.OrdinalIgnoreCase))
            {
                TempData["SemesterNo"] = "1.";
            }
            else if (achievement.Semester.Name.Contains("Bahar", StringComparison.OrdinalIgnoreCase))
            {
                TempData["SemesterNo"] = "2.";
            }
            return View(achievement.Student);
        }

        [HttpGet]
        public async Task<IActionResult> PrintReportCard(Guid id)
        {
            var student = await _studentReadRepository.GetActiveByIdAsync(id);

            if (student.Classroom != null)
            {
                ViewData["ClassroomName"] = student.Classroom.Name;
            }
            else
            {
                ViewData["ClassroomName"] = "Atanmamış Öğrenci";
            }

            ViewData["Grades"] = student.Grades;

            if (student.Classroom != null)
            {
            ViewData["MainCourseNames"] = student.Classroom.ClassroomMainCourses.Select(x => x.MainCourse).Where(x => x.IsActive).Select(x => x.Name).ToList();
            }
            else
            {
                ViewData["MainCourseNames"] = "";
            }

            ViewData["ExcusedAbsenceCount"] = student.Attendances.Where(x => x.IsActive && (x.AttendanceStatus == Domain.Entities.Enums.AttendanceStatus.Görevli || x.AttendanceStatus == Domain.Entities.Enums.AttendanceStatus.İzinli)).Count();

            ViewData["UnexcusedAbsenceCount"] = student.Attendances.Where(x => x.IsActive && x.AttendanceStatus == Domain.Entities.Enums.AttendanceStatus.Yok).Count();

            ViewData["ParentFullName"] = $"{student.Parent.FirstName} {student.Parent.LastName}";

            ViewData["Season"] = "2023/2024";

            return View(student);
        }
    }
}
