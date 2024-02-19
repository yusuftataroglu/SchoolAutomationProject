﻿using SchoolAutomationProject.Application.ViewModels.ClassroomViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.ClassroomFillRelationshipsServices
{
    public interface IClassroomFillRelationshipsService
    {
        public Task FillClassroomRelationships(Classroom classroom, WriteClassroomViewModel modelVM, string requestType);
    }
}
