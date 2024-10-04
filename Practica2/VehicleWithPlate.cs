namespace Practice1
{
    abstract class VehicleWithPlate: Vehicle
    {
        protected string plate;

        public VehicleWithPlate(string typeOfVehicle, string plate) : base(typeOfVehicle)
        {
            this.plate = plate;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public string GetPlate()
        {
            return this.plate;
        }
    }
}