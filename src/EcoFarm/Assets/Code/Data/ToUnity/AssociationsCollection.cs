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
		private Dictionary<string, Sprite> _dictionary;

		public AssociationsCollection() => _dictionary = new Dictionary<string, Sprite>();

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
			
			_dictionary = products
			              .Where((p) => _dictionary.ContainsKey(p.Title) == false)
			              .ToDictionary<Product, string, Sprite>((p) => p.Title, (_) => null)
			              .Concat(_dictionary)
			              .ToDictionary((p) => p.Key, (p) => p.Value)
				;

			Associations = _dictionary.Select((p) => new Association(p.Key, p.Value)).ToList();
		}

		private void AddNew(Product p) => _dictionary.Add(p.Title, null);

		private bool IsNotAlreadyInDictionary(Product p) => _dictionary.ContainsKey(p.Title) == false;
	}
}