using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin.Domain;

[PrimaryKey(nameof(DevObjectId), nameof(LevelId))]
public class DevObjectOnLevelStartup
{
	[ForeignKey(nameof(DevObjectId))]
	public int       DevObjectId { get; set; }
	public DevObject DevObject   { get; set; } = null!;
	public int       LevelId     { get; set; }
	public Level     Level       { get; set; } = null!;
	public int       Quantity    { get; set; }
}