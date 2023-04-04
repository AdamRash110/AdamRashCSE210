using System;

namespace VehicleRentalService
{
    public class Truck : Vehicle
    {
        private double bedLength;
        private double towingCapacity;

        public Truck(string make, string model, int year, double rentalRate, double bedLength, double towingCapacity) : base(make, model, year, rentalRate)
        {
            this.bedLength = bedLength;
            this.towingCapacity = towingCapacity;
        }

        public double BedLength
        {
            get { return bedLength; }
            set { bedLength = value; }
        }

        public double TowingCapacity
        {
            get { return towingCapacity; }
            set { towingCapacity = value; }
        }

        public override string GetVehicleType()
        {
            return "Truck";
        }
    }
}