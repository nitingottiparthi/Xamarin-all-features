using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstPcl.MyServices
{
    public class RestService
    {
        private static ManualResetEvent allDone = new ManualResetEvent(false);
        private static string responseString;
        private static string inputDataString;
        public string PostRequest(string url, string data)
        {

            try
            {
                responseString = null;
                // Create a new HttpWebRequest object.
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.ContentType = "application/x-www-form-urlencoded";



                // Set the Method property to 'POST' to post data to the URI.
                request.Method = "POST";

                inputDataString = data;
                // start the asynchronous operation 
                request.BeginGetRequestStream(new AsyncCallback(GetRequestStreamCallback), request);

                // Keep the main thread from continuing while the asynchronous
                // operation completes. A real world application
                // could do something useful such as updating its user interface. 
                allDone.WaitOne(100000);
                allDone.Reset();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            return responseString;
        }

        private void GetRequestStreamCallback(IAsyncResult asynchronousResult)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)asynchronousResult.AsyncState;

                // End the operation
                Stream postStream = request.EndGetRequestStream(asynchronousResult);

                // Convert the string into a byte array.
                byte[] byteArray = Encoding.UTF8.GetBytes(inputDataString);

                // Write to the request stream.
                postStream.Write(byteArray, 0, inputDataString.Length);
                postStream.Dispose();

                // Start the asynchronous operation to get the response
                request.BeginGetResponse(new AsyncCallback(GetResponseCallback), request);
            }
            catch
            { return; }
        }

        private void GetResponseCallback(IAsyncResult asynchronousResult)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)asynchronousResult.AsyncState;

                // End the operation
                HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(asynchronousResult);
                Stream streamResponse = response.GetResponseStream();
                StreamReader streamRead = new StreamReader(streamResponse);
                responseString = streamRead.ReadToEnd();
                //Console.WriteLine(responseString);
                // Close the stream object
                streamResponse.Dispose();
                streamRead.Dispose();

                // Release the HttpWebResponse
                response.Dispose();
                allDone.Set();
            }
            catch
            { return; }
        }

        private HttpClient CreateHttpClient()

        {

            var httpClient = new HttpClient();

            httpClient.Timeout = new TimeSpan(0, 0, 20);

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            return httpClient;

        }

        private async Task HandleResponse(HttpResponseMessage response)

        {

            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (response.StatusCode == HttpStatusCode.Forbidden || response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //throw new ServiceAuthenticationException(content);
                }
                throw new HttpRequestException(content);
            }

        }

        private readonly JsonSerializerSettings _serializerSettings;
        public async Task<TResult> PostAsync<TRequest, TResult>(string url, TRequest data)
        {
            try
            {
                UriBuilder builder = new UriBuilder(url);
                string uri = builder.ToString();
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = new TimeSpan(0, 0, 20);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string serialized = await Task.Run(() => JsonConvert.SerializeObject(data, _serializerSettings));
                var content = new FormUrlEncodedContent(new[]
       {
                        new System.Collections.Generic.KeyValuePair<string, string>("data",serialized)
                    });
                HttpResponseMessage response = await httpClient.PostAsync(uri, content);
                if (response.IsSuccessStatusCode)
                {
                    await HandleResponse(response);

                    string responseData = await response.Content.ReadAsStringAsync();
                    JObject jobj = JObject.Parse(responseData);
                    return await Task.Run(() => JsonConvert.DeserializeObject<TResult>(jobj.ToString(), _serializerSettings));
                }
                else
                {
                    throw new WebException();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}



//public async Task<TResult> PostAsync<TRequest, TResult>(string url, TRequest data)
//{
//    try
//    {
//        UriBuilder builder = new UriBuilder(url);
//        string uri = builder.ToString();
//        HttpClient httpClient = CreateHttpClient();
//        string serialized = await Task.Run(() => JsonConvert.SerializeObject(data, _serializerSettings));

//        var content = new FormUrlEncodedContent(new[]
//       {
//                new System.Collections.Generic.KeyValuePair<string, string>("data",serialized)
//            });
//        HttpResponseMessage response = await httpClient.PostAsync(uri, content);
//        if (response.IsSuccessStatusCode)
//        {
//            await HandleResponse(response);

//            string responseData = await response.Content.ReadAsStringAsync();
//            JObject jobj = JObject.Parse(responseData);
//            return await Task.Run(() => JsonConvert.DeserializeObject<TResult>(jobj.ToString(), _serializerSettings));
//        }
//        else
//        {
//            throw new WebException();
//        }
//    }
//    catch (Exception ex)
//    {
//        throw;
//    }

