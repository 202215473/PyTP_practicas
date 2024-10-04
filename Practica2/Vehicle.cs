namespace Practice1
{
    abstract class Vehicle : IMessageWritter
    {
        protected string typeOfVehicle;  // para que clases hijas puedan acceder a él
        private float speed;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            speed = 0f;
        }

        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}