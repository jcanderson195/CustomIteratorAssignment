using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorAssignment
{
    class AirportSchedule : IEnumerable
    {
        List<Flight> Flights;

        public AirportSchedule()
        {
            Flights = new List<Flight>();
        }

        public void AddFlights()
        {
            
            Flights.Add(new Flight("American Airlines", 449 ,"5:10pm", "9:18pm", 202.60));
            Flights.Add(new Flight("American Airlines",493 ,"6:59am", "11:51am", 202.60));
            Flights.Add(new Flight("Delta",927 ,"7:43pm", "11:44pm", 272.60));
            Flights.Add(new Flight("United",5013 ,"1:33pm", "5:55pm", 272.60));
            Flights.Add(new Flight("American Airlines",2926 ,"6:49am", "11:20am", 272.60));

            foreach (Flight flight in Flights)
            {
                Console.WriteLine(string.Format("[Company: {0} , Flight #: {1}  Departure: {2} , Arrival: {3} , Price: {4} ]",flight.companyName,flight.flightNumber,flight.departureTime,flight.arrivalTime,flight.price));
            }
        }

       

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Flights available from Milwaukee to Los Angeles");
            for (int i = 0; i < Flights.Count; i++)
            {
                yield return Flights[i];
                
            }
            
        }

    }
}
