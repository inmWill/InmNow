using System.Runtime.Remoting.Channels;
using InmNow.Domain.SurveyBuilder.Models;
using InmNow.Service.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace InmNow.Tests.SurveyBuilder.Features.AddClient
{
    [Binding]
    public class Steps
    {
        private Client _newClient;
        private ClientService _clientService;

        [Given(@"a user has entered information about a client")]
        public void GivenAUserHasEnteredInformationAboutAClient()
        {
           _newClient = new Client();
        }

        [Given(@"she has provided a name and a email as required")]
        public void GivenSheHasProvidedANameAndAEmailAsRequired()
        {
            _newClient.Name = "Test Client";
            _newClient.Email = "test@client.com";
        }

        [When(@"she completes entering more information")]
        public void WhenSheCompletesEnteringMoreInformation()
        {
            
        }

        [Then(@"that client should be stored in the system")]
        public void ThenThatClientShouldBeStoredInTheSystem()
        {
            _clientService = new ClientService();
            _newClient = _clientService.CreateClient(_newClient);
            Assert.IsNotNull(_newClient.ClientId>0);
        }

        [Given(@"she has not provided the  name and email")]
        public void GivenSheHasNotProvidedTheNameAndEmail()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"that user will be notified about the missing data")]
        public void ThenThatUserWillBeNotifiedAboutTheMissingData()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the client will not be stored into the system")]
        public void ThenTheClientWillNotBeStoredIntoTheSystem()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
