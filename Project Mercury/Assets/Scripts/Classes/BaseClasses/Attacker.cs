using Assets.Scripts.Dto;
using Assets.Scripts.Abilities.Attacker;

namespace Assets.Scripts.Classes.BaseClasses
{
    public class Attacker : IBaseClass, IHaveAbilities<AttackerAbilityList>
    {
        private const int _health = 100;
        private const int _energy = 100;
        private const int _attack = 200;
        private const int _defense = 100;
        private const int _speed = 150;

        public AttackerAbilityList AbilityOne { get; set; }
        public AttackerAbilityList AbilityTwo { get; set; }
        public AttackerAbilityList AbilityThree { get; set; }

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
            return ClassName.Attacker;
        }

        public void UseAbilityOne()
        {
            AttackerAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            AttackerAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            AttackerAbilityFactory.ActivateAbility(AbilityThree);
        }
    }
}
