using Assets.Scripts.Player;
using Assets.Scripts.Abilities.Defender;

namespace Assets.Scripts.Classes.BaseClasses
{
    public class Defender : IBaseClass
    {
        private const int _health = 200;
        private const int _energy = 100;
        private const int _attack = 100;
        private const int _defense = 200;
        private const int _speed = 75;

        public DefenderAbilityList AbilityOne { get; set; }
        public DefenderAbilityList AbilityTwo { get; set; }
        public DefenderAbilityList AbilityThree { get; set; }

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
            return ClassName.Defender;
        }

        public void UseAbilityOne()
        {
            DefenderAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            DefenderAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            DefenderAbilityFactory.ActivateAbility(AbilityThree);
        }
    }
}
