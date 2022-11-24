using SQLite;

namespace EcoFarmDataModule;

[Serializable]
public abstract class DevelopmentObject
{
	[PrimaryKey, AutoIncrement, Unique] public int    Id          { get; set; }
	public                                     string Title       { get; set; }
	public                                     string Description { get; set; }
	public                                     int    Price       { get; set; }
}