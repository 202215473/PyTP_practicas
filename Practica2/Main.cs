namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            City city = new City();
            Console.WriteLine(city.WriteMessage("Created"));

            PoliceStation policeStation = new PoliceStation();
            Console.WriteLine(policeStation.WriteMessage("Created"));
            
            Taxi taxi1 = new Taxi("0001 AAA");
            city.RegisterTaxiLicense(taxi1.GetPlate());
            Taxi taxi2 = new Taxi("0002 BBB");
            city.RegisterTaxiLicense(taxi2.GetPlate());
            Taxi taxi3 = new Taxi("0003 CCC");
            city.RegisterTaxiLicense(taxi3.GetPlate());
            Taxi taxi4 = new Taxi("0004 DDD");
            city.RegisterTaxiLicense(taxi4.GetPlate());
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(taxi3.WriteMessage("Created"));
            Console.WriteLine(taxi4.WriteMessage("Created"));

            PoliceCar policeCar1 = new PoliceCar("0001 CNP", true);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", true);
            PoliceCar policeCar3 = new PoliceCar("0003 CNP", false);
            PoliceCar policeCar4 = new PoliceCar("0004 CNP", true);
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            Console.WriteLine(policeCar3.WriteMessage("Created"));
            Console.WriteLine(policeCar4.WriteMessage("Created"));

            policeCar3.StartPatrolling();
            policeCar3.UseRadar(taxi2);

            taxi1.StartRide();
            policeCar2.UseRadar(taxi1);
            policeCar2.StartPatrolling();

            policeCar4.StartPatrolling();
            policeCar2.UseRadar(taxi1);
            if (policeCar2.IsChasing())
            {
                taxi1.StopRide();
                city.RemoveTaxiLicense(taxi1.GetPlate());
            }
            policeCar2.EndPatrolling();

            policeCar2.PrintRadarHistory();

            Console.ReadLine();

        }
    }
}
    

