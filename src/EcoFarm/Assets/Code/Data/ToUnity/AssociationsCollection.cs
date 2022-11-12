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
		[SerializeField] private List<Association> _associations;

		public Dictionary<string, Sprite> Dictionary => _associations.ToDictionary((x) => x.Title, (x) => x.Sprite);

		public void UpdateResources()
			=> new StorageAccess()
			   .Storage.Levels
			   .SelectMany((l) => l.Goals)
			   .OfType<GoalByDevelopmentObject>()
			   .Select((g) => g.DevelopmentObject)
			   .OfType<Product>()
			   .ForEach(AddNew, @if: IsNotAlreadyInDictionary);

		private bool IsNotAlreadyInDictionary(Product product)
			=> _associations.Any((p) => product.Title == p.Title) == false;

		private void AddNew(Product product) => _associations.Add(new Association(product.Title));
	}
}