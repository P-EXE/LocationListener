namespace LocationListener.Services;

public interface ILocationService
{
  /// <summary>
  /// Sends a GeolocationListeningRequest and
  /// starts listening to the Geolocation.LocationChanged event internally.
  /// </summary>
  /// <returns></returns>
  Task StartGetingLocationAsync();

  /// <summary>
  /// Invokes StopListeningForeground and
  /// stops listening to the Geolocation.LocationChanged event internally.
  /// </summary>
  /// <returns></returns>
  Task StopGetingLocationAsync();

  /// <summary>
  /// Gets called by the internal listener.
  /// </summary>
  /// <returns></returns>
  event EventHandler<GeolocationLocationChangedEventArgs> LocationChanged;
}
