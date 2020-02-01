﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911WebAPI.Models
{
    public class Timesheet
    {
        public int TimesheetId { get; set; }
        public int EmployeeId { get; set; }

        public int WeekNumber { get; set; }

        public Employee Employee { get; set; }
        public IList<TimesheetRow> TimesheetRows { get; set; }

        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedTime { get; set; }

    }
}
