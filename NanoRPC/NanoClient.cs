using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace NanoRPC
{
  public class NanoClient
  {
    public static INanoRPC GetClient(string baseUrl)
    {
      var nanoApi = new RestClient(baseUrl)
      {
         
        JsonSerializerSettings = new JsonSerializerSettings()
        {
          ContractResolver = new CamelCasePropertyNamesContractResolver(),
          NullValueHandling = NullValueHandling.Ignore
        }
      }.For<INanoRPC>();
      return nanoApi;
    }
  }
}
