using System;
namespace EntityPracticeWork
    {
    public abstract class Warrior
        {
        public virtual IWeapon weapon { get; }
        public virtual string Name { get; set; }
        public virtual string WarriorClass { get; }
        public  int Health { get; set; } //experiment with new vs override
       // public   Warrior() { }
        }

    public class ninja : Warrior
        {
        public  ninja() : this("You Did not Name Me")
            { }
        public ninja(string name) 
            {
                Name = name;
            }
        }

    public class samurai :Warrior
        {
        public samurai() : this("Unnamed Samurai")
            { }
        public samurai(string name)
            {
            Name = name;
            }
        }

    }