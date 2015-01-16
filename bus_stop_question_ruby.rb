=begin
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



iOS/Android -------> Sinatra Server ----------> sf.gov
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

=end


def load_stop_data()
    # Aggregate bus stop data from sf.gov into some model for use in the
    # below functions.
    #
    # Returns ?

end


def get_nearby_stops(lat, lng, bounding_box_size)
    # Gets stops within a given area to a specified latitude/longitude.
    #
    # lat - float of latitude
    # lng - float of longitude
    # bounding_box_size - float of size of box to restrict our search
    #
    # Returns a list of stop id's

end


def get_bus_arrivals_in_minutes(stop_id)
    # Get next 5 bus arrivals for a given stop.

    # stop_id - the stop we're querying
    #
    # Returns the next 5 bus arrivals in minutes (integers)

end
