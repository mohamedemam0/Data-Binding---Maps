using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.Geolocation;

#if WINDOWS_APP
using Bing.Maps;
using System.Collections;
#endif

namespace Data_Binding___Maps
{
    public static class Extensions
    {

#if WINDOWS_APP
        public static LocationCollection ToLocationCollection (this IList<BasicGeoposition>PointList)
        {
            var locations = new LocationCollection();
            foreach (var p in PointList)
           	{
           		   locations.Add(p.ToLocation());                             
           	}
            return locations;
        }

        public static Geopoint ToGeopoint(this Location location)
        {
            return new Geopoint(new BasicGeoposition()
            { Latitude = location.Latitude, Longitude = location.Longitude });
        }


        public static Location ToLocation(this Geopoint location)
        {
            return new Location(location.Position.Latitude, location.Position.Longitude);
        }


        public static Location ToLocation(this BasicGeoposition location)
        {
            return new Location(location.Latitude, location.Longitude);
        }
#endif
    }
}
