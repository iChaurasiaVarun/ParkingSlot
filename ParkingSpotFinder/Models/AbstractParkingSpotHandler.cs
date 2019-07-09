using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSpotFinder.Models
{
    /// <summary>
    /// Base Abstract Factory for finding Parking Slot 
    /// </summary>
    abstract class AbstractParkingSpotHandler
    {
        /// <summary>
        /// For Handling in memory parking slots
        /// </summary>
        Dictionary<ParkingSpotSize, int> parkingSpots = null;
        public AbstractParkingSpotHandler()
        {
            
        }

        public AbstractParkingSpotHandler(Dictionary<ParkingSpotSize, int> parkingSpots)
        {
            this.parkingSpots = parkingSpots;
        }
        public abstract ParkingSpotSize GetParkingSpot(VehicleType vehicle);

        protected virtual bool IsHatchBackSpotAvailable()
        {
            return this.parkingSpots.ContainsKey(ParkingSpotSize.HatchBack) && this.parkingSpots[ParkingSpotSize.HatchBack] > 0; 
        }

        protected virtual bool IsSedanSpotAvailable()
        {
            return this.parkingSpots.ContainsKey(ParkingSpotSize.Sedan) && this.parkingSpots[ParkingSpotSize.Sedan] > 0;
        }

        protected virtual bool IsMiniTruckSpotAvailable()
        {
            return this.parkingSpots.ContainsKey(ParkingSpotSize.Mini_Truck) && this.parkingSpots[ParkingSpotSize.Mini_Truck] > 0;
        }

        protected virtual void AddParkingSpot(ParkingSpotSize parkingSpotSize)
        {
            this.parkingSpots[parkingSpotSize] += 1;
        }

        protected virtual void RemoveParkingSpot(ParkingSpotSize parkingSpotSize)
        {
            this.parkingSpots[parkingSpotSize] -= 1;
        }
    }
}
