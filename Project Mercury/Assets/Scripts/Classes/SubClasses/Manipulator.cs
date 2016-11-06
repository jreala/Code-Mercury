using Assets.Scripts.Player;
using UnityEngine;

namespace Assets.Scripts.Classes.SubClasses
{
    public class Manipulator : ISubclass
    {
        private const int _health = 50;
        private const int _energy = 100;
        private const int _attack = 50;
        private const int _defense = 50;
        private const int _speed = 25;

        void ISubclass.AbilityOne()
        {
            Debug.Log("MANIPULATOR Ability One Pressed");
        }

        void ISubclass.AbilityTwo()
        {
            Debug.Log("MANIPULATOR Ability Two Pressed");
        }

        void ISubclass.AbilityThree()
        {
            Debug.Log("MANIPULATOR Ability Three Pressed");
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