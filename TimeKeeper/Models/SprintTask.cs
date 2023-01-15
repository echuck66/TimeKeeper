using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public class SprintTask : ObjectBase
    {

        public Guid ProjectId { get; set; }

        public Guid SprintId { get; set; }

        public string TaskIdentifier { get; set; }

        public TaskStatus Status { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan? EstimatedTimeTotal { get; set; }

        public TimeSpan? EstimatedTimeToCompletion { get; set; }

        public TimeSpan? TotalTimeRecorded { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeDelete)]
        public List<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    }
}
