using UnityEngine;

namespace EcoFarm
{
    public interface ITreeMaterialConfig
    {
        Material Outline { get; }
        Material Default { get; }
    }
}