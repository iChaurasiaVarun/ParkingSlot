using ParkingSpotFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSpotFinder.Repository
{
    /// <summary>
    /// Base class for InMemory Parking Spot
    /// </summary>
    class InMemoryParkingSpotHandler : AbstractParkingSpotHandler
    {
        public InMemoryParkingSpotHandler(Dictionary<ParkingSpotSize, int> parkingSpots): base(parkingSpots)
        {
            
        }
        
        /// <summary>
        /// Override method for Getting available parking slot
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public override ParkingSpotSize GetParkingSpot(VehicleType vehicle)
        {
            switch(vehicle)
            {
                case VehicleType.Car:
                    if(base.IsHatchBackSpotAvailable())
                    {
                        base.RemoveParkingSpot(ParkingSpotSize.HatchBack);
                        return ParkingSpotSize.HatchBack;
                    } else if (base.IsSedanSpotAvailable())
                    {
                        base.RemoveParkingSpot(ParkingSpotSize.Sedan);
                        return ParkingSpotSize.Sedan;
                    } else if (base.IsMiniTruckSpotAvailable())
                    {
                        base.RemoveParkingSpot(ParkingSpotSize.Mini_Truck);
                        return ParkingSpotSize.Mini_Truck;
                    } else
                    {
                        return ParkingSpotSize.NoSpace;
                    }
                    break;
            }
            throw new Exception("Not Supported Vehicle Type");
        }
    }
}
