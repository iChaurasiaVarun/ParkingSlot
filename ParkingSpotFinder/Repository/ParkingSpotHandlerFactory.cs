using ParkingSpotFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSpotFinder.Repository
{
    /// <summary>
    /// Parking spot handler factory
    /// </summary>
    abstract class ParkingSpotHandlerFactory
    {
        public abstract AbstractParkingSpotHandler GetParkingSpotHandler(Dictionary<ParkingSpotSize, int> parkingSpots = null);
    }
}
