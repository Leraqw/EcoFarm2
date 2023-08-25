using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
    public struct ModeButtonColorBlocks
    {
        public ColorBlock ModeButtonColorBlock;

        public ModeButtonColorBlocks(Color selectedColor)
        {
            ModeButtonColorBlock = new ColorBlock
            {
                normalColor = Color.white, highlightedColor = Color.white, pressedColor = Color.white,
                selectedColor = selectedColor,
                colorMultiplier = 1
            };
        }
    }
}