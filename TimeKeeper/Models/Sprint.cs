using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public class Sprint : ObjectBase
    {

        public Guid ProjectId { get; set; }

        public string SprintIdentifier { get; set; }

        public string Title { get; set; }

        public string Objective { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public ObjectStatus Status { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeDelete)]
        public List<SprintTask> Tasks { get; set; } = new List<SprintTask>();
    }
}
