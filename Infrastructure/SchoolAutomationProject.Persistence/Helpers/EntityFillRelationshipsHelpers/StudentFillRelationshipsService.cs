using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.AchievementRepositories;
using SchoolAutomationProject.Application.Repositories.AttendanceRepositories;
using SchoolAutomationProject.Application.Repositories.GradeRepositories;
using SchoolAutomationProject.Application.Repositories.ParentRepositories;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.StudentViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using System.Formats.Tar;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class StudentFillRelationshipsService : IStudentFillRelationshipsService
    {
        private readonly IParentWriteRepository _parentWriteRepository;
        private readonly IParentReadRepository _parentReadRepository;

        public StudentFillRelationshipsService(
            IParentWriteRepository parentWriteRepository,
            IParentReadRepository parentReadRepository)
        {
            _parentWriteRepository = parentWriteRepository;
            _parentReadRepository = parentReadRepository;
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

                await _parentWriteRepository.AddAsync(parent); //todo user oluşturulacak
                student.ParentId = parent.Id; 

            }
            else if (requestType == "UpdatePost")
            {
            }
        }
    }
}
