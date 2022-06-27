using TechTalk.SpecFlow;
using WebApiTesting.Feature_Objects;

namespace WebApiTesting.Feature_File
{
    [Binding]
    public class GetMethodSteps  
    {
        GetMethod obj = new GetMethod();

        [When(@"user request the data of all employees")]
        public void WhenUserRequestTheDataOfAllEmployees()
        {
            obj.GetAllEmployees();
        }
        
        
        [Then(@"user validate the data of all employees")]
        public void ThenUserValidateTheDataOfAllEmployees()
        {
            obj.VerifyAllEmployeeRequest();
        }

        [When(@"user request the data of specific employee")]
        public void WhenUserRequestTheDataOfSpecificEmployee()
        {
            obj.GetSpecificEmployee();
        }

        [Then(@"user gets the data of single employee")]
        public void ThenUserGetsTheDataOfSingleEmployee()
        {
            obj.VerifySpecificEmployeeRequest();
        }

    }
}
