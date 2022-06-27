using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Net;

namespace WebApiTesting.Feature_Objects
{
    class PostMethod:FileReadWrite
    {
        RestResponse response;

        public void PostRequest(string name,string salary,string age)
        {
            RestClient client = new RestClient("http://dummy.restapiexample.com/api/v1");
            RestRequest restRequest = new RestRequest("/create", Method.Post);
            int Salary = Convert.ToInt32(salary);
            int Age = Convert.ToInt32(age);
            var body ="{\"name\":\""+name+"\",\"salary\":"+Salary+",\"age\":"+Age+"}";
            restRequest.AddBody(body);
            response = client.Execute(restRequest);
        }

        public void VerifyPostRequest()
        {
            dynamic value = JsonConvert.DeserializeObject(response.Content);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            id = value.data.id.ToString();
            CreateFile();
        }
    }
}
