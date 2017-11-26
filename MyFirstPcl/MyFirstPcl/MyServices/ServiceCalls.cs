using MyFirstPcl.Models;
using MyFirstPcl.Views;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPcl.MyServices
{
    public class ServiceCalls
    {
        public static RestService restService = new RestService();
        public static string MyServiceMethod()
        {
            JObject jobj = new JObject();
            jobj.Add("picker_token", "57d2be4ca4e5f73caa4e99b29efd69c7");
            jobj.Add("invoice_id", "62877");
            jobj.Add("user_id", "1234");
            string response = restService.PostRequest("http://portal.ebutor.com/cpmanager/getorderdetailbyinvoice", "data=" + jobj);
            return response;
        }

        public static string MyServiceMethod1()
        {
            JObject jobj = new JObject();
            jobj.Add("picker_token", "57d2be4ca4e5f73caa4e99b29efd69c7");
            jobj.Add("invoice_id", "62877");
            jobj.Add("user_id", "1234");
            string response = restService.PostRequest("http://portal.ebutor.com/cpmanager/getorderdetailbyinvoice", "data=" + jobj);
            return response;
        }
    }

    public class MovieService
    {
        public static readonly int MinSearchLength = 5;

        private const string Url = "http://netflixroulette.net/api/api.php";
        private HttpClient _client = new HttpClient();

        //public async Task<IEnumerable<movies>> FindMoviesByActor(string actor)
        //{
        //    //if (actor.Length < MinSearchLength)
        //    //    return Enumerable.Empty<MovieModel>();

        //    //var response = await _client.GetAsync($"{Url}?actor={actor}");

        //    //if (response.StatusCode == HttpStatusCode.NotFound)
        //    //    return Enumerable.Empty<MovieModel>();

        //    //var content = await response.Content.ReadAsStringAsync();
        //    //return JsonConvert.DeserializeObject<List<MovieModel>>(content);
        //}

        //public async Task<MovieModel> GetMovie(string title)
        //{
        //    //var response = await _client.GetAsync($"{Url}?title={title}");

        //    //if (response.StatusCode == HttpStatusCode.NotFound)
        //    //    return null;

        //    //var content = await response.Content.ReadAsStringAsync();
        //    //return JsonConvert.DeserializeObject<MovieModel>(content);
        //}
    }
}
