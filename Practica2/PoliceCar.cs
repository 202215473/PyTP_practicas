namespace Practice1
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private bool isChasing = false;
        private string infractorPlate;
        private PoliceStation policeStation;

        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar = new SpeedRadar();
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                speedRadar.TriggerRadar(vehicle);
                List<bool, string> result = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {result[1]}"));
                bool aboveLegalSpeed = result[0];
                if (aboveLegalSpeed) 
                { 
                    StartChasing(); 
                    policeStation.ReveiveAlert(vehicle.GetPlate());
                }
            }
            else
                { Console.WriteLine(WriteMessage($"has no active radar.")); }
        }

        public bool IsPatrolling()
            { return isPatrolling; }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
                {Console.WriteLine(WriteMessage("is already patrolling."));}
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
                {Console.WriteLine(WriteMessage("was not patrolling."));}
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
                { Console.WriteLine(speed); }
        }

        public void StartChasing()
            { isChasing = true; }

        public void StopChasing()
            { isChasing = false; }

        //public void SetInfractorPlate(string plate)
        //    { infractorPlate = plate; }
        public void NewInfractor(string plate)
        {
            StartChasing();
            SetInfractorPlate(plate);
        }
    }
}