﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AttendancesController : GenericController<Attendance, ReadAttendanceViewModel, WriteAttendanceViewModel>
    {

        public AttendancesController(
            IAttendanceReadRepository readRepository,
            IAttendanceWriteRepository writeRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper)
            : base(readRepository, writeRepository, mapper, fillEntityRelationshipsService)

        {
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Devamsızlık Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Devamsızlık Durumu", "Devamsızlık Tarihi", "Devamsızlık Yapılan Ders" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "AttendanceStatus", "AttendanceDateShort", "SubCourseCode" };
            ViewData["ControllerName"] = "Attendances";
            return base.Get();
        }
        public override async Task<IActionResult> Details(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Devamsızlık Detayı";
            ViewData["CustomColumnTitles"] = new List<string> { "Öğrenci", "Devamsızlık Durumu", "Devamsızlık Tarihi", "Devamsızlık Yapılan Ders" };
            ViewData["CustomProperties"] = new List<string> { "StudentFullName", "AttendanceStatus", "AttendanceDateShort", "SubCourseCode" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteAttendanceViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(Guid id)
        {
            return await base.Update(id);
        }


        public override async Task<IActionResult> Update(WriteAttendanceViewModel modelVM)
        {
            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}