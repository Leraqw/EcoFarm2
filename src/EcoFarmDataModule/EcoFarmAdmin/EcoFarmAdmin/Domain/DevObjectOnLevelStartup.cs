using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin.Domain;

[PrimaryKey(nameof(DevObjectID), nameof(LevelID))]
public class DevObjectOnLevelStartup
{
	public int DevObjectID { get; set; }
	public int LevelID     { get; set; }
	public int Quantity    { get; set; }
}