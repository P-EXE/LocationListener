using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LocationListener.Services;
using System.Collections.ObjectModel;

namespace LocationListener.ViewModels;

public partial class LocationVM(ILocationService locationService) : ObservableObject
{
  private readonly ILocationService _locationService = locationService;

  [ObservableProperty]
  private ObservableCollection<Location> _locations;

  [RelayCommand]
  private async Task StartGettingLocation()
  {
    await _locationService.StartGetingLocationAsync();
  }

  [RelayCommand]
  private async Task StopGettingLocation()
  {
    await _locationService.StopGetingLocationAsync();
  }


}
