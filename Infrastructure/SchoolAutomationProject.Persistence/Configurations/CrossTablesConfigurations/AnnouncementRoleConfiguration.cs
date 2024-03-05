using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.CrossTables;

namespace SchoolAutomationProject.Persistence.Configurations.CrossTablesConfigurations
{
    public class AnnouncementRoleConfiguration : IEntityTypeConfiguration<AnnouncementRole>
    {
        public void Configure(EntityTypeBuilder<AnnouncementRole> builder)
        {
            builder.HasKey(x => new { x.AnnouncementId, x.RoleId });
            builder.HasOne(a => a.Announcement).WithMany(a => a.AnnouncementRoles).HasForeignKey(a => a.AnnouncementId).IsRequired();
            builder.HasOne(a => a.Role).WithMany(a => a.AnnouncementRoles).HasForeignKey(a => a.RoleId).IsRequired();
        }
    }
}
