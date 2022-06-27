using TechTalk.SpecFlow;
using WebApiTesting.Feature_Objects;

namespace WebApiTesting.Feature_File
{
    [Binding]
    public class PutMethodSteps
    {
        PutMethod obj = new PutMethod();

        [When(@"user sends the data to update")]
        public void WhenUserSendsTheDataToUpdate()
        {
            obj.PutRequest();
        }

        [Then(@"user validate if the data updated")]
        public void ThenUserValidateIfTheDataUpdated()
        {
            obj.VerifyPutRequest();
        }
    }
}
