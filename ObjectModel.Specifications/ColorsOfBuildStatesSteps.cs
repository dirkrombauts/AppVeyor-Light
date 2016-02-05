using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

using NFluent;

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AppVeyorLight.ObjectModel.Specifications
{
    [Binding]
    public class ColorsOfBuildStatesSteps
    {
        private readonly Converter converter;

        private BuildResult buildState;

        private readonly List<BuildResult> buildStates = new List<BuildResult>();

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

        [Given(@"I have these projects and build states")]
        public void GivenIHaveTheseProjectsAndBuildStates(Table table)
        {
            var projectsAndBuildStates = table.CreateSet<ProjectsAndBuildStates>();

            this.buildStates.AddRange(projectsAndBuildStates.Select(pabs => pabs.BuildState));
        }

        [When(@"I turn on the light")]
        public void WhenITurnOnTheLight()
        {
            if (this.buildStates.Any())
            {
                this.actualColor = this.converter.ConvertBuildResultsToColor(this.buildStates);
            }
            else
            {
                this.actualColor = this.converter.ConvertBuildResultToColor(this.buildState);
            }
        }

        [Then(@"the light is '(.*)'")]
        public void ThenTheLightIs(string color)
        {
            Color expectedColor = (Color)Enum.Parse(typeof(Color), color);

            Check.That(this.actualColor).IsEqualTo(expectedColor);
        }
    }

    public class ProjectsAndBuildStates
    {
        public BuildResult BuildState { get; set; }

        public string Project { get; set; }
    }
}
