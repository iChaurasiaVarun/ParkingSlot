using ParkingSpotFinder.Models;
using ParkingSpotFinder.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSpotFinder.Provider
{
    /// <summary>
    /// Common class to interact with providing the available parking slot
    /// </summary>
    public class ParkingSpotProvider
    {
        
        AbstractParkingSpotHandler parkingSpotHandler = null;
        ParkingSpotHandlerFactory ParkingSpotHandlerFactory = null;

        /// <summary>
        /// Parameterized constrcutor for in memory parking slots provider
        /// </summary>
        /// <param name="parkingSpots"></param>
        public ParkingSpotProvider(Dictionary<ParkingSpotSize, int> parkingSpots)
        {
            this.ParkingSpotHandlerFactory = new InMemoryParkingSpotHandlerFactory();
            this.parkingSpotHandler = this.ParkingSpotHandlerFactory.GetParkingSpotHandler(parkingSpots);
        }   

        /// <summary>
        /// Default constructor for other type of parking slots provider
        /// </summary>
        public ParkingSpotProvider()
        {

        }
                
        /// <summary>
        /// Public method to get Best Parking spot
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public ParkingSpotSize GetParkingSpotSize(VehicleType vehicle)
        {
            return this.parkingSpotHandler.GetParkingSpot(vehicle);
        }
    }
}
