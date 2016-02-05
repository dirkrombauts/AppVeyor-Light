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
    [NUnit.Framework.DescriptionAttribute("Colors Of Single Build States")]
    public partial class ColorsOfSingleBuildStatesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ColorsOfSingleBuildStates.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Colors Of Single Build States", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The colors that correspond to single build states")]
        [NUnit.Framework.TestCaseAttribute("Success", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Running", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Queued", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Failed", "Red", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Cancelled", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Unknown", "White", new string[0])]
        public virtual void TheColorsThatCorrespondToSingleBuildStates(string state, string color, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The colors that correspond to single build states", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given(string.Format("the build state is \'{0}\'", state), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.When("I turn on the light", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
    testRunner.Then(string.Format("the light is \'{0}\'", color), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion