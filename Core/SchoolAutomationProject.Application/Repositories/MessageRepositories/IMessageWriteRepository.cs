using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.CustomTables;

namespace SchoolAutomationProject.Application.Repositories.MessageRepositories
{
    public interface IMessageWriteRepository:IWriteRepository<Message>
    {
    }
}
