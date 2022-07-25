using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using RestSharp;
using RA;

namespace Nasa
{
    public class API
    {
        //static Uri baseUrl = new Uri("https://httpbin.org/");
        //RestClient client = new RestClient(baseUrl: baseUrl);

        //RestRequest request = new RestRequest("get", Method.Get) { Credentials = new NetworkCredential("testUser", "P455w0rd") };

        public async void apiCall()
        {
            string baseUrl = "https://api.nasa.gov/planetary/apod";
            string api_key = "6ZbHnqwSkpG3K2ObjcoPc85J7C3lWCp0aDAV8Xon";

            var client = new RestClient(baseUrl) {    
            };

            var request = new RestRequest("?api_key=" + api_key, Method.Get);
            var response = await client.GetAsync(request);

            var owiehrf = "oweihvcoiwe";

            Console.WriteLine(response);
            Console.ReadLine();

        }

        public object apiGet()
        {
      
            string api_key = "?api_key=6ZbHnqwSkpG3K2ObjcoPc85J7C3lWCp0aDAV8Xon";
      
            var printResponseBody = new RestAssured()
                 .Given()
                 .Name("Nasa Test")
                 .When()
                 .Get("https://api.nasa.gov/planetary/apod" + api_key)
                 .Then()
                 .Debug();

            var picOfTheDayTitle = new RestAssured()
                 .Given()
                 .Name("Nasa Test")
                 .When()
                 .Get("https://api.nasa.gov/planetary/apod" + api_key)
                 .Then()
                 .Retrieve(x => x.title);

            var picOfTheDayUrl = new RestAssured()
                .Given()
                .Name("Nasa Test")
                .When()
                .Get("https://api.nasa.gov/planetary/apod" + api_key)
                .Then()
                .Retrieve(x => x.url);

            Console.WriteLine("The pick of the day is :  " + picOfTheDayTitle);
            Console.WriteLine("The pick of the day url is :  " + picOfTheDayUrl);

            return picOfTheDayUrl;
        }

        

    }
}
