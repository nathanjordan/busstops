/*
------------------------------------------------------------------------------
Overview
------------------------------------------------------------------------------

Search view:
http://i.imgur.com/s50sSC9.jpg

Stop times view:
http://i.imgur.com/OyVf2rw.jpg


------------------------------------------------------------------------------
Big picture
------------------------------------------------------------------------------



iOS/Android -------> .NET MVC Server ----------> sf.gov
                           ^
                           |
                           |
                       This is us



------------------------------------------------------------------------------
Sample requests/responses from sf.gov
------------------------------------------------------------------------------

These are sf.gov endpoints our API will use to return data to the app.


-- This gives us ALL the bus stops (3,000ish) --

GET http://busses.sf.gov/api/bus-stops

[
    {
        "stop_id": 1,
        "latitude": 37.783975,
        "longitude": -122.399131
    }
]

-- This gives us the next 5 times a bus is expected to arrive --

GET http://busses.sf.gov/api/bus-stops/:stop_id/next-times

[
    "2014-11-03T11:50:02-08:00",
    "2014-11-03T11:50:07-08:00",
    "2014-11-03T11:50:12-08:00",
    "2014-11-03T11:50:18-08:00",
    "2014-11-03T11:50:20-08:00",
]


Lets implement the below functions!

*/



/// <summary>
/// A helper class that will be called by view functions.
/// </summary>
public class BusStopHelpers {

    /// <summary>
    /// Aggregate bus stop data from sf.gov into some model for use in the
    /// below functions.
    /// </summary>

    /// <returns>Some model of the bus data.</returns>
    public T LoadStopData() {

    }

    /// <summary>
    /// Gets stops within a given area to a specified latitude/longitude.
    /// </summary>

    /// <param name="lat">latitude</param>
    /// <param name="lng">longitude</param>
    /// <param name="boundingBoxSize">Size of bounding box</param>
    /// <returns>A list of stop id's</returns>
    List<Stop> GetNearbyStops(float lat, float lng, float boundingBoxSize) {

    }

    /// <summary>
    /// Get next 5 bus arrivals for a given stop.
    /// </summary>

    /// <param name="stopId"> The stop id we're getting the times for</param>
    /// <param name="ext"> 5 bus arrivals in minutes (integers)</param>
    /// <returns>List of times in minutes</returns>
    List<int> GetBusArrivalsInMinutes(int stopId) {

    }

}
