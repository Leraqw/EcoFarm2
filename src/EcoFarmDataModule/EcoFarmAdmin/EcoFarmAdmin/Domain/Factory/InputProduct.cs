namespace EcoFarmAdmin.Domain;

public class InputProduct
{
	public int     Id       { get; set; }
	public Factory Factory  { get; set; }
	public Product Product  { get; set; }
	public int     Quantity { get; set; }
}