using TechTalk.SpecFlow;
using WebApiTesting.Feature_Objects;

namespace WebApiTesting.Feature_File
{
    [Binding]
    public class DeleteMethodSteps
    {
        DeleteMethod obj = new DeleteMethod();

        [When(@"user send request to the server")]
        public void WhenUserSendRequestToTheServer()
        {
            obj.DeleteRequest();
        }

        [Then(@"user validate the response")]
        public void ThenUserValidateTheResponse()
        {
            obj.VerifyDeleteRequest();
        }
    }
}
