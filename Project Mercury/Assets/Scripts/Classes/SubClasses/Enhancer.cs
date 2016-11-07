using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Enhancer : ISubclass
    {
        private const int _health = 75;
        private const int _energy = 75;
        private const int _attack = 75;
        private const int _defense = 75;
        private const int _speed = 75;

        void ISubclass.AbilityOne()
        {
            Debug.Log("ENHANCER Ability One Pressed");
        }

        void ISubclass.AbilityTwo()
        {
            Debug.Log("ENHANCER Ability Two Pressed");
        }

        void ISubclass.AbilityThree()
        {
            Debug.Log("ENHANCER Ability Three Pressed");
        }

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
    }
}