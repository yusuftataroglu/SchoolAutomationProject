using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolAutomationProject.Domain.Entities.IdentityTables;

namespace SchoolAutomationProject.Persistence.Configurations.IdentityTablesConfigurations
{
    public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(
       new AppUserRole { Id = "86e143a4-b96a-4821-9dad-28747c241f22", Name = "Student", NormalizedName = "STUDENT" },
       new AppUserRole { Id = "bdac7a93-f4a4-4d94-a5ab-b4e6ccc7643f", Name = "Parent", NormalizedName = "PARENT" },
       new AppUserRole { Id = "bd6a6979-cbb1-4c4a-93f0-19a73a3cdcfc", Name = "Teacher", NormalizedName = "TEACHER" },
       new AppUserRole { Id = "5836daf9-1a03-4190-872a-4fdc42cf4a50", Name = "Admin", NormalizedName = "ADMIN" }
   );
            //todo WebApp aracılığıyla eklenebilir.
        }
    }
}
