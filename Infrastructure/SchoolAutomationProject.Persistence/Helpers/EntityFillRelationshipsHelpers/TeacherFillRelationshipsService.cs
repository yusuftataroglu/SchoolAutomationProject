using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.TeacherViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class TeacherFillRelationshipsService : ITeacherFillRelationshipsService
    {
        public async Task FillTeacherRelationships(Teacher teacher, WriteTeacherViewModel modelVM, string requestType)
        {
            teacher.FirstName = modelVM.FirstName;
            teacher.LastName = modelVM.LastName;
            teacher.Title = modelVM.Title;
            teacher.MainCourseId = Guid.Parse(modelVM.MainCourseId);

            if (requestType == "Add")
            {
                teacher.MainCourseId = Guid.Parse(modelVM.MainCourseId);

                // Sınıf öğretmenleri ekleniyor
                foreach (var classroomId in modelVM.ClassroomTeachersClassroomIds)
                {
                    var classroomTeacher = new ClassroomTeacher()
                    {
                        ClassroomId = Guid.Parse(classroomId),
                        TeacherId = teacher.Id
                    };
                    teacher.ClassroomTeachers.Add(classroomTeacher);
                }
            }
            else if (requestType == "UpdateGet")
            {
                //Öğretmenin girdiği sınıfları modelVM'e aktar
                modelVM.ClassroomTeachersClassroomIds = teacher.ClassroomTeachers.Select(x => x.ClassroomId.ToString()).ToList();
            }
            else if (requestType == "UpdatePost")
            {
                // Öğretmenin sahip olduğu sınıf öğretmenlerini güncelle
                //var existingClassroomTeachers = teacher.ClassroomTeachers.ToList();
                //foreach (var existingClassroomTeacher in existingClassroomTeachers)
                //{
                //    teacher.ClassroomTeachers.Remove(existingClassroomTeacher);
                //}
                teacher.ClassroomTeachers.Clear();

                // İlgili ClassroomTeachers ekleniyor
                foreach (var classroomId in modelVM.ClassroomTeachersClassroomIds)
                {
                    var classroomTeacher = new ClassroomTeacher()
                    {
                        ClassroomId = Guid.Parse(classroomId),
                        TeacherId = teacher.Id
                    };
                    teacher.ClassroomTeachers.Add(classroomTeacher);
                }
            }
        }
    }
}
