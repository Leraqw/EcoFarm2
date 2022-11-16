using System.Collections.Generic;
using System.Linq;
using Code.Data.StorageJson;
using EcoFarmDataModule;
using UnityEngine;
using Code.Utils.Extensions;
using UnityEngine.Serialization;

namespace Code.Data.ToUnity
{
	[CreateAssetMenu(fileName = "SpriteSheet", menuName = "ScriptableObject/SpriteSheet")]
	public class SpriteSheet : ScriptableObject
	{
		[FormerlySerializedAs("_associations")] [SerializeField] private List<Association> _products;

		public Dictionary<string, Sprite> Dictionary => _products.ToDictionary((x) => x.Title, (x) => x.Sprite);

		public void UpdateResources()
			=> new StorageAccess()
			   .Storage.Products
			   .ForEach(AddNew, @if: IsNotAlreadyInDictionary);

		private bool IsNotAlreadyInDictionary(Product product)
			=> _products.Any((p) => product.Title == p.Title) == false;

		private void AddNew(Product product) => _products.Add(new Association(product.Title));
	}
}