﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.API.Data.Abstraction
{
    public interface IDatabaseConfiguration
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
