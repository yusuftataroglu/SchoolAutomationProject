﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AdministratorRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AdministratorViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using SchoolAutomationProject.WebApp.Controllers;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdministratorsController : GenericController<Administrator, ReadAdministratorViewModel, WriteAdministratorViewModel>
    {
        private readonly UserManager<AppUser> _userManager;

        public AdministratorsController(
            IAdministratorReadRepository achievementReadRepository,
            IAdministratorWriteRepository achievementWriteRepository,
            IFillEntityRelationshipsService fillEntityRelationshipsService,
            IMapper mapper,
            UserManager<AppUser> userManager)
            : base(achievementReadRepository, achievementWriteRepository, mapper, fillEntityRelationshipsService)

        {
            _userManager = userManager;
        }

        public override IActionResult Get()
        {
            // ViewData dictionary'sine özel verileri atama
            ViewData["TableTitle"] = "Yönetici Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "İsim", "Soyisim", "Ünvan" };
            ViewData["CustomProperties"] = new List<string> { "FirstName", "LastName","Title" };
            ViewData["ControllerName"] = "Administrators";
            return base.Get();
        }
        public override async Task<IActionResult> Details(Guid id)
        {
            //ViewData dictionary'sine ortak verileri atama
            ViewData["TableTitle"] = "Yönetici Listesi";
            ViewData["CustomColumnTitles"] = new List<string> { "İsim", "Soyisim", "Ünvan", "Kullanıcı Adı" };
            ViewData["CustomProperties"] = new List<string> { "FirstName", "LastName", "Title", "UserName" };
            return await base.Details(id);
        }

        public override IActionResult Add()
        {
            return base.Add();
        }

        public override async Task<IActionResult> Add(WriteAdministratorViewModel modelVM)
        {
            return await base.Add(modelVM);
        }

        public override async Task<IActionResult> Update(Guid id)
        {
            return await base.Update(id);
        }

        public override async Task<IActionResult> Update(WriteAdministratorViewModel modelVM)
        {
            var user = await _userManager.FindByIdAsync(modelVM.UserId);
            modelVM.User = user;

            return await base.Update(modelVM);
        }

        public override async Task<IActionResult> Delete(Guid id)
        {
            return await base.Delete(id);
        }
    }
}