using UnityEngine;

namespace EcoFarm
{
    public interface IPrefabDataProvider
    {
        GameObject PlayerChoiceView { get; }
        EnabledView EnabledView { get; }
    }
}