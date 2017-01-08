using BoDi;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestAutomation.QAWorks.Web.Pages.PageObjects;

namespace TestAutomation.QAWorks.Web.Steps.StepBindings
{
    [Binding]
    public class ContactSteps : TechTalk.SpecFlow.Steps
    {
        private readonly IObjectContainer _objectContainer;

        public ContactSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [When(@"I contact QAWorks with the following information")]
        public void WhenIContactQAWorksWithTheFollowingInformation(Table table)
        {
            var homePage = _objectContainer.Resolve<HomePage>();
            var contactPage = homePage.NavigatetoContactPage();
            dynamic contactDetails = table.CreateDynamicInstance();
            var postSubmissionPage = contactPage.SendAMessage(contactDetails.Name, contactDetails.Email, contactDetails.Messsage);
            _objectContainer.RegisterInstanceAs(postSubmissionPage);
        }

        [When(@"I contact QAWorks")]
        public void WhenIContactQAWorks()
        {
            string[] row = { "j.Bloggs", "j.Bloggs@qaworks.com", "Messsage to send" };
            Table table = CreateTableWithHeaders();
            table.AddRow(row);
            When("I contact QAWorks with the following information", table);
        }

        [When(@"I contact QAWorks using multiple email address")]
        public void WhenIContactQAWorksUsingMultipleEmailAddress()
        {
            string[] row = { "j.Bloggs", "j.Bloggs@qaworks.com,groupemail@qaworks.com", "Messsage to send" };
            Table table = CreateTableWithHeaders();
            table.AddRow(row);
            When("I contact QAWorks with the following information", table);
        }


        [When(@"I accidentally leave (Name|Email|Message) field empty")]
        public void WhenIAccidentallyLeaveFieldEmpty(string field)
        {
            string[] row = { "j.Bloggs", "j.Bloggs@qaworks.com", "Messsage to send" };
            Table table = CreateTableWithHeaders();
            table.AddRow(row);

            switch (field)
            {
                case "Name":
                    row[0] = string.Empty;
                    break;
                case "Email":
                    row[1] = string.Empty;
                    break;
                case "Message":
                    row[2] = string.Empty;
                    break;
                default:
                    break;
            }
            When("I contact QAWorks with the following information", table);
        }
        
        [When(@"I accidentally enter an invalid email address")]
        public void WhenIAccidentallyEnterAnInvalidEmailAddress()
        {
            var homePage = _objectContainer.Resolve<HomePage>();
            var contactPage = homePage.NavigatetoContactPage();
            contactPage.FillContactForm("j.Bloggs", "j.Bloggs", "Please Contact Me");
        }

        private Table CreateTableWithHeaders()
        {
            return new Table(new string[] { "Name", "Email", "Messsage" });
        }
    }
}
