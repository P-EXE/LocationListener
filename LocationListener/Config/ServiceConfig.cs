using LocationListener.Services;

namespace LocationListener.Config;

internal static class ServiceConfig
{
  public static Task ConfigureServices(this MauiAppBuilder builder)
  {
    builder.Services.AddTransient<ILocationService, LocationService>();

    return Task.CompletedTask;
  }
}
