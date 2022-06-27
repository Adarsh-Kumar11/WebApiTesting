using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace WebApiTesting.Feature_Objects
{
    public class DeleteMethod:FileReadWrite
    {
        static RestResponse response;

        public void DeleteRequest()
        {
            ReadFile();
            RestClient client = new RestClient("http://dummy.restapiexample.com/api/v1");
            RestRequest restRequest = new RestRequest("/delete/" + id, Method.Delete);
            response = client.Execute(restRequest);
        }

        public void VerifyDeleteRequest()
        {
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
