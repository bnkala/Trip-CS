// See https://aka.ms/new-console-template for more information
using System;
using TripNS;

namespace MainTripNS
{
    public class MainTrip
    {
        public static void Main(String[] args)
        {
            Trip t1 = new Trip("007 BOND", "Cape Town",250.0);
            Trip t2 = new Trip("111 RAJ", "Greenfields", 15.0);
            Trip t3 = new Trip("111 JON", "Port Elizabeth", 150.0);

            Console.WriteLine(t1.toString() + "\n");
            Console.WriteLine(t2.toString() + "\n");
            Console.WriteLine(t3.toString());
            Console.ReadLine();
        }
    }
}
