﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeyorLight.ObjectModel
{
    class Project
    {
        public string Name { get; set; }

        public BuildResult BuildResult { get; set; }
    }
}
