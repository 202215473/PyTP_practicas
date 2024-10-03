namespace Practice1

{
	public class City
	{
		private PoliceStation policeStation;
		private List<string> taxiLicenses;

		public City()
		{
			policeStation = new PoliceStation();
		}
		
		public void RegisterTaxiLicense(string license)
			{ taxiLicenses.Add(license); }

        public void RemoveTaxiLicense(string license)
			{ taxiLicenses.Remove(license); }
    }
}