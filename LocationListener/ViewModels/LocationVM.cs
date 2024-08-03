using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LocationListener.Services;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;

namespace LocationListener.ViewModels;

public partial class LocationVM : ObservableObject
{
  private readonly ILocationService _locationService;
  private readonly ILogger<LocationVM> _logger;
  public LocationVM(ILogger<LocationVM> logger, ILocationService locationService)
  {
    _locationService = locationService;
    _locationService.LocationChanged += OnLocationChanged;

    _logger = logger;
  }

  [ObservableProperty]
  private ObservableCollection<Location> _locations = [];
  [ObservableProperty]
  [NotifyPropertyChangedFor(nameof(IsNotListening))]
  private bool _isListening = false;
  public bool IsNotListening => !IsListening;

  [RelayCommand]
  private async Task StartGettingLocation()
  {
    _logger.LogInformation("Clearing Locations Collection");
    Locations = [];
    _logger.LogInformation("Trying to start getting location");
    await _locationService.StartGetingLocationAsync();
    IsListening = true;
  }

  [RelayCommand]
  private async Task StopGettingLocation()
  {
    _logger.LogInformation("Trying to stop getting location");
    await _locationService.StopGetingLocationAsync();
    IsListening = false;
  }

  private void OnLocationChanged(object? sender, GeolocationLocationChangedEventArgs e)
  {
    _logger.LogInformation("Got new location");
    Locations.Add(e.Location);
  }
}
