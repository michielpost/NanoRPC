using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  public class NanoClient
  {
    public static INanoRPC GetClient(string baseUrl)
    {
      var nanoApi = RestService.For<INanoRPC>(baseUrl,
        new RefitSettings
        {
          JsonSerializerSettings = new JsonSerializerSettings
          {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
          }
        });
      return nanoApi;
    }
  }
}
