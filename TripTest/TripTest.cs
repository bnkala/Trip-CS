using MainTripNS;
using TripNS;
namespace TripTestNS
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void TestFare()
        {
            Trip t1 = new Trip("111 RAJ", "Greenfields", 15.0);
            //String result = t1.toString();
            //Assert.AreEqual("Car Id: 111 RAJ\nDestination: Greenfields\nDistance: 15km\nTotal Fare payable: R50", result);
            double result = t1.Total_Fare();
            Assert.AreEqual(50.0, result);

        }

        [TestMethod]
        public void TestOutput()
        {
            Trip t1 = new Trip("12 Parrow", "Cape Town", 18.0);
            String result = t1.toString();
            Assert.AreEqual("Car Id: 12 Parrow"+
                "\nDestination: Cape Town"+
                "\nDistance: 18km"+
                "\nTotal Fare payable: R50", result);

        }

        [TestMethod]
        public void TestOutput2()
        {
            Trip t1 = new Trip("111 RAJ", "Greenfields", 15.0);
            String result = t1.toString();
            Assert.AreEqual("Car Id: 111 RAJ"+
                "\nDestination: Greenfields"+
                "\nDistance: 15km"+
                "\nTotal Fare payable: R50", result);
        }
    }
}