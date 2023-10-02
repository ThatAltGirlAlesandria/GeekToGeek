#nullable enable

namespace G2GClient.Models;

public class ErrorViewModel
{
  public string RequestId { get; set; }
  public bool ShowRequestId => !string.IsNull(RequestId);
}