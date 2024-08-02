namespace LocationListener.Services;

public interface ILocationService
{
  Task<EventHandler> StartGetingLocationAsync();
  Task StopGetingLocationAsync();
}
