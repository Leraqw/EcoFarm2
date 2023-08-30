using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
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

        public void AddPlayer(string nickname)
        {
            if (IsNicknameInPlayerList(nickname) == false)
            {
                Debug.LogWarning($"player with {nickname} nickname already exists");
                return;
            }

            Players.Insert(0, new Player(nickname, 0));
            SaveChanges();
        }

        private bool IsNicknameInPlayerList(string nickname)
        {
            var index = Players.FindIndex(p => p.Nickname.Equals(nickname));
            return index == -1;
        }

        public void RemovePlayer(Player player)
        {
            var index = Players.IndexOf(player);
            if (index != -1)
            {
                Players.Remove(Players[index]);
                SaveChanges();
            }
        }
    }
}