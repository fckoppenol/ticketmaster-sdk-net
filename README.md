# ticketmaster-sdk-net

https://developer.ticketmaster.com/products-and-docs/apis/international-discovery/

```c#
  var client = new InternationalDiscoveryClient({apiKey});

  var arguments = new EventSearchArguments{
      DomainIds = new List<string> { "netherlands" },
      CategoryIds = new List<int> { 10001 },
      Lang = new CultureInfo("en-us"),
      IsSeatsAvailable = true,
      SortBy = EventSearch.SortOptions.Popularity,
      Order = EventSearch.OrderOptions.Descending,
      Rows = 250
  };

  var events = await client.EventSearchAsync(arguments);

```
