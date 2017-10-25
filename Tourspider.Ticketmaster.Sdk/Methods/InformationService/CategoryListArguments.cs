using System.Collections.Generic;
using Tourspider.Ticketmaster.Sdk;
using Tourspider.Ticketmaster.Sdk.Interfaces;


namespace Tourspider.Ticketmaster.Sdk.Methods
{
    public class CategoryListArguments : IRequestParameters
    {
        public string Language { get; set; }

        public List<string> DomainIds { get; set; } = new List<string>();

        public List<int> CatergoryIds { get; set; } = new List<int>();

        public bool SubCategories { get; set; } = true;

        public void AddToRequest(RestRequest restRequest)
        {
            if (DomainIds != null && DomainIds.Count > 0)
            {
                restRequest.AddQueryParameter("domain_ids", string.Join(",", DomainIds));
            }

            if (!string.IsNullOrEmpty(Language))
            {
                restRequest.AddQueryParameter("lang", Language);
            }
            
            if (CatergoryIds != null && CatergoryIds.Count > 0)
            {
                restRequest.AddQueryParameter("category_id", string.Join(",", CatergoryIds));
            }

            restRequest.AddQueryParameter("subcategories", SubCategories.ToString().ToLowerInvariant());
        }
    }
}
