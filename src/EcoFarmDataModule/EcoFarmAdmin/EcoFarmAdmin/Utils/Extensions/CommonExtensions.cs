namespace EcoFarmAdmin;

public static class CommonExtensions
{
	public static T SetFrom<T>(this T @this, T other)
		where T : notnull
	{
		foreach (var property in @this.GetType().GetProperties())
		{
			property.SetValue(@this, property.GetValue(other));
		}
		
		return @this;
	}

	public static T Clone<T>(this T @this)
		where T : notnull, new()
		=> new T().SetFrom(@this);
}