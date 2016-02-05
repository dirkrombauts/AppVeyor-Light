using System;
using System.ComponentModel.Design;

using NFluent;

using TechTalk.SpecFlow;

namespace AppVeyorLight.ObjectModel.Specifications
{
    [Binding]
    public class ColorsOfBuildStatesSteps
    {
        private readonly Converter converter;

        private BuildResult buildState;

        private Color actualColor;

        public ColorsOfBuildStatesSteps(Converter converter)
        {
            this.converter = converter;
        }

        [Given(@"the build state is '(.*)'")]
        public void GivenTheBuildStateIs(string buildState)
        {
            this.buildState = (BuildResult)Enum.Parse(typeof(BuildResult), buildState);
        }

        [When(@"I turn on the light")]
        public void WhenITurnOnTheLight()
        {
            this.actualColor = this.converter.ConvertBuildResultToColor(this.buildState);
        }

        [Then(@"the light is '(.*)'")]
        public void ThenTheLightIs(string color)
        {
            Color expectedColor = (Color)Enum.Parse(typeof(Color), color);

            Check.That(this.actualColor).IsEqualTo(expectedColor);
        }
    }
}
