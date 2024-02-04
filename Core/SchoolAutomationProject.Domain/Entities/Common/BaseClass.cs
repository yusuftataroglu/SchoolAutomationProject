﻿namespace SchoolAutomationProject.Domain.Entities.Common
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.UtcNow;
            CreatedComputerName = Environment.MachineName;
        }
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }
        public DateTime? UpdatedDate { get; set; }//todo güncellendiğinde değiştirilecek.(ChangeTracker)
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
    }
}