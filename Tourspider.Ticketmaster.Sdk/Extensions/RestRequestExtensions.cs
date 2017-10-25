using System;
using System.Collections.Generic;
using System.Globalization;


namespace Tourspider.Ticketmaster.Sdk.Extensions
{
    public static class RestRequestExtensions
    {
        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, List<string> list)
        {
            if (list != null && list.Count > 0)
            {
                restRequest.AddQueryParameter(name, string.Join(",", list));
            }
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, List<int> list)
        {
            if (list != null && list.Count > 0)
            {
                restRequest.AddQueryParameter(name, string.Join(",", list));
            }
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                restRequest.AddQueryParameter(name, item);
            }
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, bool? item)
        {
            if (item != null)
            {
                restRequest.AddQueryParameterIfNotEmpty(name, (bool)item);
            }
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, bool item)
        {
            restRequest.AddQueryParameter(name, item.ToString().ToLowerInvariant());
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, double? item)
        {
            if (item != null)
            {
                restRequest.AddQueryParameter(name, ((double)item).ToString(CultureInfo.CreateSpecificCulture("en-US")));
            }
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, int? item)
        {
            if (item != null)
            {
                restRequest.AddQueryParameterIfNotEmpty(name, (int)item);
            }
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, int item)
        {
            restRequest.AddQueryParameter(name, item.ToString(CultureInfo.CreateSpecificCulture("en-US")));
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, DateTime? item, bool includeMiliseconds = false)
        {
            if (item != null)
            {
                restRequest.AddQueryParameterIfNotEmpty(name, (DateTime)item);
            }
        }

        public static void AddQueryParameterIfNotEmpty(this RestRequest restRequest, string name, DateTime item, bool includeMiliseconds = false)
        {
            var format = "yyyy-MM-ddTHH:mm:ssZ";
            if(includeMiliseconds)
                format = "yyyy-MM-ddTHH:mm:ss.FFZ";

            restRequest.AddQueryParameter(name, item.ToString(format));



        }

    }
}
