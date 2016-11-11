using Assets.Scripts.Player;
using Assets.Scripts.Abilities.Manipulator;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Manipulator : ISubclass
    {
        private const int _health = 50;
        private const int _energy = 100;
        private const int _attack = 50;
        private const int _defense = 50;
        private const int _speed = 25;

        public ManipulatorAbilityList AbilityOne { get; set; }
        public ManipulatorAbilityList AbilityTwo { get; set; }
        public ManipulatorAbilityList AbilityThree { get; set; }

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
            ManipulatorAbilityFactory.ActivateAbility(AbilityOne);
        }

        public void UseAbilityTwo()
        {
            ManipulatorAbilityFactory.ActivateAbility(AbilityTwo);
        }

        public void UseAbilityThree()
        {
            ManipulatorAbilityFactory.ActivateAbility(AbilityThree);
        }
    }
}