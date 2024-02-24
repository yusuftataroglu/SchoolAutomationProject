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
                if (parent.ParentStudents!=null)
                {
                parent.ParentStudents.Clear();
                }
                    

                //İlgili Parent için modelVM'den gelen StudentId değerlerini ParentStudents tablosuna ekliyorum.
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
