namespace Practice1

public class PoliceStation
{
	private List<PoliceCar> listPoliceCars;
	private bool alert = false;

	public PoliceStation()
	{
	}
	
	public void SetAlert(bool value)
		{ alert = value; }
	public bool GetAlert()
		{ return alert; }
	public void SetNewCar(string newPlate)
		{ listPoliceCars.Add(newPlate); }

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
    }
}
