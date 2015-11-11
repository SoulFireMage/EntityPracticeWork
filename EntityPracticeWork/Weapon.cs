using System;
namespace EntityPracticeWork
    {
    public interface IWeapon
        {
        string Name { get; }
        string Action { get;  }
        int hitPoints { get; set; }
        }

    public class Sword : IWeapon

        {

        private string _action = "Cuts {0} in half";
       

        public string Action
            {
            get
                {
                return _action;
                }
            }

        private int _hitPoints;
        public int hitPoints
            {
            get
                {
                return _hitPoints;
                }
            set
                {
                _hitPoints = value;
                }
            }
        private string _Name = "Sword";
        public string Name
            {
            get
                {
                return _Name;
                }
            }
        }


    public class shuriken : IWeapon
        {
        private string _Action = "slices and dices in lots of tiny cuts!";
        public string Action
            {
            get
                {
                return _Action;
                }
            }
        private int _hitpoints;
        public int hitPoints
            {
            get
                {
                return _hitpoints;
                }
            set
                {
                _hitpoints = value;
                }
            }

        private string _Name = "shuriken";
        public string Name
            {
            get
                {
                return _Name;
                }
            }
        }
    }
