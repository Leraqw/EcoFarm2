using System.Collections.Generic;
using System.Linq;
using Code.Data.StorageJson;
using EcoFarmDataModule;
using UnityEngine;

namespace Code.Data.ToUnity
{
	[CreateAssetMenu(fileName = "Associations", menuName = "ScriptableObject/Association")]
	public class Associations : ScriptableObject
	{
		[SerializeField] private List<Product> _products;

		private Storage _storage;

		public void UpdateResources()
		{
			_storage = new StorageAccess().Storage;

			// Get all products from goals in levels where is Goal by Development object
			_products = _storage.Levels
			                    .SelectMany((l) => l.Goals)
			                    .OfType<GoalByDevelopmentObject>()
			                    .Select((g) => g.DevelopmentObject)
			                    .OfType<Product>()
			                    .ToList();
		}
	}
}