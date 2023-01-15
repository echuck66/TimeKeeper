using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public class UserSettings : ObjectBase
    {

        public RoundingOption? TimeRoundingOption { get; set; } = RoundingOption.Nearest15Minute;
    }
}
