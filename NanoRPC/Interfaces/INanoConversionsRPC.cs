using Refit;
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
    Task<ConversionResponse> MraiFromRaw(MraiFromRawRequest req);

    /// <summary>
    /// Divide a raw amount down by the krai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> KraiFromRaw(KraiFromRawRequest req);

    /// <summary>
    /// Divide a raw amount down by the rai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> RaiFromRaw(RaiFromRawRequest req);

    /// <summary>
    /// Multiply an Mrai amount by the Mrai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> MraiToRaw(MraiToRawRequest req);

    /// <summary>
    /// Multiply an krai amount by the krai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> KraiToRaw(KraiToRawRequest req);

    /// <summary>
    /// Multiply an rai amount by the rai ratio.
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    [Post("")]
    Task<ConversionResponse> RaiToRaw(RaiToRawRequest req);
  }
}
