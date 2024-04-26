using System;

public class Taxi
{
	public string IN_RANK = "in rank";
	public string ON_ROAD = "on the road";

	public double CurrentFare { get; set; }
	public string Destination { get; set; } = ""
	public string Location { get; set; } = ON_ROAD;
	public int Number { get; }
	public double TotalMoneyPaid { get; set; }
	






	public Taxi(int taxiNum)
	{
		Number = taxiNum;

	}
}
