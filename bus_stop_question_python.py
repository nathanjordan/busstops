"""
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



iOS/Android -------> Flask Server ----------> sf.gov
                          ^
                          |
                          |
                      This is us



------------------------------------------------------------------------------
Sample requests/responses from sf.gov
------------------------------------------------------------------------------

These are sf.gov endpoints our API will use to return data to the app.


#### This gives us ALL the bus stops (3,000ish) ####

GET http://busses.sf.gov/api/bus-stops

[
    {
        "stop_id": 1,
        "latitude": 37.783975,
        "longitude": -122.399131
    }
]

#### This gives us the next 5 times a bus is expected to arrive ####

GET http://busses.sf.gov/api/bus-stops/:stop_id/next-times

[
    "2014-11-03T11:50:02-08:00",
    "2014-11-03T11:50:07-08:00",
    "2014-11-03T11:50:12-08:00",
    "2014-11-03T11:50:18-08:00",
    "2014-11-03T11:50:20-08:00",
]


Lets implement the below functions!

"""


def load_stop_data():
    """Aggregate bus stop data from sf.gov into some model for use in the
    below functions.

    :rtype ?:

    """
    pass


def get_nearby_stops(lat, lng, bounding_box_size):
    """Gets stops within a given area to a specified latitude/longitude.

       :type lat: float
       :type lng: float
       :type bounding_box_size: float
       :returns: A list of stop id's
       :rtype: list

    """
    pass


def get_bus_arrivals_in_minutes(stop_id):
    """Get next 5 bus arrivals for a given stop.

    :type stop_id: int
    :returns: Next 5 bus arrivals in minutes (integers)
    :rtype: list

    """
    pass
