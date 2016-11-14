using Assets.Scripts.Abilities.Enhancer;
using Assets.Scripts.Dto;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Enhancer : ISubclass
    {
        private const int _health = 75;
        private const int _energy = 75;
        private const int _attack = 75;
        private const int _defense = 75;
        private const int _speed = 75;

        public EnhancerAbilityList AbilityOne { get; set; }
        public EnhancerAbilityList AbilityTwo { get; set; }
        public EnhancerAbilityList AbilityThree { get; set; }

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
            EnhancerAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            EnhancerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            EnhancerAbilityFactory.ActivateAbility(AbilityThree);
        }

        public ClassName GetClassName()
        {
            return ClassName.Enhancer;
        }
    }
}