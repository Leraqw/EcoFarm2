using System.Windows;

namespace EcoFarmAdmin;

public static class WindowExtensions
{
	public static void Submit(this Window window) => window.DialogResult = true;

	public static void Cancel(this Window window) => window.DialogResult = false;
}