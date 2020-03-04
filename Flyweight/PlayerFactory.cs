using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class PlayerFactory
    {
        private static Dictionary<PlayerType, Player> _players = new Dictionary<PlayerType, Player>();

        public static Player GetPlayer(PlayerType type)
        {
            Player player = null;
            if (_players.ContainsKey(type))
            {
                player = _players[type];
            }
            else
            {
                player = CreatePlayerByType(type);
                _players.Add(type, player);
            }

            return player;
        }

        private static Player CreatePlayerByType(PlayerType type)
        {
            Player player = null;
            switch (type)
            {
                case PlayerType.Terrorist:
                {
                    player = new Terrorist();
                    Console.Out.WriteLine("Terrorist Initialized");
                    break;
                }
                case PlayerType.CounterTerrorist:
                {
                    player = new CounterTerrorist();
                    Console.Out.WriteLine("Counter Terrorist Initialized");
                    break;
                }
            }

            return player;
        }
    }
}