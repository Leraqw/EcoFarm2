using UnityEngine;

namespace EcoFarm
{
    public interface ITreeSpritesConfig
    {
        Sprite Dry { get; }
        Sprite Normal { get; }
        Sprite Rotten { get; }
    }
}