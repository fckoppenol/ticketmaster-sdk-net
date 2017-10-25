using System.Threading.Tasks;
using RestSharp;

namespace Tourspider.Ticketmaster.Sdk
{
    public abstract class Request
    {
        public abstract string Resource
        {
            get;
        }

        protected internal Task<IRestResponse<T>> ExecuteAsync<T>(RestClient restClient, RestRequest restRequest) where T : new()
        {
            return restClient.ExecuteTaskAsync<T>(restRequest);
        }

        protected internal IRestResponse<T> Execute<T>(RestClient restClient, RestRequest restRequest) where T : new()
        {
            return restClient.Execute<T>(restRequest);
        }
    }
}
