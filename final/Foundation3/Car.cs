using System;

namespace VehicleRentalService
{
    public class Car : Vehicle
    {
        private int numDoors;
        private string transmissionType;

        public Car(string make, string model, int year, double rentalRate, int numDoors, string transmissionType) : base(make, model, year, rentalRate)
        {
            this.numDoors = numDoors;
            this.transmissionType = transmissionType;
        }

        public int NumDoors
        {
            get { return numDoors; }
            set { numDoors = value; }
        }

        public string TransmissionType
        {
            get { return transmissionType; }
            set { transmissionType = value; }
        }

        public override string GetVehicleType()
        {
            return "Car";
        }
    }
}