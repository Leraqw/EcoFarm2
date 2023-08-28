using System;
using UnityEngine;

namespace EcoFarm
{
    [Serializable]
    public class Player
    {
        [field: SerializeField] public string Nickname { get; private set; }
        [field: SerializeField] public int CompletedLevelsCount { get; set; }

        public Player(string nickname, int completedLevelsCount)
        {
            Nickname = nickname;
            CompletedLevelsCount = completedLevelsCount;
        }

        public bool Equals(Player other) =>
            Nickname == other.Nickname
            && CompletedLevelsCount == other.CompletedLevelsCount;

        public override int GetHashCode() => HashCode.Combine(Nickname, CompletedLevelsCount);
    }
}