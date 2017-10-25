using System;
using RestSharp;
using Tourspider.Ticketmaster.Sdk.Interfaces;

namespace Tourspider.Ticketmaster.Sdk
{
    public class RestRequest : RestSharp.RestRequest
    {
        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Tourspider.Ticketmaster.Sdk.RestRequest" /> class.
        /// </summary>
        public RestRequest()
        {
            RequestFormat = DataFormat.Json;
            Method = Method.GET;

            IntializeJsonSerializer();
        }

        /// <inheritdoc />
        /// <summary>
        /// Sets Method property to value of method
        /// </summary>
        /// <param name="method">Method to use for this request</param>
        public RestRequest(Method method) : this((string)null, method){}

        /// <inheritdoc />
        /// <summary>
        /// Sets Resource property
        /// </summary>
        /// <param name="resource">Resource to use for this request</param>
        public RestRequest(string resource) : this (resource, Method.GET){}

        /// <inheritdoc />
        /// <summary>
        /// Sets Resource and Method properties
        /// </summary>
        /// <param name="resource">Resource to use for this request</param><param name="method">Method to use for this request</param>
        public RestRequest(string resource, Method method) : base(resource, method)
        {
            IntializeJsonSerializer();
        }

        /// <summary>
        /// Sets Resource property
        /// 
        /// </summary>
        /// <param name="resource">Resource to use for this request</param>
        public RestRequest(Uri resource) : this (resource, Method.GET){}

        /// <summary>
        /// Sets Resource and Method properties
        /// 
        /// </summary>
        /// <param name="resource">Resource to use for this request</param><param name="method">Method to use for this request</param>
        public RestRequest(Uri resource, Method method) : base(resource, method)
        {
            IntializeJsonSerializer();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Intializes the serializer.
        /// </summary>
        protected void IntializeJsonSerializer()
        {
            JsonSerializer = new NewtonsoftJsonSerializer();
        }

        #endregion

        public void AddParameters(IRequestParameters requestParameters)
        {
            requestParameters.AddToRequest(this);
        }
    }
}
