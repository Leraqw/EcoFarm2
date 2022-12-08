using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace EcoFarmAdmin;

public static class Serializer
{
	public static void Serialize()
	{
		var devObjects = DataBaseConnection.CurrentContext.DevObjects.ToArray();
		var products = DataBaseConnection.CurrentContext.Products.ToArray();
		var trees = DataBaseConnection.CurrentContext.Trees.ToArray();
		var levels = DataBaseConnection.CurrentContext.Levels.ToArray();
		var devObjectOnLevelStartups = DataBaseConnection.CurrentContext.DevObjectsOnLevelsStartup.ToArray();
		var goals = DataBaseConnection.CurrentContext.Goals.ToArray();
		var resources = DataBaseConnection.CurrentContext.Resources.ToArray();
		var buildings = DataBaseConnection.CurrentContext.Buildings.ToArray();
		var generators = DataBaseConnection.CurrentContext.Generators.ToArray();
		var factories = DataBaseConnection.CurrentContext.Factories.ToArray();
		var inputProducts = DataBaseConnection.CurrentContext.InputProducts.ToArray();
		var outputProducts = DataBaseConnection.CurrentContext.OutputProducts.ToArray();

		// save file dialog for .json
		var saveFileDialog = new SaveFileDialog
		{
			Filter = "JSON files (*.json)|*.json",
			FilterIndex = 1,
			RestoreDirectory = true,
		};

		if (saveFileDialog.ShowDialog() == false)
		{
			return;
		}

		var json = SerializeObject
		(
			new
			{
				devObjects,
				products,
				trees,
				levels,
				devObjectOnLevelStartups,
				goals,
				resources,
				buildings,
				generators,
				factories,
				inputProducts,
				outputProducts,
			}
		);

		File.WriteAllText(saveFileDialog.FileName, json);

		MessageBox.Show
		(
			$"Файлы были успешно сохранены в {saveFileDialog.FileName}",
			"Успех",
			MessageBoxButton.OK,
			MessageBoxImage.Information
		);
	}

	private static string SerializeObject(object data)
		=> JsonConvert.SerializeObject(data, Formatting.Indented, Settings);

	private static JsonSerializerSettings Settings
		=> new()
		{
			PreserveReferencesHandling = PreserveReferencesHandling.Objects,
			TypeNameHandling = TypeNameHandling.All,
		};
}