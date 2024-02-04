﻿using SchoolAutomationProject.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAutomationProject.Domain.Entities
{
    public class Season:BaseClass
    {
        public Guid Id { get; set; } // Season Id'si
        public string Name { get; set; } // Örneğin "2022-2023 Spring Season"
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //todo Season diğer özellikler ve ilişkiler...
    }
}
