using System;

namespace VehicleRentalService
{
    public abstract class Vehicle
    {
        private string make;
        private string model;
        private int year;
        private double rentalRate;

        public Vehicle(string make, string model, int year, double rentalRate)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.rentalRate = rentalRate;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }

        public abstract string GetVehicleType();
    }
}