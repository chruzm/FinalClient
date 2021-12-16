using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public class RestClient : ITest
    {
        private string uri = "http://localhost:8080/";
        
        //initiate Rest Klient
        public RestClient()
        {
            client = new HttpClient();
        }
        HttpClient client = new HttpClient();
        /*
         * get method virker nu, connected til server.
         * kun en test, da test object er hardcoded i tier2
         */
            /*
             * get menu liste virker nu. liste query fra database til tier3, soap call fra tier3 til 2,
             * og rest call fra tier2 til klient
             */ 
        public async Task<MenuObject> GetMenuAsync(int itemnumber)
        {
            using HttpClient client = new HttpClient();
            
            HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/menu/"+itemnumber.ToString());
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception(@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            
            string result = await responseMessage.Content.ReadAsStringAsync();
            MenuObject item = JsonSerializer.Deserialize<MenuObject>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            Console.WriteLine(item.food);
            return item ;
        }

        public async Task<OrderObject> SendOrderAsync(OrderObject o)
        {
            HttpClient client = new HttpClient();
            string testSerialized = JsonSerializer.Serialize(o);
            
            StringContent content = new StringContent(
                testSerialized,
                Encoding.UTF8,
                "application/json"
            );
            
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/order/"+o.ordernumber, content);
            Console.WriteLine("Order: "+o.ordernumber+" sent to server");

            return o;
        }

        public async Task<ReviewObject> SendReviewAsync(ReviewObject r)
        {
            HttpClient client = new HttpClient();
            string testSerialized = JsonSerializer.Serialize(r);
            
            StringContent content = new StringContent(
                testSerialized,
                Encoding.UTF8,
                "application/json"
            );
            
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/r/"+r.id, content);
            Console.WriteLine("review #"+r.id+" indsendt");

            return r;
        }
    }
}