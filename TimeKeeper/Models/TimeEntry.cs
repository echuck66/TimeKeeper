using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public class TimeEntry : ObjectBase
    {

        public Guid TaskId { get; set; }

        public Guid TimeSheetId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string Note { get; set; }

        public bool TaskCompleted { get; set; }

        public TimeEntryStatus Status { get; set; }
    }
}
