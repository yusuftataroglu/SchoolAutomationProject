﻿using Microsoft.AspNetCore.Identity;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.StudentViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using System.Formats.Tar;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class StudentFillRelationshipsService : IStudentFillRelationshipsService
    {
        private readonly IParentWriteRepository _parentWriteRepository;
        private readonly IParentReadRepository _parentReadRepository;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUserRole> _roleManager;

        public StudentFillRelationshipsService(
            IParentWriteRepository parentWriteRepository,
            IParentReadRepository parentReadRepository,
            UserManager<AppUser> userManager,
            RoleManager<AppUserRole> roleManager)
        {
            _parentWriteRepository = parentWriteRepository;
            _parentReadRepository = parentReadRepository;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task FillStudentRelationships(Student student, WriteStudentViewModel modelVM, string requestType)
        {
            if (requestType == "Add")
            {
                Parent parent = new Parent
                {
                    Id = Guid.NewGuid(),
                    FirstName = modelVM.ParentFirstName,
                    LastName = modelVM.ParentLastName,
                    MobilePhone = modelVM.ParentMobilePhone,
                    WorkPhone = modelVM.ParentWorkPhone,
                    Address = modelVM.ParentAddress,
                    District = modelVM.ParentDistrict,
                    City = modelVM.ParentCity
                };

                await _parentWriteRepository.AddAsync(parent);
                AppUser studentUser = new AppUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"{student.FirstName.ToLower()}{student.LastName.ToLower()}",
                    NormalizedUserName = $"{student.FirstName.ToUpper()}{student.LastName.ToUpper()}",
                    Email = ""
                };
                AppUser parentUser = new AppUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = $"{parent.FirstName.ToLower()}{parent.LastName.ToLower()}",
                    NormalizedUserName = $"{parent.FirstName.ToUpper()}{parent.LastName.ToUpper()}",
                    Email = ""
                };
                var createParentUserResult = await _userManager.CreateAsync(parentUser,$"{parent.FirstName.ToLower()}{parent.LastName.ToLower()}");
                var createStudentUserResult = await _userManager.CreateAsync(studentUser,$"{student.FirstName.ToLower()}{student.LastName.ToLower()}");
                if (createParentUserResult.Succeeded && createStudentUserResult.Succeeded)
                {
                    parent.User = parentUser;
                    student.User = studentUser;
                    await _userManager.AddToRoleAsync(parentUser, "Parent");
                    await _userManager.AddToRoleAsync(studentUser, "Student");
                }

                student.Parent = parent;

            }
            else if (requestType == "UpdatePost")
            {
                //student.ParentId = modelVM.ParentId;
                //student.Parent.FirstName = modelVM.ParentFirstName;
                //student.Parent.LastName = modelVM.ParentLastName;
                //student.Parent.MobilePhone = modelVM.ParentMobilePhone;
                //student.Parent.WorkPhone = modelVM.ParentWorkPhone;
                //student.Parent.Address = modelVM.ParentAddress;
                //student.Parent.District = modelVM.ParentDistrict;
                //student.Parent.City = modelVM.ParentCity;
            }
            else if (requestType == "UpdateGet")
            {
                //modelVM.ParentFirstName = student.Parent.FirstName;
                //modelVM.ParentLastName = student.Parent.LastName;
                //modelVM.ParentMobilePhone = student.Parent.MobilePhone;
                //modelVM.ParentWorkPhone = student.Parent.WorkPhone;
                //modelVM.ParentAddress = student.Parent.Address;
                //modelVM.ParentDistrict = student.Parent.District;
                //modelVM.ParentCity = student.Parent.City;
            }
        }
    }
}
