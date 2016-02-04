using System;

namespace AppVeyorLight.BusylightServices
{
    internal interface IBusylight
    {
        void Light(BusylightColor color);
    }
}