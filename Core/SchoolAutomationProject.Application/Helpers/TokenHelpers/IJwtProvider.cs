using SchoolAutomationProject.Domain.Entities.IdentityTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Application.Helpers.TokenHelpers
{
    public interface IJwtProvider
    {
        public string GenerateJwt(AppUser user);
    }
}
