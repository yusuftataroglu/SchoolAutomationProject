namespace SchoolAutomationProject.Domain.Entities.CommonTables
{
    public abstract class BaseClass
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
