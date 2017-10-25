# ticketmaster-sdk-net

https://developer.ticketmaster.com/products-and-docs/apis/international-discovery/

```
  var discoveryClient = new DiscoveryClient({apiKey});

  var arguments = new EventSearchArguments{
      DomainIds = new List<string> { "netherlands" },
      CategoryIds = new List<int> { 10001 },
      Lang = "en-us",
      IsSeatsAvailable = true,
      SortBy = EventSearchArguments.SortOptions.Popularity,
      Order = EventSearchArguments.OrderOptions.Descending,
      Rows = 250
  };

  var events = await discoveryClient.EventSearchAsync(arguments);

```
