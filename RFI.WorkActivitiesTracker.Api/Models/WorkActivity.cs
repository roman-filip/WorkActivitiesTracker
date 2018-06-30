using System;

namespace RFI.WorkActivitiesTracker.Api.Models
{
    public class WorkActivity
    {
        public int? Id { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }


        // TODO - maybe I should create special classes where will be only some of properies below
        // based on the controller where they are used.
        // Typically only two of them should be set (in ProjectsController it makes no sense to se Project etc)
        public User User { get; set; }
        public Activity Activity { get; set; }
        public Project Project { get; set; }
    }
}
