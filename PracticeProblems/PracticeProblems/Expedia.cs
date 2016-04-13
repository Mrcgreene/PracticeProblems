using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Expedia : IEnumerable
    {
        public List<Flight> departingFlights;
        public Flight flight;

        public Expedia()
        {
            departingFlights = new List<Flight>();
        }

        public void AddFlights()
        {
            departingFlights.Add(new Flight("American", 5755, "5:10p"));
            departingFlights.Add(new Flight("American", 5661, "6:59a"));
            departingFlights.Add(new Flight("United", 5165, "12:44p"));
            departingFlights.Add(new Flight("United", 5158, "10:24a"));
            departingFlights.Add(new Flight("United", 5013, "1:33p"));
            departingFlights.Add(new Flight("United", 5172, "5:15a"));
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < departingFlights.Count; i++)
            {
                yield return departingFlights[i];
            }
            // yield return "There Are No More Flights";
        }
    }


}
