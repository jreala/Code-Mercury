using System;
using Assets.Scripts.Player;
using Assets.Scripts.Abilities.Tracker;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Tracker : ISubclass
    {
        private const int _health = 50;
        private const int _energy = 100;
        private const int _attack = 50;
        private const int _defense = 50;
        private const int _speed = 25;
        
        public TrackerAbilityList AbilityOne { get; set; }
        public TrackerAbilityList AbilityTwo { get; set; }
        public TrackerAbilityList AbilityThree { get; set; }

        public Attributes GetAttributes()
        {
            return new Attributes
            {
                Health = _health,
                Energy = _energy,
                Attack = _attack,
                Defense = _defense,
                Speed = _speed
            };
        }

        public void UseAbilityOne()
        {
            TrackerAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            TrackerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            TrackerAbilityFactory.ActivateAbility(AbilityThree);
        }
    }
}