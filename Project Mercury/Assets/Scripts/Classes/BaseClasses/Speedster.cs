using Assets.Scripts.Player;
using Assets.Scripts.Abilities.Speedster;
using System;

namespace Assets.Scripts.Classes.BaseClasses
{
    public class Speedster : IBaseClass, IHaveAbilities<SpeedsterAbilityList>
    {
        private const int _health = 200;
        private const int _energy = 100;
        private const int _attack = 125;
        private const int _defense = 75;
        private const int _speed = 200;

        public SpeedsterAbilityList AbilityOne { get; set; }
        public SpeedsterAbilityList AbilityTwo { get; set; }
        public SpeedsterAbilityList AbilityThree { get; set; }

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

        public ClassName GetClassName()
        {
            return ClassName.Speedster;
        }

        public void UseAbilityOne()
        {
            SpeedsterAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            SpeedsterAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            SpeedsterAbilityFactory.ActivateAbility(AbilityThree);
        }
    }
}
