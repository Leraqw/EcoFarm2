namespace EcoFarmDataModule;

[Serializable]
public class FactoryBuilding : Building
{
	public Product[] InputProducts;
	public Product[] OutputProducts;
	public Resource Resource;
	public int ResourceConsumptionCoefficient;
}