using LocationListener.Config;
using Microsoft.Extensions.Logging;

namespace LocationListener
{
  public static class MauiProgram
  {
    public static MauiApp CreateMauiApp()
    {
      var builder = MauiApp.CreateBuilder();
      builder
        .UseMauiApp<App>()
        .ConfigureFonts(fonts =>
        {
          fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
          fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

      builder.ConfigureLogging();
      builder.ConfigurePages();
      builder.ConfigureServices();
      builder.ConfigureViewModels();

      return builder.Build();
    }
  }
}
