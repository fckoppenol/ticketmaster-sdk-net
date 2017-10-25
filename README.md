# ticketmaster-sdk-net

```
  var discoveryClient = new DiscoveryClient("3fMpxk4EmTds3GaRJK4bfNiTAKx4zNGm");

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
