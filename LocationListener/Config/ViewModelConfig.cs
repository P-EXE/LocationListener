using LocationListener.ViewModels;

namespace LocationListener.Config;

internal static class ViewModelConfig
{
  public static Task ConfigureViewModels(this MauiAppBuilder builder)
  {
    builder.Services.AddTransient<LocationVM>();

    return Task.CompletedTask;
  }
}
