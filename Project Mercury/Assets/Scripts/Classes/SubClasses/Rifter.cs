using Assets.Scripts.Dto;
using Assets.Scripts.Abilities.Rifter;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Rifter : ISubclass
    {
        private const int _health = 50;
        private const int _energy = 150;
        private const int _attack = 50;
        private const int _defense = 50;
        private const int _speed = 25;

        public RifterAbilityList AbilityOne { get; set; }
        public RifterAbilityList AbilityTwo { get; set; }
        public RifterAbilityList AbilityThree { get; set; }

        public AttributesDto GetAttributes()
        {
            return new AttributesDto
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
            RifterAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            RifterAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            RifterAbilityFactory.ActivateAbility(AbilityThree);
        }

        public ClassName GetClassName()
        {
            return ClassName.Rifter;
        }
    }
}