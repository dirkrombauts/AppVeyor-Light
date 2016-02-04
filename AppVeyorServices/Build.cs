using System;
using System.Collections.Generic;

namespace AppVeyorLight.AppVeyorServices
{
    public class Build
    {
        public List<string> Status { get; set; }

        public string Started { get; set; }

        public string Finished { get; set; }

        public string Created { get; set; }

        public string Updated { get; set; }
    }
}