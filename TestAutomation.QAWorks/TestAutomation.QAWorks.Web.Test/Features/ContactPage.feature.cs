﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestAutomation.QAWorks.Web.Test.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ContactPage")]
    [NUnit.Framework.CategoryAttribute("Chrome")]
    public partial class ContactPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ContactPage.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ContactPage", "\tIn order to find out more about QAWorks exiting services\r\n\tAs a user\r\n\tI want a " +
                    "working contact us page", ProgrammingLanguage.CSharp, new string[] {
                        "Chrome"});
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
        [NUnit.Framework.DescriptionAttribute("Thank You Message is displayed after Successful Submission")]
        [NUnit.Framework.CategoryAttribute("003")]
        public virtual void ThankYouMessageIsDisplayedAfterSuccessfulSubmission()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Thank You Message is displayed after Successful Submission", new string[] {
                        "003"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Name",
                        "j.Bloggs"});
            table1.AddRow(new string[] {
                        "Email",
                        "j.Bloggs@qaworks.com"});
            table1.AddRow(new string[] {
                        "Messsage",
                        "please contact me"});
#line 10
testRunner.When("I contact QAWorks with the following information", ((string)(null)), table1, "When ");
#line 15
testRunner.Then("Thank you message should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Valid Submission Using Foreign Languages")]
        [NUnit.Framework.CategoryAttribute("004")]
        [NUnit.Framework.TestCaseAttribute("Albert Jêan", "Albert.Jêan@qaworks.com", "Myself Jêan, Souhaite en savoir plus sur les services QAWorks", new string[0])]
        [NUnit.Framework.TestCaseAttribute("伟 张", "伟.张@QQ.com", "请联系我", new string[0])]
        public virtual void ValidSubmissionUsingForeignLanguages(string name, string email, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "004"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Submission Using Foreign Languages", @__tags);
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Name",
                        string.Format("{0}", name)});
            table2.AddRow(new string[] {
                        "Email",
                        string.Format("{0}", email)});
            table2.AddRow(new string[] {
                        "Messsage",
                        string.Format("{0}", message)});
#line 20
testRunner.When("I contact QAWorks with the following information", ((string)(null)), table2, "When ");
#line 25
testRunner.Then("Information should be Submitted Successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can Not Submit without Name")]
        public virtual void CanNotSubmitWithoutName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can Not Submit without Name", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
testRunner.When("I accidentally leave Name field empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
testRunner.Then("I should see following error Your name is required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can Not Submit without Email")]
        public virtual void CanNotSubmitWithoutEmail()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can Not Submit without Email", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
testRunner.When("I accidentally leave Email field empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
testRunner.Then("I should see following error An Email address is required", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can Not Submit without Message")]
        public virtual void CanNotSubmitWithoutMessage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can Not Submit without Message", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
testRunner.When("I accidentally leave Message field empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.Then("I should see following error Please type your message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Warning message is displayed when I enter an Invalid Email address")]
        public virtual void WarningMessageIsDisplayedWhenIEnterAnInvalidEmailAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Warning message is displayed when I enter an Invalid Email address", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
testRunner.When("I accidentally enter an invalid email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("I should see following error Invalid Email Address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can Not Submit with Invalid Email Address")]
        public virtual void CanNotSubmitWithInvalidEmailAddress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can Not Submit with Invalid Email Address", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 53
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Name",
                        "j.Bloggs"});
            table3.AddRow(new string[] {
                        "Email",
                        "j.Bloggs"});
            table3.AddRow(new string[] {
                        "Messsage",
                        "please contact me"});
#line 54
testRunner.When("I contact QAWorks with the following information", ((string)(null)), table3, "When ");
#line 59
testRunner.Then("I should see following error Invalid Email Address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("All Fields should be cleared after submission")]
        public virtual void AllFieldsShouldBeClearedAfterSubmission()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All Fields should be cleared after submission", ((string[])(null)));
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
testRunner.Given("I\'m on the QAWorks website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
testRunner.When("I contact QAWorks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
testRunner.Then("Information should be Submitted Successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
testRunner.And("All fields should be cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
