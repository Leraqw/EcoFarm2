using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public static class PlayerExtensions
    {
        private static PlayerEntity PlayerListEntity => Context.GetEntities(PlayerListLengthChanged).First();
        private static PlayerContext Context => Contexts.sharedInstance.player;

        public static int FindPlayerIndex(Player player)
        {
            var players = ServicesMediator.DataProvider.PlayersList.Players;
            return players.FindIndex(p => p.Equals(player));
        }

        private static bool IsNicknameInPlayerList(this string nickname)
        {
            var players = ServicesMediator.DataProvider.PlayersList.Players;
            var index = players.FindIndex(p => p.Nickname.Equals(nickname));
            return index == -1;
        }

        public static void MovePlayerToTop(this List<Player> playerList, Player player)
        {
            var index = FindPlayerIndex(player);
            if (index != -1)
            {
                playerList.RemoveAt(index);
                playerList.Insert(0, player);
            }
        }

        public static void AddPlayer(this PlayersList list, string nickname)
        {
            var players = list.Players;

            if (nickname.IsNicknameInPlayerList() == false)
            {
                Debug.LogWarning($"player with {nickname} nickname already exists");
                return;
            }

            players.Add(new Player(nickname, 0));
            list.SaveChanges();

            PlayerListEntity.ReplacePlayerListLengthChanged(players.Count);
        }

        public static void RemovePlayer(this PlayersList list, Player player)
        {
            var players = list.Players;

            var index = FindPlayerIndex(player);
            if (index != -1) players.Remove(players[index]);

            list.SaveChanges();

            PlayerListEntity.ReplacePlayerListLengthChanged(players.Count);
        }
    }
}