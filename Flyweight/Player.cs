using System;

namespace Flyweight
{
    public abstract class Player
    {
        protected String Task { get; set; }
        protected String Weapon { get; set; }
        public abstract void AssignWeapon(String weapon);
        public abstract void DoMission();
    }
}