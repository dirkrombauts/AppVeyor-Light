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
            if (buildResults.Any(br => br == BuildResult.Running))
            {
                return Color.Yellow;
            }

            return Color.White;
        }
    }
}