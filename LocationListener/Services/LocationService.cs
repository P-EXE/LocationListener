namespace LocationListener.Services;

public class LocationService : ILocationService
{
  public async Task<EventHandler> StartGetingLocationAsync()
  {
    try
    {
      Geolocation.LocationChanged += Geolocation_LocationChanged;
      var request = new GeolocationListeningRequest();
      var success = await Geolocation.StartListeningForegroundAsync(request);

      string status = success
          ? "Started listening for foreground location updates"
          : "Couldn't start listening";
      return;
    }
    catch (Exception ex)
    {
      // Unable to start listening for location changes
    }
  }

  public Task StopGetingLocationAsync()
  {
    try
    {
      Geolocation.LocationChanged -= Geolocation_LocationChanged;
      Geolocation.StopListeningForeground();
      string status = "Stopped listening for foreground location updates";
    }
    catch (Exception ex)
    {
      // Unable to stop listening for location changes
    }

    return Task.CompletedTask;
  }

  void Geolocation_LocationChanged(object? sender, GeolocationLocationChangedEventArgs e)
  {
    // Process e.Location to get the new location
  }
}
