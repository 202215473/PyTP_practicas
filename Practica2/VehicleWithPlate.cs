namespace Practice1
{
    abstract class VehicleWithPlate: Vehicle
    {
        private string plate;

        public VehicleWithPlate(string plate)
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
            return plate;
        }
    }
}