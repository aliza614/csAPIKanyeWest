using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace csAPIKanyeWest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://medium.com/@vicbergquist/18-fun-apis-for-your-next-project-8008841c7be9
            //has fun apis to check out
            //REST Flashcards: https://quizlet.com/156614639/restful-web-services-flash-cards/
            for (int i = 0; i < 5; i++)

            {
                var client = new HttpClient();
                var kanyeURL = "https://api.kanye.rest/";
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse)
                    .GetValue("quote").ToString();
                Console.WriteLine($"Kanye West says: {kanyeQuote}");

                var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var ronSwansonResponse = client.GetStringAsync(ronSwansonURL).Result;
                var ronSwansonQuote = ronSwansonResponse.ToString().Replace("[\"", "").Replace("\"]", "");
                Console.WriteLine($"Ron Swanson says: {ronSwansonQuote}");
            }
        }
    }
}
