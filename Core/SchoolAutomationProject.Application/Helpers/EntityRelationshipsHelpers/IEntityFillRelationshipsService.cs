﻿namespace SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers
{
    public interface IFillEntityRelationshipsService
    {
        public Task FillEntityRelationships<T, TWriteViewModel>(T entity, TWriteViewModel model, string requestType);
    }
}
