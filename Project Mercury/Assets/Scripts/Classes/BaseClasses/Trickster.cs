using Assets.Scripts.Dto;
using Assets.Scripts.Abilities.Trickster;

namespace Assets.Scripts.Classes.BaseClasses
{
    public class Trickster : IBaseClass, IHaveAbilities<TricksterAbilityList>
    {
        private const int _health = 200;
        private const int _energy = 100;
        private const int _attack = 125;
        private const int _defense = 75;
        private const int _speed = 200;

        public TricksterAbilityList AbilityOne { get; set; }
        public TricksterAbilityList AbilityTwo { get; set; }
        public TricksterAbilityList AbilityThree { get; set; }

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

        public ClassName GetClassName()
        {
            return ClassName.Trickster;
        }

        public void UseAbilityOne()
        {
            TricksterAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            TricksterAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            TricksterAbilityFactory.ActivateAbility(AbilityThree);
        }
    }
}
