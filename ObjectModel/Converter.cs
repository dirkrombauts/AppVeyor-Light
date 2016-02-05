using System;

namespace AppVeyorLight.ObjectModel
{
    public class Converter
    {
        public Color ConvertBuildResultToColor(BuildResult buildResult)
        {
            switch (buildResult)
            {
                default:
                    {
                        return Color.Green;
                    }
            }
        }
    }
}