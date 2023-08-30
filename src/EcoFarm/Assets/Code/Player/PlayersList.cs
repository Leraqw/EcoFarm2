using System;
using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEditor;
using UnityEngine;
using Zenject;
using static GameMatcher;

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
            if (!IsNicknameUnique(nickname)) return;

            Players.Insert(0, new Player(nickname, 0));
            SaveChanges();
        }

        public void ChangePlayer(Player player, string newNickname)
        {
            if (!IsNicknameUnique(newNickname)) return;

            var index = Players.IndexOf(player);

            if (index != -1)
            {
                Players[index].Nickname = newNickname;
                SaveChanges();
            }
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

        private bool IsNicknameUnique(string nickname)
        {
            var index = Players.FindIndex(p => p.Nickname.Equals(nickname));
            var isUnique = index == -1;

            if (!isUnique)
            {
                Contexts.sharedInstance.game
                    .modalWindowEntity
                    .ReplaceModalWindowData(
                        "Это имя уже занято",
                        "Пожалуйста, введите другое имя");
            }

            return isUnique;
        }
    }
}