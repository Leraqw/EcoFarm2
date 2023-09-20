using System.Linq;
using UnityEngine;

namespace EcoFarm
{
    public class SellDealProductToggle : MonoBehaviour
    {
        [SerializeField] private ItemName _itemName;

        private static GameContext Context => Contexts.sharedInstance.game;

        public void SetProduct()
        {
            var product = Context.storage.Value.Trees.First(t => t.Title == _itemName).Product;
            Context.sellDealEntity.ReplaceProduct(product);
        }
    }
}