using LocationListener.ViewModels;

namespace LocationListener.Pages;

public partial class LocationPage : ContentPage
{
  public LocationPage(LocationVM vm)
  {
    InitializeComponent();

    BindingContext = vm;
  }
}
