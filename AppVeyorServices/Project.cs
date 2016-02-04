using System;
using System.Collections.Generic;

namespace AppVeyorLight.AppVeyorServices
{
    public class Project
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string AccountName { get; set; }

       public List<Build> Builds { get; set; }
   }
}