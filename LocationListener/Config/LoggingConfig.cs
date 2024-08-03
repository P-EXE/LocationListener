using Microsoft.Extensions.Logging;

namespace LocationListener.Config;

internal static class LoggingConfig
{
  public static Task ConfigureLogging(this MauiAppBuilder builder)
  {
    builder.Logging.AddDebug();

    return Task.CompletedTask;
  }
}
