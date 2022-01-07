using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Text;

namespace lib
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }

        public async string UseJsonNetForSomeReason<T>(T input) 
        {
            var str = JsonConvert.SerializeObject(input);

            var a = JsonConvert.DeserializeObject(str) ;

            var client = new HttpClient();
            client.BaseAddress = "";

            var request = new HttpRequestMessage(new HttpMethod("POST"), uri);
            request.Content = new StringContent(content: string, encoding: Encoding.UTF8, mediaType: "application/json");

            using(HttpResponseMessage response = await client.SendAsync(rquest))
            {
                string str1 = await response.Content.ReadAsStringAsync();
            }

            return str;
        }

        public void Testing()
        {
            var data = JsonConvert.DeserializeObject( System.IO.File.ReadAllText("path")
            using(var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var str = client.UploadString("addr", "data");

            }
        }

        public int Add(int i, int j)
        {
            return i + j;
        }
    }
}
