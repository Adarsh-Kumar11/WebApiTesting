using System.Linq;
using TechTalk.SpecFlow;
using WebApiTesting.Feature_Objects;

namespace WebApiTesting.Feature_File
{
    [Binding]
    public class PostMethodSteps
    {
        PostMethod obj = new PostMethod();

        [When(@"user sends the data to the server as given")]
        public void WhenUserSendsTheDataToTheServerAsGiven(Table table)
        {
            string name = table.Rows.First(row=>row["key"]=="name")["value"];
            string salary = table.Rows.First(row => row["key"] =="salary")["value"];
            string age = table.Rows.First(row => row["key"] =="age")["value"];
            obj.PostRequest(name,salary,age);
        }

        [Then(@"user validate the status and data")]
        public void ThenUserValidateTheStatusAndData()
        {
            obj.VerifyPostRequest();
        }
    }
}
