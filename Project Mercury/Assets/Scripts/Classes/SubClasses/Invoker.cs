using Assets.Scripts.Player;
using Assets.Scripts.Abilities.Invoker;
using System;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Invoker : ISubclass
    {
        private const int _health = 50;
        private const int _energy = 200;
        private const int _attack = 100;
        private const int _defense = 0;
        private const int _speed = 25;

        public InvokerAbilityList AbilityOne { get; set; }
        public InvokerAbilityList AbilityTwo { get; set; }
        public InvokerAbilityList AbilityThree { get; set; }

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
            InvokerAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            InvokerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            InvokerAbilityFactory.ActivateAbility(AbilityThree);
        }

        public ClassName GetClassName()
        {
            return ClassName.Invoker;
        }
    }
}