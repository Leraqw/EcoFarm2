namespace EcoFarm
{
    public static class PlayerExtensions
    {
        public static int FindPlayerIndex(Player player)
        {
            var players = ServicesMediator.DataProvider.PlayersList.Players;
            return players.FindIndex(p => p.Equals(player));
        }

        public static bool IsNicknameUnique(this string nickname)
        {
            var players = ServicesMediator.DataProvider.PlayersList.Players;
            var index = players.FindIndex(p => p.Nickname.Equals(nickname));
            return index == -1;
        }
    }
}