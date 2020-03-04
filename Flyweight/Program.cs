using System;

// https://www.geeksforgeeks.org/flyweight-design-pattern/
namespace Flyweight
{
    class Program
    {
        private static readonly PlayerType[] PlayerTypes = {PlayerType.Terrorist, PlayerType.CounterTerrorist};

        private static readonly string[] Weapons = {"AK-47", "Maverick", "Gut Knife", "Desert Eagle"};

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Player player = PlayerFactory.GetPlayer(GetRandomPlayerType());
                player.AssignWeapon(GetRandomWeapon());
                player.DoMission();
            }
        }

        private static PlayerType GetRandomPlayerType()
        {
            var randIndex = new Random().Next(PlayerTypes.Length);
            return PlayerTypes[randIndex];
        }

        private static string GetRandomWeapon()
        {
            var randIndex = new Random().Next(Weapons.Length);
            return Weapons[randIndex];
        }
    }
}