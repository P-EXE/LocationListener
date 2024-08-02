using LocationListener.Pages;

namespace LocationListener.Config;

internal static class PageConfig
{
  public static Task ConfigurePages(this MauiAppBuilder builder)
  {
    builder.Services.AddTransient<LocationPage>();

    return Task.CompletedTask;
  }
}
