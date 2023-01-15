using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public class TimeSheet : ObjectBase
    {

        public Guid ProjectId { get; set; }

        public Guid SprintId { get; set; }

        public TimeEntryStatus Status { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeDelete)]
        public List<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>();
    }
}
