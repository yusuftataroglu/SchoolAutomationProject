﻿using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CrossTables;
using SchoolAutomationProject.Domain.Entities.IdentityTables;
using System.ComponentModel.DataAnnotations;

namespace SchoolAutomationProject.Application.ViewModels.TeacherAreaViewModels.AnnouncementViewModels
{
    public class WriteAnnouncementViewModel : IWriteViewModel
    {
        public WriteAnnouncementViewModel()
        {
            AnnouncementRolesRoleIds = new();
        }
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Duyuru Başlığı Boş Geçilemez!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Duyuru İçeriği Boş Geçilemez!")]
        public string Content { get; set; }
        public AppUser? Sender { get; set; }
        public string? SenderId { get; set; }
        public ICollection<AnnouncementRole>? AnnouncementRoles { get; set; }
        public List<string>? AnnouncementRolesRoleIds { get; set; }
    }
}
