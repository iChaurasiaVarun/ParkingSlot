using System;
using System.Collections.Generic;
using System.Text;
using ParkingSpotFinder.Models;

namespace ParkingSpotFinder.Repository
{
    /// <summary>
    /// In memory parking spot handler factory
    /// </summary>
    class InMemoryParkingSpotHandlerFactory : ParkingSpotHandlerFactory
    {        
        public override AbstractParkingSpotHandler GetParkingSpotHandler(Dictionary<ParkingSpotSize, int> parkingSpots) => new InMemoryParkingSpotHandler(parkingSpots);

    }
}
