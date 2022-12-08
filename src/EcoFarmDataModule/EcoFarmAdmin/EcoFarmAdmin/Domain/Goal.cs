namespace EcoFarmAdmin.Domain;

public class Goal
{
	public int       Id        { get; set; }
	public DevObject DevObject { get; set; } = null!;
	public Level     Level     { get; set; } = null!;
	public int       Quantity  { get; set; }
}