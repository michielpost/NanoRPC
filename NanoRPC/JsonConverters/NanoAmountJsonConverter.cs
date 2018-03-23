using NanoRPC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace NanoRPC.JsonConverters
{
  /// <summary>
  /// Based on: https://raw.githubusercontent.com/Flufd/NanoDotNet/master/NanoDotNet/JsonConverters/NanoAmountJsonConverter.cs
  /// </summary>
  public class NanoAmountJsonConverter : JsonConverter
  {
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
      writer.WriteValue(((NanoAmount)value).ToString());
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
      return new NanoAmount(BigInteger.Parse(reader.Value.ToString()), AmountBase.raw);
    }

    public override bool CanConvert(Type objectType)
    {
      return objectType == typeof(NanoAmount);
    }
  }
}
