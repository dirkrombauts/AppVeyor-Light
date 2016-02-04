using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AppVeyorLight.BusylightServices
{
    public class BusylightColor
    {
        public int RedComponent { get; set; }

        public int GreenComponent { get; set; }

        public int BlueComponent { get; set; }

        public static BusylightColor Red { get; } = new BusylightColor { RedComponent = 100, GreenComponent = 0, BlueComponent = 0 };
        public static BusylightColor Green { get; } = new BusylightColor { RedComponent = 0, GreenComponent = 100, BlueComponent = 0 };
        public static BusylightColor Blue { get; } = new BusylightColor { RedComponent = 0, GreenComponent = 0, BlueComponent = 100};
        public static BusylightColor White { get; } = new BusylightColor { RedComponent = 100, GreenComponent = 100, BlueComponent = 100 };
        public static BusylightColor Yellow { get; } = new BusylightColor { RedComponent = 100, GreenComponent = 100, BlueComponent = 0 };
        public static BusylightColor Off { get; } = new BusylightColor { RedComponent = 0, GreenComponent = 0, BlueComponent = 0 };
    }
}
