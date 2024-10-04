namespace Practice1

{
	class Scooter : VehicleWithoutPlate
	{
		private const string typeOfVehicle = "Scooter";
		private bool isMoving;

        public Scooter() : base("Scooter")
		{
			isMoving = false;
		}

		public void StartMoving()
			{ isMoving = true; }
		public void StopMoving() 
			{ isMoving = false; }
		public bool IsMoving()
			{ return isMoving; }
	}
}