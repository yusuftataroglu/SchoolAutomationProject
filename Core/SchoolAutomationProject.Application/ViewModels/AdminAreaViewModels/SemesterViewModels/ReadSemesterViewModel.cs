﻿using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.Application.ViewModels.AdminAreaViewModels.SemesterViewModels
{
    public class ReadSemesterViewModel : BaseClass, IReadViewModel
    {
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"
        public DateTime StartDate { get; set; }
        public string StartDateShort => StartDate.ToShortDateString();
        public DateTime EndDate { get; set; }
        public string EndDateShort => EndDate.ToShortDateString();

    }
}
