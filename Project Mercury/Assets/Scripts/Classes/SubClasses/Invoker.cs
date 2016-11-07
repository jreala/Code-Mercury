using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Invoker : ISubclass
    {
        private const int _health = 50;
        private const int _energy = 200;
        private const int _attack = 100;
        private const int _defense = 0;
        private const int _speed = 25;

        void ISubclass.AbilityOne()
        {
            Debug.Log("INVOKER Ability One Pressed");
        }

        void ISubclass.AbilityTwo()
        {
            Debug.Log("INVOKER Ability Two Pressed");
        }

        void ISubclass.AbilityThree()
        {
            Debug.Log("INVOKER Ability Three Pressed");
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