namespace Practice1
{
	class PoliceStation : IMessageWritter
	{
		private List<PoliceCar> listPoliceCars;
		private bool alert;

		public PoliceStation()
		{
			alert = false;
			listPoliceCars = new List<PoliceCar>();
        }

        public void SetNewCar(string newPlate, bool withRadar)
        { 
			listPoliceCars.Add(new PoliceCar(newPlate, withRadar)); 
		}

        public void SetAlert(bool value)
			{ alert = value; }

		public void NotifyPlate(string plate)
		{
			for (int i = 0; i < listPoliceCars.Count; i++)
			{
				if (listPoliceCars[i].IsPatrolling())
					{ listPoliceCars[i].NewInfractor(plate); }
			}
		}
		public void ReceiveAlert(string plate)
		{
			SetAlert(true);
			NotifyPlate(plate);
			SetAlert(false);  // So that there is not always an alert
		}

		public virtual string WriteMessage(string message)
			{ return $"{this}: {message}"; }
	}
}