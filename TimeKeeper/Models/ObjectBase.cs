﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeeper.Models
{
    public abstract class ObjectBase
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

    }
}
