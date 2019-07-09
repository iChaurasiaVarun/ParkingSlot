using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingSpotFinder.Models;
using ParkingSpotFinder.Provider;

namespace ParkingSpotTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Method to check best fitted parking slot available
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            // Creating in memory parking slots
            Dictionary<ParkingSpotSize, int> parkingSpots = new Dictionary<ParkingSpotSize, int>();
            // two slot for sedan
            parkingSpots.Add(ParkingSpotSize.Sedan, 2);
            // one slot for hatchback
            parkingSpots.Add(ParkingSpotSize.HatchBack, 1);

            // for first car, getting hatchback parking slot
            Assert.IsTrue(new ParkingSpotProvider(parkingSpots).GetParkingSpotSize(VehicleType.Car) == ParkingSpotSize.HatchBack);

            // for second car, getting sedan parking slot as no hatchback slot avaialble
            Assert.IsTrue(new ParkingSpotProvider(parkingSpots).GetParkingSpotSize(VehicleType.Car) == ParkingSpotSize.Sedan);

            // for third car, again getting sedan parking slot as no hatchback slot avaialble
            Assert.IsTrue(new ParkingSpotProvider(parkingSpots).GetParkingSpotSize(VehicleType.Car) == ParkingSpotSize.Sedan);

            // for fourth car, getting no parking slot avaialble because we have only 3 parking slot which already occupied.
            Assert.IsTrue(new ParkingSpotProvider(parkingSpots).GetParkingSpotSize(VehicleType.Car) == ParkingSpotSize.NoSpace);

        }
    }
}
