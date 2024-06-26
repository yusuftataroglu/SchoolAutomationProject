﻿using SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.AchievementViewModels;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IAchievementFillRelationshipsService
    {
        public Task FillAchievementRelationships(Achievement achievement, WriteAchievementViewModel modelVM, string requestType);
    }
}
