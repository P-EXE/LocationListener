An example MAUI App for listening to location changes.

Employes a Page, a View Model as well as a Service with an Interface.

# ILocationService
Defines:
- Start
- Stop
- Location Changed

# LocationService
Basically just a wrapper for starting or stopping listening to the `Geolocation.LocationChanged` `EventHandler`.

# LocationVM
The view model for the `LocationPage`. It listens to the `ILocationService` `LocationChanged` `EventHandler` and adds new `Location`s to an `ObservableCollection` `Locations`.

# LocationPage
The page consists of 2 `Button`s, start and stop, and a `CollectionView` displaying the `Location`s recorded since the start.

# Testing
The app was tested on a Samsung Galaxy S9 starlte G970F using [Fake GPS location](https://play.google.com/store/apps/details?id=com.lexa.fakegps&hl=de_AT&pli=1) and worked with acceptable performance.
