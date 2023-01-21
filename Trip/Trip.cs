using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripNS
{
    public class Trip
    {
        private String c_id;
        private String dest;
        private double dist;

        public Trip()
        {
            c_id = "";
            dest = "";
            dist = 0.0;
        }

        public Trip(String id, String destination, double distance)
        {
            c_id = id;
            dest = destination;
            dist = distance;
        }

        public String getID()
        {
            return c_id;
        }

        public String getDest()
        {
            return dest;
        }

        public double getDist()
        {
            return dist;
        }

        public void setID(String id)
        {
            c_id = id;
        }

        public void setDest(String destination)
        {
            dest = destination;
        }

        public void setDist(double distance)
        {
            dist = distance;
        }
        public double Total_Fare()
        {
            if (dist <= 20)
            {
                return 50;
            }
            else
            {
                return (50 + (dist - 20) * 2);
            }
        }

        public String toString()
        {
            String str;
            str = "Car Id: " + c_id + "\n" +
                "Destination: " + dest + "\n" +
                "Distance: " + dist + "km\n" +
                "Total Fare payable: R" + Total_Fare();

            return str;
        }

    }
}
