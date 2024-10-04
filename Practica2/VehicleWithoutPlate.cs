namespace Practice1
{
    abstract class VehicleWithoutPlate : Vehicle
    {

        public VehicleWithoutPlate(string typeOfVehicle) : base(typeOfVehicle)
        {
        }
        
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with no plate";
        }
    }
}