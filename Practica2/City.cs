namespace Practice1
{
    class City : IMessageWritter
    {
        private PoliceStation policeStation;
        private List<string> taxiLicenses;

        public City()
        {
            policeStation = new PoliceStation();
            taxiLicenses = new List<string>();
        }

        public void RegisterTaxiLicense(string license)
            { taxiLicenses.Add(license); }

        public void RemoveTaxiLicense(string license)
            { taxiLicenses.Remove(license); }

        public virtual string WriteMessage(string message)
            { return $"{this}: {message}"; }
    }
}