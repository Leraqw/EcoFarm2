using System;
using UnityEngine;

namespace EcoFarm
{
    [Serializable]
    public class ResourceConfig : IResourceConfig
    {
        [SerializeField] private PrefabConfig _prefab;
        [SerializeField] private SpriteConfig _sprite;
        [SerializeField] private TreeMaterialConfig _material;

        public IPrefabConfig Prefab => _prefab;
        public ISpriteConfig Sprite => _sprite;
        public ITreeMaterialConfig Material => _material;
    }
}