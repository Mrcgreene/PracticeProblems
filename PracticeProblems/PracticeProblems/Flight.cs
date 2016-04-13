using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Flight
    {
        public string airline;
        public int flightNumber;
        public string timeOfFlight;

        public Flight(string Airline, int FlightNumber, string TimeOfFlight)
        {
            airline = Airline;
            flightNumber = FlightNumber;
            timeOfFlight = TimeOfFlight;
        }

    }



    /*
        Custom Iterator
-       Problem 1: You have a flight from Milwaukee to Los Angeles. Unfortunately, you had too much fun staying up and playing video games 
        the night before, which resulted in missing your flight. Iterate through all of the flight numbers leaving Milwaukee to see when you
        can catch the next flight to Los Angeles. This means having a collection of all flights leaving Milwaukee to the various destinations
        to iterate through. Use Expedia or any other online resource to gather the flights for a specific date (this means using real data
        for the lab). Print and return the time of flight and flight number you are taking.
    */
}
