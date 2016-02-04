using System;

namespace AppVeyorLight.BusylightServices
{
    public class Busylight : IBusylight
    {
        private global::Busylight.SDK device;

        public Busylight()
        {
            this.device = new global::Busylight.SDK();
        }

        public void Light(BusylightColor color)
        {
            this.device.Light(new global::Busylight.BusylightColor { RedRgbValue = color.RedComponent, GreenRgbValue = color.GreenComponent, BlueRgbValue = color.BlueComponent });
        }
    }
}
