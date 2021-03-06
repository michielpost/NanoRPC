using RestEase;
using System;
using System.Threading.Tasks;

namespace NanoRPC
{
  public interface INanoConversionsRPC
  {

    /// <summary>
    /// Divide a raw amount down by the Mrai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> MraiFromRaw([Body]MraiFromRawRequest req);

    /// <summary>
    /// Divide a raw amount down by the krai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> KraiFromRaw([Body]KraiFromRawRequest req);

    /// <summary>
    /// Divide a raw amount down by the rai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> RaiFromRaw([Body]RaiFromRawRequest req);

    /// <summary>
    /// Multiply an Mrai amount by the Mrai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> MraiToRaw([Body]MraiToRawRequest req);

    /// <summary>
    /// Multiply an krai amount by the krai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> KraiToRaw([Body]KraiToRawRequest req);

    /// <summary>
    /// Multiply an rai amount by the rai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> RaiToRaw([Body]RaiToRawRequest req);
  }
}
