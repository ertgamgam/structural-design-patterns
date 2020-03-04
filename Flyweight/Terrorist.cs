using System;

namespace Flyweight
{
    public class Terrorist : Player
    {
        public Terrorist()
        {
            base.Weapon = "DEFAULT TERRORIST WEAPON!";
            base.Task = "PLANT A BOMB!";
        }

        public override void AssignWeapon(string weapon)
        {
            base.Weapon = weapon;
        }

        public override void DoMission()
        {
            Console.Out.WriteLine($"Terrorist with weapon {base.Weapon} | Task is {base.Task}");
        }
    }
}