﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.ViewModels.GradeViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GradesController : GenericController<Grade, ReadGradeViewModel, WriteGradeViewModel>
    {

        public GradesController(
            IGradeReadRepository readRepository,
            IGradeWriteRepository writeRepository,
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