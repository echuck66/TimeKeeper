using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public enum ObjectStatus
    {
        Plannning,
        Open,
        Closed
    }

    public enum TaskStatus
    {
        Staged,
        ReadyForWork,
        InProgress,
        Blocked,
        Complete
    }

    public enum TimeEntryStatus
    {
        Pending,
        Posted,
        Archived
    }

    public enum RoundingOption
    {
        NearestMinute,
        Nearest15Minute,
        Nearest30Minute,
        NearestHour
    }
}
