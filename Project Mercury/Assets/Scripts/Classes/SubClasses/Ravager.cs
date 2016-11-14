using Assets.Scripts.Dto;
using Assets.Scripts.Abilities.Ravager;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Ravager : ISubclass
    {
        private const int _health = 125;
        private const int _energy = 50;
        private const int _attack = 100;
        private const int _defense = 50;
        private const int _speed = 25;

        public RavagerAbilityList AbilityOne { get; set; }
        public RavagerAbilityList AbilityTwo { get; set; }
        public RavagerAbilityList AbilityThree { get; set; }

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
            RavagerAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            RavagerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            RavagerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public ClassName GetClassName()
        {
            return ClassName.Ravager;
        }
    }
}