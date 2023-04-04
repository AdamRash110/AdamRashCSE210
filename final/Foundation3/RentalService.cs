using System;

namespace VehicleRentalService
{
    public class RentalService
    {
        private List<Vehicle> availableVehicles;
        private List<Vehicle> rentedVehicles;

        public RentalService()
        {
            availableVehicles = new List<Vehicle>();
            rentedVehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            availableVehicles.Add(vehicle);
        }

        public void RentVehicle(Vehicle vehicle)
        {
            availableVehicles.Remove(vehicle);
            rentedVehicles.Add(vehicle);
        }

        public void ReturnVehicle(Vehicle vehicle)
        {
            rentedVehicles.Remove(vehicle);
            availableVehicles.Add(vehicle);
        }

        public List<Vehicle> GetAvailableVehiclesByType(string type)
        {
            List<Vehicle> result = new List<Vehicle>();
            foreach (Vehicle vehicle in availableVehicles)
            {
                if (vehicle.GetVehicleType() == type)
                {
                    result.Add(vehicle);
                }
            }
            return result;
        }
    }
}