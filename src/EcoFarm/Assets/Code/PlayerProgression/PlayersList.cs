using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

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