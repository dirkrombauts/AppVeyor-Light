﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AppVeyorLight.ObjectModel.Specifications
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Colors Of Multiple Build States")]
    public partial class ColorsOfMultipleBuildStatesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ColorsOfMultipleBuildStates.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Colors Of Multiple Build States", @"When multiple builds are present, either on a single project or on multiple projects,
we need to calculate one single color that will be shown on the light.

We consider the builds in order of (descending) precedence to determine the color:

1. Running
2. Queued
3. Failed
4. Cancelled
5. Unknown
6. Success", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When there is a build in progress, the color is yellow")]
        public virtual void WhenThereIsABuildInProgressTheColorIsYellow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When there is a build in progress, the color is yellow", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "Build State"});
            table1.AddRow(new string[] {
                        "Project A",
                        "Success"});
            table1.AddRow(new string[] {
                        "Project B",
                        "Queued"});
            table1.AddRow(new string[] {
                        "Project C",
                        "Failed"});
            table1.AddRow(new string[] {
                        "Project D",
                        "Running"});
#line 17
testRunner.Given("I have these projects and build states", ((string)(null)), table1, "Given ");
#line 23
testRunner.When("I turn on the light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.Then("the light is \'Yellow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When there is no build in progress but there is one scheduled, the color is blue")]
        public virtual void WhenThereIsNoBuildInProgressButThereIsOneScheduledTheColorIsBlue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When there is no build in progress but there is one scheduled, the color is blue", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "Build State"});
            table2.AddRow(new string[] {
                        "Project A",
                        "Success"});
            table2.AddRow(new string[] {
                        "Project B",
                        "Queued"});
            table2.AddRow(new string[] {
                        "Project C",
                        "Failed"});
#line 30
testRunner.Given("I have these projects and build states", ((string)(null)), table2, "Given ");
#line 35
testRunner.When("I turn on the light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.Then("the light is \'Blue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When there are no build in progressed or scheduled, but there is a failed build, " +
            "the color is red")]
        public virtual void WhenThereAreNoBuildInProgressedOrScheduledButThereIsAFailedBuildTheColorIsRed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When there are no build in progressed or scheduled, but there is a failed build, " +
                    "the color is red", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "Build State"});
            table3.AddRow(new string[] {
                        "Project A",
                        "Success"});
            table3.AddRow(new string[] {
                        "Project B",
                        "Unknown"});
            table3.AddRow(new string[] {
                        "Project C",
                        "Failed"});
            table3.AddRow(new string[] {
                        "Project D",
                        "Cancelled"});
#line 44
testRunner.Given("I have these projects and build states", ((string)(null)), table3, "Given ");
#line 50
testRunner.When("I turn on the light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("the light is \'Red\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A cancelled build is more important than an unknown or a successful one")]
        public virtual void ACancelledBuildIsMoreImportantThanAnUnknownOrASuccessfulOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A cancelled build is more important than an unknown or a successful one", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "Build State"});
            table4.AddRow(new string[] {
                        "Project A",
                        "Success"});
            table4.AddRow(new string[] {
                        "Project B",
                        "Unknown"});
            table4.AddRow(new string[] {
                        "Project D",
                        "Cancelled"});
#line 56
testRunner.Given("I have these projects and build states", ((string)(null)), table4, "Given ");
#line 61
testRunner.When("I turn on the light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
testRunner.Then("the light is \'White\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An unknown build is more important than a successful one")]
        public virtual void AnUnknownBuildIsMoreImportantThanASuccessfulOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An unknown build is more important than a successful one", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "Build State"});
            table5.AddRow(new string[] {
                        "Project A",
                        "Success"});
            table5.AddRow(new string[] {
                        "Project B",
                        "Unknown"});
#line 67
testRunner.Given("I have these projects and build states", ((string)(null)), table5, "Given ");
#line 71
testRunner.When("I turn on the light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
testRunner.Then("the light is \'White\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("We have green light only if all projects have a successful build")]
        public virtual void WeHaveGreenLightOnlyIfAllProjectsHaveASuccessfulBuild()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("We have green light only if all projects have a successful build", ((string[])(null)));
#line 75
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Project",
                        "Build State"});
            table6.AddRow(new string[] {
                        "Project A",
                        "Success"});
            table6.AddRow(new string[] {
                        "Project B",
                        "Success"});
            table6.AddRow(new string[] {
                        "Project C",
                        "Success"});
            table6.AddRow(new string[] {
                        "Project D",
                        "Success"});
#line 77
testRunner.Given("I have these projects and build states", ((string)(null)), table6, "Given ");
#line 83
testRunner.When("I turn on the light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
testRunner.Then("the light is \'Green\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
