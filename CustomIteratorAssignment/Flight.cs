using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorAssignment
{
    public class Flight 
    {
        public string companyName;
        public int flightNumber;
        public string departureTime;
        public string arrivalTime;
        public double price;
        
        public Flight(string Name,int FlightNumber, string DepartureTime, string ArrivalTime, double Price)
        {
            companyName = Name;
            flightNumber = FlightNumber;
            departureTime = DepartureTime;
            arrivalTime = ArrivalTime;
            price = Price;
            
        }

        

    }
}
