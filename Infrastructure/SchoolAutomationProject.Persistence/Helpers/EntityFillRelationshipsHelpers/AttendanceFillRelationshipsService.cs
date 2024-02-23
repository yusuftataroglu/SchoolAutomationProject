using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
using SchoolAutomationProject.Application.ViewModels.AttendanceViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class AttendanceFillRelationshipsService : IAttendanceFillRelationshipsService
    {
        private readonly IStudentReadRepository _studentReadRepository;
        private readonly ISubCourseReadRepository _subCourseReadRepository;

        public AttendanceFillRelationshipsService(IStudentReadRepository studentReadRepository, ISubCourseReadRepository subCourseReadRepository)
        {
            _studentReadRepository = studentReadRepository;
            _subCourseReadRepository = subCourseReadRepository;
        }
        public async Task FillAttendanceRelationships(Attendance attendance, WriteAttendanceViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                attendance.AttendanceDate = modelVM.AttendanceDate;
                attendance.AttendanceStatus = modelVM.AttendanceStatus;

                if (!string.IsNullOrEmpty(modelVM.StudentId))
                {
                    var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                    if (student != null)
                    {
                        attendance.Student = student;
                    }
                }

                if (!string.IsNullOrEmpty(modelVM.SubCourseId))
                {
                    var subCourse = await _subCourseReadRepository.GetByIdAsync(modelVM.SubCourseId);
                    if (subCourse != null)
                    {
                        attendance.SubCourse = subCourse;
                    }
                }
            }
            else if (requestType == "UpdateGet")
            {
                modelVM.StudentId = attendance.StudentId?.ToString();
                modelVM.SubCourseId = attendance.SubCourseId?.ToString();
            }
        }
    }
}
