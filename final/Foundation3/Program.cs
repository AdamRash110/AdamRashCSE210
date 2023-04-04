using System;

namespace VehicleRentalService
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalService rentalService = new RentalService();

            Car car1 = new Car("Honda", "Civic", 2020, 50.0, 4, "Automatic");
            Car car2 = new Car("Toyota", "Corolla", 2021, 60.0, 4, "Automatic");
            Truck truck1 = new Truck("Ford", "F-150", 2019, 100.0, 6.5, 10000.0);

            rentalService.AddVehicle(car1);
            rentalService.AddVehicle(car2);
            rentalService.AddVehicle(truck1);

            List<Vehicle> availableCars = rentalService.GetAvailableVehiclesByType("Car");
            Console.WriteLine("Available Cars:");
            foreach (Vehicle car in availableCars)
            {
                Console.WriteLine($"{car.Make} {car.Model}, Year: {car.Year}, Rental Rate: {car.RentalRate:C}, Number of Doors: {((Car)car).NumDoors}, Transmission Type: {((Car)car).TransmissionType}");
            }

            rentalService.RentVehicle(car1);

            availableCars = rentalService.GetAvailableVehiclesByType("Car");
            Console.WriteLine("Available Cars:");
            foreach (Vehicle car in availableCars)
            {
                Console.WriteLine($"{car.Make} {car.Model}, Year: {car.Year}, Rental Rate: {car.RentalRate:C}, Number of Doors: {((Car)car).NumDoors}, Transmission Type: {((Car)car).TransmissionType}");
            }

            rentalService.ReturnVehicle(car1);

            availableCars = rentalService.GetAvailableVehiclesByType("Car");
            Console.WriteLine("Available Cars:");
            foreach (Vehicle car in availableCars)
            {
                Console.WriteLine($"{car.Make} {car.Model}, Year: {car.Year}, Rental Rate: {car.RentalRate:C}, Number of Doors: {((Car)car).NumDoors}, Transmission Type: {((Car)car).TransmissionType}");
            }
        }
    }
}