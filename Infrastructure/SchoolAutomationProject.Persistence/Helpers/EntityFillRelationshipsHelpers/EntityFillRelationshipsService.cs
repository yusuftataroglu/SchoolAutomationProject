﻿using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AttendanceViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ClassroomViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.DiscontinuedStudentViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.GradeViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.MainCourseViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.ParentViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SemesterViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.StudentViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SubCourseViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherScheduleViewModels;
using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.TeacherViewModels;

using SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels;

using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Persistence.Helpers.EntityFillRelationshipsHelpers
{
    public class FillEntityRelationshipsService : IFillEntityRelationshipsService
    {
        private readonly IAchievementFillRelationshipsService _achievementFillRelationshipsService;
        private readonly IAttendanceFillRelationshipsService _attendanceFillRelationshipsService;
        private readonly IDiscontinuedStudentFillRelationshipsService _discontinuedStudentFillRelationshipsService;
        private readonly IGradeFillRelationshipsService _gradeFillRelationshipsService;
        private readonly IParentFillRelationshipsService _parentFillRelationshipsService;
        private readonly ISemesterFillRelationshipsService _semesterFillRelationshipsService;
        private readonly IStudentFillRelationshipsService _studentFillRelationshipsService;
        private readonly ISubCourseFillRelationshipsService _subCourseFillRelationshipsService;
        private readonly ITeacherScheduleFillRelationshipsService _teacherScheduleFillRelationshipsService;
        private readonly IClassroomFillRelationshipsService _classroomFillRelationshipsService;
        private readonly ITeacherFillRelationshipsService _teacherFillRelationshipsService;
        private readonly IMainCourseFillRelationshipsService _mainCourseFillRelationshipsService;

        public FillEntityRelationshipsService(
            IAchievementFillRelationshipsService achievementFillRelationshipsService,
            IAttendanceFillRelationshipsService attendanceFillRelationshipsService,
            IClassroomFillRelationshipsService classroomFillRelationshipsService,
            IDiscontinuedStudentFillRelationshipsService discontinuedStudentFillRelationshipsService,
            IGradeFillRelationshipsService gradeFillRelationshipsService,
            IMainCourseFillRelationshipsService mainCourseFillRelationshipsService,
            IParentFillRelationshipsService parentFillRelationshipsService,
            ISemesterFillRelationshipsService semesterFillRelationshipsService,
            IStudentFillRelationshipsService studentFillRelationshipsService,
            ISubCourseFillRelationshipsService subCourseFillRelationshipsService,
            ITeacherFillRelationshipsService teacherFillRelationshipsService,
            ITeacherScheduleFillRelationshipsService teacherScheduleFillRelationshipsService)
        {
            _achievementFillRelationshipsService = achievementFillRelationshipsService;
            _attendanceFillRelationshipsService = attendanceFillRelationshipsService;
            _classroomFillRelationshipsService = classroomFillRelationshipsService;
            _discontinuedStudentFillRelationshipsService = discontinuedStudentFillRelationshipsService;
            _gradeFillRelationshipsService = gradeFillRelationshipsService;
            _mainCourseFillRelationshipsService = mainCourseFillRelationshipsService;
            _parentFillRelationshipsService = parentFillRelationshipsService;
            _semesterFillRelationshipsService = semesterFillRelationshipsService;
            _studentFillRelationshipsService = studentFillRelationshipsService;
            _subCourseFillRelationshipsService = subCourseFillRelationshipsService;
            _teacherFillRelationshipsService = teacherFillRelationshipsService;
            _teacherScheduleFillRelationshipsService = teacherScheduleFillRelationshipsService;
        }

        public async Task FillEntityRelationships<T, TWriteViewModel>(T entity, TWriteViewModel modelVM, string requestType)
        {
            if (typeof(T) == typeof(Achievement))
            {
                await _achievementFillRelationshipsService.FillAchievementRelationships(entity as Achievement, modelVM as WriteAchievementViewModel, requestType);
            }
            else if (typeof(T) == typeof(Attendance))
            {
                if (typeof(TWriteViewModel).FullName== "SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel")
                {
                    await _attendanceFillRelationshipsService.FillAttendanceRelationshipsForAdmin(entity as Attendance, modelVM as Application.ViewModels.AdminAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel, requestType);
                }
                else
                {
                    await _attendanceFillRelationshipsService.FillAttendanceRelationshipsForTeacher(entity as Attendance, modelVM as Application.ViewModels.TeacherAreaViewModels.AttendanceViewModels.WriteAttendanceViewModel, requestType);
                }
            }
            else if (typeof(T) == typeof(Classroom))
            {
                await _classroomFillRelationshipsService.FillClassroomRelationships(entity as Classroom, modelVM as WriteClassroomViewModel, requestType);
            }
            else if (typeof(T) == typeof(DiscontinuedStudent))
            {
                await _discontinuedStudentFillRelationshipsService.FillDiscontinuedStudentRelationships(entity as DiscontinuedStudent, modelVM as WriteDiscontinuedStudentViewModel, requestType);
            }
            else if (typeof(T) == typeof(Grade))
            {
                await _gradeFillRelationshipsService.FillGradeRelationships(entity as Grade, modelVM as WriteGradeViewModel, requestType);
            }
            else if (typeof(T) == typeof(MainCourse))
            {
                await _mainCourseFillRelationshipsService.FillMainCourseRelationships(entity as MainCourse, modelVM as WriteMainCourseViewModel, requestType);
            }
            else if (typeof(T) == typeof(Parent))
            {
                await _parentFillRelationshipsService.FillParentRelationships(entity as Parent, modelVM as WriteParentViewModel, requestType);
            }
            else if (typeof(T) == typeof(Semester))
            {
                await _semesterFillRelationshipsService.FillSemesterRelationships(entity as Semester, modelVM as WriteSemesterViewModel, requestType);
            }
            else if (typeof(T) == typeof(Student))
            {
                await _studentFillRelationshipsService.FillStudentRelationships(entity as Student, modelVM as WriteStudentViewModel, requestType);
            }
            else if (typeof(T) == typeof(SubCourse))
            {
                await _subCourseFillRelationshipsService.FillSubCourseRelationships(entity as SubCourse, modelVM as WriteSubCourseViewModel, requestType);
            }
            else if (typeof(T) == typeof(Teacher))
            {
                await _teacherFillRelationshipsService.FillTeacherRelationships(entity as Teacher, modelVM as WriteTeacherViewModel, requestType);
            }
            else if (typeof(T) == typeof(TeacherSchedule))
            {
                await _teacherScheduleFillRelationshipsService.FillTeacherScheduleRelationships(entity as TeacherSchedule, modelVM as WriteTeacherScheduleViewModel, requestType);
            }
        }

    }
}

