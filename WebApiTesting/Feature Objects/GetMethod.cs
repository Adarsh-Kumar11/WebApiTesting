using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;


namespace WebApiTesting.Feature_Objects
{
    class GetMethod:FileReadWrite
    {
        RestResponse response;
        public void GetSpecificEmployee()
        {
            ReadFile();
            RestClient client = new RestClient("http://dummy.restapiexample.com/api/v1");
            RestRequest restRequest = new RestRequest("/employee/"+id, Method.Get);
            response = client.Execute(restRequest);
        }

        public void VerifySpecificEmployeeRequest()
        {
            dynamic value = JsonConvert.DeserializeObject(response.Content);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            Assert.AreEqual(value.message.ToString(), "Successfully! Record has been fetched.");
        }

        public void GetAllEmployees()
        {
            RestClient client = new RestClient("http://dummy.restapiexample.com/api/v1");
            RestRequest restRequest = new RestRequest("/employees", Method.Get);
            response = client.Execute(restRequest);
        }
        public void VerifyAllEmployeeRequest()
        {
            dynamic value = JsonConvert.DeserializeObject(response.Content);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            Assert.AreEqual(value.message.ToString(), "Successfully! All records has been fetched.");
        }
    }
}
