using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public class Project : ObjectBase
    {

        public string ProjectIdentifier { get; set; }

        public string Name { get; set; }

        public ObjectStatus Status { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.CascadeDelete)]
        public List<Sprint> Sprints { get; set; } = new List<Sprint>();

        public override string ToString()
        {
            return Name;
        }
    }
}
