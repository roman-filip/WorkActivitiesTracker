using System;
using System.Collections.Generic;
using System.Text;

namespace WorkActivitiesTracker.Web.Shared.Models
{
    public class Timesheet
    {
        public DateTime Date { get; set; }

        public List<TimesheetEntry> Entries { get; set; }
    }

    public class TimesheetEntry
    {
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
