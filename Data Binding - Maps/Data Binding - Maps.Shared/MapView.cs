using Bing.Maps;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls;

namespace Data_Binding___Maps
{
    class MapView : Grid
    {
#if WINDOWS_APP
        private Map _map;
#elif WINDOWS_PHONE_APP
        private MapControl _map;
#endif

        public MapView()
        {
#if WINDOWS_APP
            _map = new Map();
#elif WINDOWS_PHONE_APP
            _map = new MapControl();
#endif 
            this.Children.Add(_map);
        }


        public void SetView(BasicGeoposition Center, Double Zoom)
        {
#if WINDOWS_APP
            _map.SetView(Center.ToLocation(), Zoom);
            onPropertyChanged("Center");
            onPropertyChanged("Zoom");
#elif WINDOWS_PHONE_APP
            _map.Center = new Geopoint(Center);
            _map.ZoomLevel = Zoom;
#endif
        }

        private void onPropertyChanged(string p)
        {
//            throw new NotImplementedException();
        }

    }
}
