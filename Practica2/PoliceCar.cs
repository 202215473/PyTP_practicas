namespace Practice1
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private bool isChasing;
        private string infractorPlate;
        private PoliceStation policeStation;

        public PoliceCar(string plate, bool radar) : base("Police Car", plate)
        {
            isPatrolling = false;
            isChasing = false;
            policeStation = new PoliceStation();
            infractorPlate = string.Empty;
            speedRadar = radar ? new SpeedRadar() : null;
        }

        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (speedRadar != null)
                {
                    if (isPatrolling)
                    {
                        speedRadar.TriggerRadar(vehicle);
                        var result = speedRadar.GetLastReading();
                        bool aboveLegalSpeed = result.Item1;
                        string message = result.Item2;
                        Console.WriteLine(WriteMessage($"Triggered radar. Result: {message}"));
                        if (aboveLegalSpeed)
                        {
                            NewInfractor(vehicle.GetPlate());
                            policeStation.ReceiveAlert(vehicle.GetPlate());
                        }
                    }
                    else
                        { Console.WriteLine(WriteMessage($"has no active radar.")); }
                }
            else
                { Console.WriteLine(WriteMessage($"has no radar.")); }
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
                { Console.WriteLine(WriteMessage("is already patrolling.")); }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
                { Console.WriteLine(WriteMessage("was not patrolling.")); }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                    { Console.WriteLine(speed); }
            }
            else
                { Console.WriteLine(WriteMessage("This police car has no radar")); }
        }

        public bool IsChasing()
            { return isChasing; }

        public void StartChasing()
        {
            if (!isChasing)
            {
                isChasing = true;
                Console.WriteLine(WriteMessage("started chasing a vehicle."));
            }
            else
                { Console.WriteLine(WriteMessage($"is already chasing a vehicle with plate {infractorPlate}.")); }
        }

        public void StopChasing()
        {
            if (isChasing)
            {
                isChasing = false;
                Console.WriteLine(WriteMessage($"stopped chasing the vehicle with plate {infractorPlate}."));
            }
            else
                { Console.WriteLine(WriteMessage("was not chasing a vehicle.")); }
        }

        public void SetInfractorPlate(string plate)
            { infractorPlate = plate; }

        public void NewInfractor(string plate)
        {
            StartChasing();
            SetInfractorPlate(plate);
        }
    }
}