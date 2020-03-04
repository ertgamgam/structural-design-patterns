using System;

namespace Flyweight
{
    public class CounterTerrorist : Player
    {
        public CounterTerrorist()
        {
            base.Weapon = "DEFAULT COUNTER TERRORIST WEAPON!";
            base.Task = "DIFFUSE BOMB!";
        }

        public override void AssignWeapon(string weapon)
        {
            base.Weapon = weapon;
        }

        public override void DoMission()
        {
            Console.Out.WriteLine($"Counter Terrorist with weapon {base.Weapon} | Task is {base.Task}");
        }
    }
}