namespace EcoFarmAdmin.Domain;

public class DevObjectOnLevelStartup
{
	public int       Id          { get; set; }
	public int       DevObjectId { get; set; }
	public DevObject DevObject   { get; set; } = null!;
	public int       LevelId     { get; set; }
	public Level     Level       { get; set; } = null!;
	public int       Quantity    { get; set; }
}