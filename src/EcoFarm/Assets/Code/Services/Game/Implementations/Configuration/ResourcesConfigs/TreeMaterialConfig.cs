using System;
using UnityEngine;

namespace EcoFarm
{
    [Serializable]
    public class TreeMaterialConfig : ITreeMaterialConfig
    {
        [field: SerializeField] public Material Outline { get; private set; }
        [field: SerializeField] public Material Default { get; private set; }
    }
}