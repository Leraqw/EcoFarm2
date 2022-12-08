using System.Windows;

namespace EcoFarmAdmin;

public static class PropertyExtensions
{
	public static Visibility AsVisibility(this bool @this) => @this ? Visibility.Visible : Visibility.Hidden;
}