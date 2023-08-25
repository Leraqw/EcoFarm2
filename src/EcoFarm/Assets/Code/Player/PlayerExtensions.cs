namespace EcoFarm
{
    public static class PlayerExtensions
    {
        public static int FindPlayerIndex(Player player)
        {
            var players = ServicesMediator.DataProvider.PlayersList.Players;
            return players.FindIndex(p => p.Equals(player));
        }
    }
}