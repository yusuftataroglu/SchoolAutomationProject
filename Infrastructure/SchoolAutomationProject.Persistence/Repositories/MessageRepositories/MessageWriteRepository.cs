using SchoolAutomationProject.Application.Repositories.MessageRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;
using SchoolAutomationProject.Persistence.Contexts;
using SchoolAutomationProject.Persistence.Repositories.CommonRepositories;

namespace SchoolAutomationProject.Persistence.Repositories.MessageRepositories
{
    public class MessageWriteRepository : WriteRepository<Message>, IMessageWriteRepository
    {
        public MessageWriteRepository(SchoolAutomationProjectDbContext context) : base(context)
        {
        }
    }
}
