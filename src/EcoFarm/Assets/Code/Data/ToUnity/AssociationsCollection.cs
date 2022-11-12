using System.Collections.Generic;
using System.Linq;
using Code.Data.StorageJson;
using EcoFarmDataModule;
using UnityEngine;

namespace Code.Data.ToUnity
{
	[CreateAssetMenu(fileName = "Associations", menuName = "ScriptableObject/Association")]
	public class AssociationsCollection : ScriptableObject
	{
		[field: SerializeField] public List<Association> Associations { get; private set; }

		private List<Product> _products;
		private Storage _storage;
		private Dictionary<string, Sprite> _dictionary;

		public AssociationsCollection() => _dictionary = new Dictionary<string, Sprite>();

		public void UpdateResources()
		{
			_storage = new StorageAccess().Storage;

			// Get all Products from Goals in Levels where is Goal by Development Object
			_products = _storage.Levels
			                    .SelectMany((l) => l.Goals)
			                    .OfType<GoalByDevelopmentObject>()
			                    .Select((g) => g.DevelopmentObject)
			                    .OfType<Product>()
			                    .ToList();

			// Add new products to dictionary
			var newValues = _products
			              .Where((p) => _dictionary.ContainsKey(p.Title) == false)
			              .Select((p) => new Association(p.Title))
			              .ToDictionary((a) => a.Title, (a) => a.Sprite);
			
			_dictionary = _dictionary.Concat(newValues).ToDictionary((p) => p.Key, (p) => p.Value);

			Associations = _dictionary.Select((p) => new Association(p.Key, p.Value)).ToList(); 
		}
	}
}