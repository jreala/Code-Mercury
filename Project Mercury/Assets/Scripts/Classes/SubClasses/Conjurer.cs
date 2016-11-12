using System;
using Assets.Scripts.Abilities.Conjurer;
using Assets.Scripts.Player;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Conjurer : ISubclass
    {
        private const int _health = 50;
        private const int _energy = 100;
        private const int _attack = 50;
        private const int _defense = 50;
        private const int _speed = 25;

        public ConjurerAbilityList AbilityOne { get; set; }
        public ConjurerAbilityList AbilityTwo { get; set; }
        public ConjurerAbilityList AbilityThree { get; set; }

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
            ConjurerAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            ConjurerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            ConjurerAbilityFactory.ActivateAbility(AbilityThree);
        }

        public ClassName GetClassName()
        {
            return ClassName.Conjurer;
        }
    }
}