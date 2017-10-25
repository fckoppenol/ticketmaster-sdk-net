using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Tourspider.Ticketmaster.Sdk.Interfaces;
using Tourspider.Ticketmaster.Sdk.Models;

namespace Tourspider.Ticketmaster.Sdk
{
    public class DiscoveryClient
    {
        private readonly RestClient _restClient;

        public DiscoveryClient(string apiKey, string baseUrl = "https://app.Ticketmaster.eu/mfxapi/v1")
        {
            if (string.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException(apiKey);

            if (string.IsNullOrEmpty(baseUrl))
                throw new ArgumentNullException(baseUrl);

            _restClient = new RestClient(new Uri(baseUrl)) { Authenticator = new TicketmasterAuthenticator(apiKey) };
            _restClient.AddDefaultHeader("Accept", "application/json");
        }

        public Response<T2> Query<T1, T2>(IRequestParameters requestParameters)
            where T1 : Request, new() where T2 : new()
        {
            var method = Method<T1>(requestParameters, out var restRequest);

            var result = new Response<T2>();

            var response = method.Execute<T2>(_restClient, restRequest);
            if (response.StatusCode == HttpStatusCode.BadRequest && !string.IsNullOrEmpty(response.Content))
            {
                result.Status = JsonConvert.DeserializeObject<Status>(response.Content);
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result.Result = JsonConvert.DeserializeObject<T2>(response.Content);
            }

            return result;
        }

        public async Task<Response<T2>> QueryAsync<T1, T2>(IRequestParameters requestParameters)
            where T1 : Request, new() where T2 : new()
        {
            var method = Method<T1>(requestParameters, out var restRequest);

            var result = new Response<T2>();

            var response = await method.ExecuteAsync<T2>(_restClient, restRequest);
            if (response.StatusCode == HttpStatusCode.BadRequest && !string.IsNullOrEmpty(response.Content))
            {
                result.Status = JsonConvert.DeserializeObject<Status>(response.Content);
            }
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result.Result = JsonConvert.DeserializeObject<T2>(response.Content); 
            }

            return result;
        }

        private static T1 Method<T1>(IRequestParameters requestParameters, out RestRequest restRequest)
           where T1 : Request, new()
        {
            var method = new T1();

            restRequest = new RestRequest(method.Resource);
            requestParameters.AddToRequest(restRequest);
            return method;
        }
    }
}
