using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTesting.Feature_Objects
{
    class PutMethod:FileReadWrite
    {
        RestResponse response;
        public void PutRequest()
        {
            ReadFile();
            RestClient client = new RestClient("http://dummy.restapiexample.com/api/v1");
            RestRequest restRequest = new RestRequest("/update/" + id, Method.Put);
            restRequest.AddBody("{\"name\":\"Amit Yadav\",\"salary\":\"20000\"}");
            response = client.Execute(restRequest);
        }

        public void VerifyPutRequest()
        {
            dynamic value = JsonConvert.DeserializeObject(response.Content);
            Assert.AreEqual(value.data.name.ToString(), "Amit Yadav");
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
