using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeyorLight.ObjectModel
{
    public enum BuildResult
    {
        Running,
        Success,
        Queued,
        Failed,
        Cancelled,
        Unknown,
    }
}
