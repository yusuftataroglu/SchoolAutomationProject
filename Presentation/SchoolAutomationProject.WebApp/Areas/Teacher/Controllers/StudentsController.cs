using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels;
using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.StudentViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class StudentsController : Controller
    {
        public StudentsController(
           )
            
        {
        }

        public IActionResult Get(string id)
        {
            return View();
        }
    }
}
