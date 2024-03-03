﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    [Authorize(Roles = "Teacher")]
    public class GradesController : GenericController<Grade, ReadGradeViewModel, WriteGradeViewModel>
    {
        public GradesController(
            IGradeReadRepository readRepository,
            IGradeWriteRepository writeRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)
        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Not Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Alt Ders", "Sınav Numarası", "Not" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "SubCourseCode", "ExamNumber", "Score" };
            ViewData["ControllerName"] = "Grades";

            return base.Get();
        }
        public override async Task<IActionResult> Details(string id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Not Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Alt Ders", "Sınav Numarası", "Not" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "SubCourseCode", "ExamNumber", "Score" };
            return await base.Details(id);
        }

        public async Task<IActionResult> AddWithStudentInfos(string id)
        {
            var gradeVM = new WriteGradeViewModel
            {
                StudentId=id
            };
            return View(gradeVM);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteGradeViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(string id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteGradeViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(string id)
        {
            return await base.Delete(id);
        }
    }
}
