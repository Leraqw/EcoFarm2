using System.Collections.Generic;
using System.Linq;
using Code.Data.StorageJson;
using EcoFarmDataModule;
using UnityEngine;
using Code.Utils.Extensions;

namespace Code.Data.ToUnity
{
	[CreateAssetMenu(fileName = "Associations", menuName = "ScriptableObject/Association")]
	public class AssociationsCollection : ScriptableObject
	{
		[field: SerializeField] public List<Association> Associations { get; private set; }

		private Storage _storage;

		public void UpdateResources()
		{
			_storage = new StorageAccess().Storage;

			// Get all Products from Goals in Levels where is Goal by Development Object
			var products = _storage.Levels
			                       .SelectMany((l) => l.Goals)
			                       .OfType<GoalByDevelopmentObject>()
			                       .Select((g) => g.DevelopmentObject)
			                       .OfType<Product>()
			                       .ToList();

			// Add new products to dictionary without resetting old
			products.ForEach(AddNew, @if: IsNotAlreadyInDictionary);
		}

		private bool IsNotAlreadyInDictionary(Product product)
			=> Associations.Any((p) => product.Title == p.Title) == false;

		private void AddNew(Product product) => Associations.Add(new Association(product.Title));
	}
}