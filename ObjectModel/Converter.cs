using System;
using System.Collections.Generic;
using System.Linq;

namespace AppVeyorLight.ObjectModel
{
    public class Converter
    {
        public Color ConvertBuildResultToColor(BuildResult buildResult)
        {
            switch (buildResult)
            {
                case BuildResult.Running:
                    {
                        return Color.Yellow;
                    }

                case BuildResult.Success:
                    {
                        return Color.Green;
                    }

                case BuildResult.Queued:
                    {
                        return Color.Blue;
                    }

                case BuildResult.Failed:
                    {
                        return Color.Red;
                    }

                case BuildResult.Cancelled:
                case BuildResult.Unknown:
                default:
                    {
                        return Color.White;
                    }
            }
        }

        public Color ConvertBuildResultsToColor(IList<BuildResult> buildResults)
        {
            var color = buildResults.Select(this.ConvertBuildResultToColor)
                .Select(c => new { Color = c, Value = (int)c })
                .OrderBy(cv => cv.Value)
                .Select(cv => cv.Color)
                .FirstOrDefault();

            return color;
        }
    }
}