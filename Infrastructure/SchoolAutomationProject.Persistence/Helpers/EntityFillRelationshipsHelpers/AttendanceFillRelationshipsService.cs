using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.StudentRepositories;
using SchoolAutomationProject.Application.Repositories.SubCourseRepositories;
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

        public async Task FillAttendanceRelationshipsForAdmin(Attendance attendance, Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                attendance.AttendanceDate = modelVM.AttendanceDate;
                attendance.AttendanceStatus = modelVM.AttendanceStatus;

                var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                if (student != null)
                {
                    attendance.Student = student;
                }

                var subCourse = await _subCourseReadRepository.GetByIdAsync(modelVM.SubCourseId);
                if (subCourse != null)
                {
                    attendance.SubCourse = subCourse;
                }
            }
        }

        public async Task FillAttendanceRelationshipsForTeacher(Attendance attendance, Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel modelVM, string requestType)
        {
            if (requestType == "Add" || requestType == "UpdatePost")
            {
                attendance.AttendanceDate = modelVM.AttendanceDate;
                attendance.AttendanceStatus = modelVM.AttendanceStatus;

                var student = await _studentReadRepository.GetByIdAsync(modelVM.StudentId);
                if (student != null)
                {
                    attendance.Student = student;
                }

                var subCourse = await _subCourseReadRepository.GetByIdAsync(modelVM.SubCourseId);
                if (subCourse != null)
                {
                    attendance.SubCourse = subCourse;
                }
            }
        }
    }
}
