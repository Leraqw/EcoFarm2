using System;
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

			Associations = _products
			               .Select(GetOrAdd)
			               .ToList();
		}

		private Association GetOrAdd(Product p) => Contains(p) ? SelectFromCollection(p) : CreateNew(p);

		private static Association CreateNew(DevelopmentObject p) => new(p.Title);

		private Association SelectFromCollection(DevelopmentObject p) => Associations.Single((a) => a.Title == p.Title);

		private bool Contains(DevelopmentObject p) => Associations.Select((a) => a.Title).Contains(p.Title);
	}

	[Serializable]
	public class Association
	{
		public string Title;
		public Sprite Sprite;

		public Association(string title)
		{
			Title = title;
		}
	}
}