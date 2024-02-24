using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.ParentViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class ParentFillRelationshipsService : IParentFillRelationshipsService
    {
        public void FillParentRelationships(Parent parent, WriteParentViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                parent.FirstName = modelVM.FirstName;
                parent.LastName = modelVM.LastName;
                parent.MobilePhone = modelVM.MobilePhone;
                parent.WorkPhone = modelVM.WorkPhone;
                parent.Address = modelVM.Address;
                parent.District = modelVM.District;
                parent.City = modelVM.City;

                if (parent.ParentStudents!=null)
                {
                parent.ParentStudents.Clear();
                }

                // İlgili StudentsId ekleniyor
                foreach (var studentId in modelVM.ParentStudentsStudentIds)
                {
                    parent.ParentStudents.Add(new ParentStudent { ParentId = parent.Id, StudentId = Guid.Parse(studentId) });
                }
            }
            else if (requestType == "UpdateGet")
            {
                modelVM.ParentStudentsStudentIds = parent.ParentStudents.Select(x => x.StudentId.ToString()).ToList();
            }
        }
    }
}
