using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorAssignment
{
    class SystemOperations
    {

        public SystemOperations()
        {

        }

        public void StartMenu()
        {
            Console.WriteLine("Welcome to Expedia!");
            Console.WriteLine("-------------------");
            Console.WriteLine("What are you here for?");
            Console.WriteLine("1.Flights");
            Console.WriteLine("2.Exit");
            Console.WriteLine("-------------------");
            Options();
        }

        public void Options()
        {
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                AirportSchedule MilToLA = new AirportSchedule();
                MilToLA.AddFlights();
                foreach (Flight flight in  MilToLA)
                {
                    Console.WriteLine(flight.companyName +" "+ flight.flightNumber);
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("The earliest flight would be American Airlines Flight # 2926");
                Console.ReadKey();
                
            }
            else if (choice == 2)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Thank you for using Expedia for your traveling purposes!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Sorry I don't recognize that command. Please enter the numerical value associated with your decision.");
                Console.WriteLine("-------------------");
                StartMenu();
            }
        }

    }
}
