using System;
using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEditor;
using UnityEngine;
using static EcoFarm.PlayerExtensions;
using static PlayerMatcher;

namespace EcoFarm
{
    [Serializable]
    [CreateAssetMenu(fileName = "Players", menuName = Constants.RootNamespace + "Players")]
    public class PlayersList : ScriptableObject
    {
        [field: SerializeField] public List<Player> Players { get; set; }

        public void SaveChanges()
        {
            EditorUtility.SetDirty(this);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}